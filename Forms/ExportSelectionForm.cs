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
    public partial class ExportSelectionForm : Form
    {
        public ExportSelectionForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveDBFileButton_Click(object sender, EventArgs e)
        {
            // Check if database.db exists in the current working directory
            string currentDirectory = Directory.GetCurrentDirectory();
            string databaseFilePath = Path.Combine(currentDirectory, Constants.DatabaseName);

            if (File.Exists(databaseFilePath))
            {
                // Prompt user to select a folder where the file will be saved
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.Description = "Izvēlies kur saglabāt datubāzes failu.";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    // Generate new file name with current date and time
                    string newFileName = $"database_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.db";
                    string destinationDirectory = folderBrowserDialog.SelectedPath;
                    string destinationFilePath = Path.Combine(destinationDirectory, newFileName);

                    // Copy the database.db file to the selected folder
                    File.Copy(databaseFilePath, destinationFilePath);
                    MessageBox.Show($"Datubāzes fails saglabāts kā {newFileName} mapē {destinationDirectory}.", "Datu eksports", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Datubāzes fails nav atrasts.", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(var githubExportForm = new GitHubExportForm())
            {
                githubExportForm.ShowDialog();
            }
        }
    }
}
