
namespace ContactsApp
{
    partial class GithubImportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GithubImportForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            this.TokenBox = new System.Windows.Forms.TextBox();
            this.RepoAddressBox = new System.Windows.Forms.TextBox();
            this.BranchBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(54, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "GitHub Token:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(66, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "GitHub repo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repo zars (branch):";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 205);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(100, 40);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Atpakaļ";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(368, 205);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(100, 40);
            this.ImportButton.TabIndex = 5;
            this.ImportButton.Text = "Importēt no GitHub";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // TokenBox
            // 
            this.TokenBox.Location = new System.Drawing.Point(199, 29);
            this.TokenBox.Name = "TokenBox";
            this.TokenBox.Size = new System.Drawing.Size(250, 20);
            this.TokenBox.TabIndex = 6;
            // 
            // RepoAddressBox
            // 
            this.RepoAddressBox.Location = new System.Drawing.Point(199, 71);
            this.RepoAddressBox.Name = "RepoAddressBox";
            this.RepoAddressBox.Size = new System.Drawing.Size(250, 20);
            this.RepoAddressBox.TabIndex = 7;
            // 
            // BranchBox
            // 
            this.BranchBox.Location = new System.Drawing.Point(199, 112);
            this.BranchBox.Name = "BranchBox";
            this.BranchBox.Size = new System.Drawing.Size(250, 20);
            this.BranchBox.TabIndex = 8;
            // 
            // GithubImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 257);
            this.Controls.Add(this.BranchBox);
            this.Controls.Add(this.RepoAddressBox);
            this.Controls.Add(this.TokenBox);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GithubImportForm";
            this.Text = "Datu imports no GitHub";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.TextBox TokenBox;
        private System.Windows.Forms.TextBox RepoAddressBox;
        private System.Windows.Forms.TextBox BranchBox;
    }
}