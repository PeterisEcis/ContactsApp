
namespace ContactsApp
{
    partial class ExportSelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportSelectionForm));
            this.SaveDBFileButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.GithubExportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveDBFileButton
            // 
            this.SaveDBFileButton.Location = new System.Drawing.Point(32, 12);
            this.SaveDBFileButton.Name = "SaveDBFileButton";
            this.SaveDBFileButton.Size = new System.Drawing.Size(122, 45);
            this.SaveDBFileButton.TabIndex = 0;
            this.SaveDBFileButton.Text = "Saglabāt datubāzes failu";
            this.SaveDBFileButton.UseVisualStyleBackColor = true;
            this.SaveDBFileButton.Click += new System.EventHandler(this.SaveDBFileButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(48, 222);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Atpakaļ";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // GithubExportButton
            // 
            this.GithubExportButton.Location = new System.Drawing.Point(32, 73);
            this.GithubExportButton.Name = "GithubExportButton";
            this.GithubExportButton.Size = new System.Drawing.Size(122, 45);
            this.GithubExportButton.TabIndex = 2;
            this.GithubExportButton.Text = "Saglabāt GitHub";
            this.GithubExportButton.UseVisualStyleBackColor = true;
            this.GithubExportButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExportSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 257);
            this.Controls.Add(this.GithubExportButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SaveDBFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportSelectionForm";
            this.Text = "Datu eksports";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveDBFileButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button GithubExportButton;
    }
}