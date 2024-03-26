
namespace ContactsApp
{
    partial class ImportSelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportSelectionForm));
            this.ImportFromFileButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.GithubImportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ImportFromFileButton
            // 
            this.ImportFromFileButton.Location = new System.Drawing.Point(28, 12);
            this.ImportFromFileButton.Name = "ImportFromFileButton";
            this.ImportFromFileButton.Size = new System.Drawing.Size(115, 40);
            this.ImportFromFileButton.TabIndex = 0;
            this.ImportFromFileButton.Text = "Importēt datus no lokāla faila";
            this.ImportFromFileButton.UseVisualStyleBackColor = true;
            this.ImportFromFileButton.Click += new System.EventHandler(this.ImportFromFileButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(28, 224);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(100, 25);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Atpakaļ";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // GithubImportButton
            // 
            this.GithubImportButton.Location = new System.Drawing.Point(28, 67);
            this.GithubImportButton.Name = "GithubImportButton";
            this.GithubImportButton.Size = new System.Drawing.Size(115, 40);
            this.GithubImportButton.TabIndex = 2;
            this.GithubImportButton.Text = "Importēt datus no GitHub";
            this.GithubImportButton.UseVisualStyleBackColor = true;
            this.GithubImportButton.Click += new System.EventHandler(this.GithubImportButton_Click);
            // 
            // ImportSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 261);
            this.Controls.Add(this.GithubImportButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ImportFromFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportSelectionForm";
            this.Text = "Datu imports";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ImportFromFileButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button GithubImportButton;
    }
}