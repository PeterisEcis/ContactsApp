using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp
{
    public partial class ImportSelectionForm : Form
    {
        private bool _dataWillBeOverwritten = false;
        public ImportSelectionForm(bool dataWillBeOverwritten)
        {
            InitializeComponent();
            this._dataWillBeOverwritten = dataWillBeOverwritten;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Importēt datus no cita datubāžu faila
        // Ja izvēlēts .db fails, to pārkopē pareizajā vietā un pārsauc par database.db
        private void ImportFromFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Database Files (*.db)|*.db|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;

                // Check if the selected file has .db extension
                if (Path.GetExtension(selectedFileName).Equals(".db", StringComparison.OrdinalIgnoreCase))
                {
                    // Specify the destination directory and file name
                    string destinationDirectory = Directory.GetCurrentDirectory();
                    string destinationFilePath = Path.Combine(destinationDirectory, Constants.DatabaseName);

                    if (this._dataWillBeOverwritten)
                    {
                        var result = MessageBox.Show("Esošie dati tiks dzēsti. Vai turpināt datu importēšanu?", "Uzmanību!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if(result == DialogResult.Yes)
                        {
                            File.Copy(selectedFileName, destinationFilePath, true);
                            MessageBox.Show("Datubāzes fails importēts veiksmīgi.", "Datu imports", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else
                    {
                        // Copy and overwrite the file if it already exists
                        File.Copy(selectedFileName, destinationFilePath, true);
                        MessageBox.Show("Datubāzes fails importēts veiksmīgi.", "Datu imports", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Izvēlies datubāžu (.db) failu.", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GithubImportButton_Click(object sender, EventArgs e)
        {
            using(var githubForm = new GithubImportForm())
            {
                githubForm.ShowDialog();
            }
        }
    }
}
