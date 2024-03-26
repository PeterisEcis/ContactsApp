using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ContactsApp
{
    public partial class MainForm : Form
    {
        private DatabaseManager dbManager;
        private BindingList<Contact> contactsList;

        public MainForm()
        {
            InitializeComponent();
            this.dbManager = new DatabaseManager();
            this.contactsList = new BindingList<Contact>(this.dbManager.GetAllContacts());
            this.ContactsListBox.DataSource = this.contactsList;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (var newContactForm = new AddEditForm())
            {
                newContactForm.ShowDialog();

                if (newContactForm.SaveData)
                {
                    var newContact = new Contact()
                    {
                        Id = this.GetNewId(),
                        FirstName = newContactForm.FirstName,
                        LastName = newContactForm.LastName,
                        Birthday = newContactForm.Birthday,
                        PhonePrefix = newContactForm.PhonePrefix,
                        PhoneNumber = newContactForm.PhoneNumber,
                        Email = newContactForm.Email,
                        Notes = newContactForm.Notes
                    };
                    this.contactsList.Add(newContact);
                    this.dbManager.InsertNewContact(newContact);
                }
            }
        }

        private int GetNewId()
        {
            return this.contactsList.Count > 0 ?
                //Atrod lielāko Id sarakstā un atgriež par 1 lielāku vai 1, ja saraksts ir tukšs
                (this.contactsList.Max(c => c.Id) + 1) : 1;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Contact selectedContact = ContactsListBox.SelectedItem as Contact;
            if (selectedContact != null)
            {
                this.EditExistingContact(selectedContact);
            }
            //Nav izvēlēts neviens kontakts
            else
            {
                MessageBox.Show("Izvēlies kontaktu, kuru vēlies rediģēt, uzklikšķinot sarakstā!", "Izvēlies kontaktu!", MessageBoxButtons.OK);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var selected = (Contact)this.ContactsListBox.SelectedItem;
            if (selected != null)
            {
                DialogResult dialogResult = MessageBox.Show("Vai tiešām dzēst šo kontaktu?", "Uzmanību!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.contactsList.Remove(selected);
                    this.dbManager.DeleteContact(selected.Id);
                }
            }
            //Nav izvēlēts neviens kontakts
            else
            {
                MessageBox.Show("Izvēlies kontaktu, kuru vēlies dzēst, uzklikšķinot sarakstā!", "Izvēlies kontaktu!", MessageBoxButtons.OK);
            }
        }

        private void ContactsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selected = this.ContactsListBox.SelectedItem as Contact;
            if (selected != null)
            {
                this.EditExistingContact(selected);
            }
        }

        private void EditExistingContact(Contact selectedContact)
        {
            using (var EditContactForm = new AddEditForm(selectedContact))
            {
                EditContactForm.ShowDialog();

                if (EditContactForm.SaveData)
                {
                    var editedContact = new Contact()
                    {
                        Id = selectedContact.Id,
                        FirstName = EditContactForm.FirstName,
                        LastName = EditContactForm.LastName,
                        Birthday = EditContactForm.Birthday,
                        PhonePrefix = EditContactForm.PhonePrefix,
                        PhoneNumber = EditContactForm.PhoneNumber,
                        Email = EditContactForm.Email,
                        Notes = EditContactForm.Notes
                    };
                    var index = this.ContactsListBox.SelectedIndex;
                    this.contactsList.RemoveAt(index);
                    this.contactsList.Insert(index, editedContact);
                    this.dbManager.EditExistingContact(editedContact);
                }
            }
        }

        private void ContactsListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                // Get the ListBox object
                var listBox = (ListBox)sender;

                // Get the font for the item (bold and larger)
                var font = new Font(listBox.Font.FontFamily, 16, FontStyle.Bold);

                // Get the brush for the item (black color)
                var brush = Brushes.Black;

                // Check if the contact's birthday falls within the current month
                DateTime currentDate = DateTime.Now;
                DateTime birthday = this.contactsList[e.Index].Birthday ?? DateTime.MaxValue; // Get the birthday, or MaxValue if it's null
                if (birthday.Month == currentDate.Month && birthday != DateTime.MaxValue)
                {
                    // If birthday is today, set background color to pink
                    if (birthday.Day == currentDate.Day)
                    {
                        e.Graphics.FillRectangle(Brushes.LightPink, e.Bounds);
                    }
                    else
                    {
                        // If birthday is in this month but not today, set background color to green
                        e.Graphics.FillRectangle(Brushes.LightGreen, e.Bounds);
                    }
                }
                else
                {
                    // Otherwise, use default background color
                    e.DrawBackground();
                }

                e.Graphics.DrawString(this.contactsList[e.Index].DisplayName, font, brush, e.Bounds.X, e.Bounds.Y);
                e.DrawFocusRectangle();
            }
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            this.dbManager.CloseConnection();
            using (var importForm = new ImportSelectionForm(this.contactsList.Any()))
            {
                importForm.ShowDialog();
            }
            this.dbManager.CreateConnection();
            this.contactsList = new BindingList<Contact>(this.dbManager.GetAllContacts());
            this.ContactsListBox.DataSource = this.contactsList;
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            this.dbManager.CloseConnection();
            using(var exportForm = new ExportSelectionForm())
            {
                exportForm.ShowDialog();
            }
            this.dbManager.CreateConnection();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dbManager.CloseConnection();
        }
    }
}
