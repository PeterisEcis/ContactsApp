
using System;

namespace ContactsApp
{
    partial class AddEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditForm));
            this.label1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.PrefixBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NotesBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.BirthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.IsBirthdayPickerActive = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vārds";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(12, 46);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(160, 20);
            this.NameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(207, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Uzvārds";
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(212, 46);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(160, 20);
            this.LastNameBox.TabIndex = 3;
            // 
            // PrefixBox
            // 
            this.PrefixBox.Location = new System.Drawing.Point(172, 135);
            this.PrefixBox.MaxLength = 3;
            this.PrefixBox.Name = "PrefixBox";
            this.PrefixBox.Size = new System.Drawing.Size(48, 20);
            this.PrefixBox.TabIndex = 4;
            this.PrefixBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrefixBox_KeyPress);
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(226, 135);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(146, 20);
            this.PhoneBox.TabIndex = 5;
            this.PhoneBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneBox_KeyPress);
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(144, 178);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(228, 20);
            this.EmailBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Piezīmes";
            // 
            // NotesBox
            // 
            this.NotesBox.Location = new System.Drawing.Point(12, 220);
            this.NotesBox.Multiline = true;
            this.NotesBox.Name = "NotesBox";
            this.NotesBox.Size = new System.Drawing.Size(360, 180);
            this.NotesBox.TabIndex = 8;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(235, 416);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(137, 33);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Saglabāt";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 416);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(137, 33);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Atpakaļ";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BirthdayPicker
            // 
            this.BirthdayPicker.CustomFormat = "dd. MM. yyyy.";
            this.BirthdayPicker.Enabled = false;
            this.BirthdayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BirthdayPicker.Value = DateTime.Now;
            this.BirthdayPicker.Location = new System.Drawing.Point(172, 97);
            this.BirthdayPicker.Name = "BirthdayPicker";
            this.BirthdayPicker.Size = new System.Drawing.Size(200, 20);
            this.BirthdayPicker.TabIndex = 11;
            this.BirthdayPicker.Value = new System.DateTime(2024, 3, 26, 0, 0, 0, 0);
            // 
            // IsBirthdayPickerActive
            // 
            this.IsBirthdayPickerActive.AutoSize = true;
            this.IsBirthdayPickerActive.Location = new System.Drawing.Point(151, 103);
            this.IsBirthdayPickerActive.Name = "IsBirthdayPickerActive";
            this.IsBirthdayPickerActive.Size = new System.Drawing.Size(15, 14);
            this.IsBirthdayPickerActive.TabIndex = 12;
            this.IsBirthdayPickerActive.UseVisualStyleBackColor = true;
            this.IsBirthdayPickerActive.CheckStateChanged += new System.EventHandler(this.IsBirthdayPickerActive_CheckStateChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(153, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(71, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "E-pasts:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(100, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tālr:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(23, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Dzimšanas diena:";
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IsBirthdayPickerActive);
            this.Controls.Add(this.BirthdayPicker);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NotesBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.PrefixBox);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditForm";
            this.Text = "AddEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox PrefixBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NotesBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DateTimePicker BirthdayPicker;
        private System.Windows.Forms.CheckBox IsBirthdayPickerActive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}