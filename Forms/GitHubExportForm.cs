using Octokit;
using System;
using System.Windows.Forms;

namespace ContactsApp
{
    public partial class GitHubExportForm : Form
    {
        public GitHubExportForm()
        {
            InitializeComponent();
            this.BranchBox.Text = "main";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void SaveToGithubButton_Click(object sender, EventArgs e)
        {
            var username = UsernameBox.Text;
            var branch = BranchBox.Text;
            var repoAddress = RepoAddressBox.Text;
            var commitMessage = CommitMessageBox.Text;
            var result = await SynchronizationManager.SaveToGithub(username, repoAddress, branch, commitMessage);
            if(result != null)
            {
                MessageBox.Show(result, "Kļūda!", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show($"Dati veiksmīgi saglabāti GitHub repozitorijā: {repoAddress}", "Dati saglabāti", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
