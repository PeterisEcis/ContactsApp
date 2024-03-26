using Octokit;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace ContactsApp
{
    public static class SynchronizationManager
    {
        public static async Task<string> SaveToGithub(string token, string repositoryUrl, string branch, string commitMessage)
        {
            string databaseFilePath = Path.Combine(Directory.GetCurrentDirectory(), Constants.DatabaseName);
            if (!File.Exists(databaseFilePath))
            {
                return "Datubāzes fails nav atrasts!";
            }

            try
            {
                // Create GitHub client
                var basicAuth = new Credentials(token);
                var github = new GitHubClient(new ProductHeaderValue("MyContactsApp"));
                github.Credentials = basicAuth;

                // Extract owner and repository name from the provided URL
                string[] urlParts = repositoryUrl.TrimEnd('/').Split('/');
                if (urlParts.Length < 2)
                {
                    return "Nav norādīta pareiza GitHub adrese";
                }
                string owner = urlParts[urlParts.Length - 2];
                string repoName = urlParts[urlParts.Length - 1];

                // Check if the repository is empty
                var content = await github.Repository.Content.GetAllContents(owner, repoName);

                // Get latest commit on the default branch
                var commits = await github.Repository.Commit.GetAll(owner, repoName);
                var latestCommitSha = commits[0].Sha;

                // Get tree associated with latest commit
                var latestCommit = await github.Git.Commit.Get(owner, repoName, latestCommitSha);
                var tree = await github.Git.Tree.Get(owner, repoName, latestCommit.Tree.Sha);

                // Read database.db file content
                byte[] fileContent = File.ReadAllBytes(databaseFilePath);

                // Create blob for the database file
                var databaseBlob = new NewBlob
                {
                    Content = Convert.ToBase64String(fileContent),
                    Encoding = EncodingType.Base64
                };
                var databaseBlobResult = await github.Git.Blob.Create(owner, repoName, databaseBlob);

                // Create tree entry for the database file
                var databaseTreeEntry = new NewTreeItem
                {
                    Path = Constants.DatabaseName,
                    Mode = "100644",
                    Type = TreeType.Blob,
                    Sha = databaseBlobResult.Sha
                };

                // Create new tree with database file entry
                var newTree = await github.Git.Tree.Create(owner, repoName, new NewTree { Tree = { databaseTreeEntry } });

                // Create new commit with the new tree
                var newCommit = new NewCommit(commitMessage, newTree.Sha, latestCommitSha);
                var commit = await github.Git.Commit.Create(owner, repoName, newCommit);
                

                // Update reference of the default branch to point to the new commit
                var updateReference = new ReferenceUpdate(commit.Sha);
                await github.Git.Reference.Update(owner, repoName, $"heads/{branch}", updateReference);

                return null;
            }
            /*
            // Gadījumā ja repo ir tukšs
            // Līdz galam nestrādā, tāpēc atstāju aizkomentētu
            catch ( NotFoundException)
            {
                // Create GitHub client
                var basicAuth = new Credentials(username);
                var github = new GitHubClient(new ProductHeaderValue("MyContactsApp"));
                github.Credentials = basicAuth;

                // Extract owner and repository name from the provided URL
                string[] urlParts = repositoryUrl.TrimEnd('/').Split('/');
                string owner = urlParts[urlParts.Length - 2];
                string repoName = urlParts[urlParts.Length - 1];

                // Get the default branch for the repository
                var repository = await github.Repository.Get(owner, repoName);
                var defaultBranch = repository.DefaultBranch;

                // If the repository is empty, create the initial commit
                var initialCommit = new NewCommit("Initial commit", defaultBranch);
                await github.Git.Commit.Create(owner, repoName, initialCommit);

                // If the repository is empty, create the initial commit
                byte[] fileContent = File.ReadAllBytes(databaseFilePath);

                // Create blob for the database file
                var databaseBlob = new NewBlob
                {
                    Content = Convert.ToBase64String(fileContent),
                    Encoding = EncodingType.Base64
                };
                var databaseBlobResult = await github.Git.Blob.Create(owner, repoName, databaseBlob);

                // Create tree entry for the database file
                var databaseTreeEntry = new NewTreeItem
                {
                    Path = Constants.DatabaseName,
                    Mode = "100644",
                    Type = TreeType.Blob,
                    Sha = databaseBlobResult.Sha
                };

                // Create new tree with database file entry
                var newTree = await github.Git.Tree.Create(owner, repoName, new NewTree { Tree = { databaseTreeEntry } });

                // Create new commit with the new tree
                var newCommit = new NewCommit(commitMessage, newTree.Sha);
                var commit = await github.Git.Commit.Create(owner, repoName, newCommit);

                // Update reference of the default branch to point to the new commit
                var updateReference = new ReferenceUpdate(commit.Sha);
                await github.Git.Reference.Update(owner, repoName, defaultBranch, updateReference);
                return null;
            }
            */
            
            catch (Exception ex)
            {
                return $"Kļūda: {ex.Message}";
            }
        }

        public static async Task<string> DownloadFile(string accessToken, string repositoryUrl, string branchName)
        {
            try
            {
                // Create GitHub client
                var github = new GitHubClient(new ProductHeaderValue("MyContactsApp"));
                github.Credentials = new Credentials(accessToken);

                // Extract owner and repository name from the provided URL
                string[] urlParts = repositoryUrl.TrimEnd('/').Split('/');
                if (urlParts.Length < 2)
                {
                    return "Nav norādīta pareiza GitHub adrese";
                }
                string owner = urlParts[urlParts.Length - 2];
                string repoName = urlParts[urlParts.Length - 1];

                // Get the contents of the file
                var fileContent = await github.Repository.Content.GetAllContentsByRef(owner, repoName, Path.GetFileName(Constants.DatabaseName), branchName);

                // Get the download URL of the file
                string downloadUrl = fileContent[0].DownloadUrl;

                // Download the file
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(downloadUrl);
                    response.EnsureSuccessStatusCode();

                    // Read the content and write it to the destination path
                    using (var fileStream = await response.Content.ReadAsStreamAsync())
                    using (var file = File.Create(Path.Combine(Directory.GetCurrentDirectory(), Constants.DatabaseName)))
                    {
                        await fileStream.CopyToAsync(file);
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
               return $"Kļūda: {ex.Message}";
            }
        }
    }
}
