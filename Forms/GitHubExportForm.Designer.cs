
namespace ContactsApp
{
    partial class GitHubExportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GitHubExportForm));
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.BranchBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveToGithubButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.RepoAddressBox = new System.Windows.Forms.TextBox();
            this.CommitMessageBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(200, 14);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(250, 20);
            this.UsernameBox.TabIndex = 0;
            // 
            // BranchBox
            // 
            this.BranchBox.Location = new System.Drawing.Point(200, 95);
            this.BranchBox.Name = "BranchBox";
            this.BranchBox.Size = new System.Drawing.Size(250, 20);
            this.BranchBox.TabIndex = 1;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 208);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(100, 40);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Atpakaļ";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SaveToGithubButton
            // 
            this.SaveToGithubButton.Location = new System.Drawing.Point(372, 209);
            this.SaveToGithubButton.Name = "SaveToGithubButton";
            this.SaveToGithubButton.Size = new System.Drawing.Size(100, 40);
            this.SaveToGithubButton.TabIndex = 5;
            this.SaveToGithubButton.Text = "Eksportēt uz GitHub";
            this.SaveToGithubButton.UseVisualStyleBackColor = true;
            this.SaveToGithubButton.Click += new System.EventHandler(this.SaveToGithubButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(82, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apraksts:";
            // 
            // RepoAddressBox
            // 
            this.RepoAddressBox.Location = new System.Drawing.Point(200, 56);
            this.RepoAddressBox.Name = "RepoAddressBox";
            this.RepoAddressBox.Size = new System.Drawing.Size(250, 20);
            this.RepoAddressBox.TabIndex = 8;
            // 
            // CommitMessageBox
            // 
            this.CommitMessageBox.Location = new System.Drawing.Point(200, 131);
            this.CommitMessageBox.Multiline = true;
            this.CommitMessageBox.Name = "CommitMessageBox";
            this.CommitMessageBox.Size = new System.Drawing.Size(250, 67);
            this.CommitMessageBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(3, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Repo zars (branch):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(57, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "GitHub repo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(45, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "GitHub Token:";
            // 
            // GitHubExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CommitMessageBox);
            this.Controls.Add(this.RepoAddressBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SaveToGithubButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.BranchBox);
            this.Controls.Add(this.UsernameBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GitHubExportForm";
            this.Text = "Datu saglabāšana GitHub";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox BranchBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveToGithubButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RepoAddressBox;
        private System.Windows.Forms.TextBox CommitMessageBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}