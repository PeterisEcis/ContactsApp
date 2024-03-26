using System;
using System.Windows.Forms;

namespace ContactsApp
{
    public partial class GithubImportForm : Form
    {
        public GithubImportForm()
        {
            InitializeComponent();
            this.BranchBox.Text = "main";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void ImportButton_Click(object sender, EventArgs e)
        {
            var token = this.TokenBox.Text;
            var repo = this.RepoAddressBox.Text;
            var branch = this.BranchBox.Text;

            if (string.IsNullOrWhiteSpace(token))
            {
                MessageBox.Show("Nav ievadīts GitHub tokens", "Uzmanību!", MessageBoxButtons.OK);
            }
            else if (string.IsNullOrWhiteSpace(repo))
            {
                MessageBox.Show("Nav ievadīta repozitorija adrese", "Uzmanību!", MessageBoxButtons.OK);
            }
            else if (string.IsNullOrWhiteSpace(branch))
            {
                MessageBox.Show("Nav ievadīts GitHub zars (branch)", "Uzmanību!", MessageBoxButtons.OK);
            }
            else
            {
                var result = await SynchronizationManager.DownloadFile(token, repo, branch);
                if (result != null)
                {
                    MessageBox.Show(result, "Kļūda!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show($"Dati veiksmīgi importēti no GitHub repozitorija: {repo}", "Dati importēti", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }
    }
}
