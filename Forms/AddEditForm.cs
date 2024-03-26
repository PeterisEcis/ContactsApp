using System;
using System.Windows.Forms;

namespace ContactsApp
{
    public partial class AddEditForm : Form
    {
        #region Properties
        public string FirstName
        {
            get { return NameBox.Text; }
        }

        public string LastName
        {
            get { return LastNameBox.Text; }
        }

        public DateTime? Birthday
        {
            get
            {
                if (this.IsBirthdayPickerActive.Checked)
                {
                    return this.BirthdayPicker.Value;
                }
                else
                {
                    return null;
                }
            }
        }

        public string PhonePrefix
        {
            get { return PrefixBox.Text; }
        }

        public string PhoneNumber
        {
            get { return PhoneBox.Text; }
        }

        public string Email
        {
            get { return EmailBox.Text; }
        }

        public string Notes
        {
            get { return NotesBox.Text; }
        }

        private bool _saveData = false;
        public bool SaveData
        {
            get { return this._saveData; }
            private set { this._saveData = value; }
        }

        private Contact _selectedContact { get; set; }
        #endregion

        #region Contstructors
        public AddEditForm()
        {
            InitializeComponent();
            this.Text = "Pievienot jaunu kontaktu";
            this.PrefixBox.Text = Constants.LVPhonePrefix;
        }

        public AddEditForm(Contact selectedContact)
        {
            InitializeComponent();
            this.Text = "Rediģēt kontaktu";
            this._selectedContact = selectedContact;
            this.NameBox.Text = selectedContact.FirstName;
            if(selectedContact.Birthday != null)
            {
                this.IsBirthdayPickerActive.Checked = true;
                this.BirthdayPicker.Value = (DateTime) selectedContact.Birthday;
            }
            this.LastNameBox.Text = selectedContact.LastName;
            this.PrefixBox.Text = string.IsNullOrWhiteSpace(selectedContact.PhonePrefix) ? Constants.LVPhonePrefix : selectedContact.PhonePrefix;
            this.PhoneBox.Text = selectedContact.PhoneNumber;
            this.EmailBox.Text = selectedContact.Email;
            this.NotesBox.Text = selectedContact.Notes;
        }
        #endregion

        #region Buttons
        private void SaveButton_Click(object sender, EventArgs e)
        {
            var validationResult = this.Validate();
            if (string.IsNullOrEmpty(validationResult))
            {
                this.SaveData = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show(validationResult, "Kļūda", MessageBoxButtons.OK);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var CanCloseForm = CanCloseWithoutSaving(); //Ja ir nesaglabātas izmaiņas, nevar aizvērt formu bez akcepta
            if (CanCloseForm)
            {
                this.Close();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Dati nav saglabāti. Vai tiešām vēlies iziet?", "Dati nav saglabāti!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
        #endregion

        private string Validate()
        {
            var validationResult = string.Empty;
            if(string.IsNullOrWhiteSpace(this.FirstName) && string.IsNullOrWhiteSpace(this.LastName))
            {
                validationResult += "Nav norādīts vārds un uzvārds. ";
            }
            if(this.Birthday != null)
            {
                if(this.Birthday > DateTime.Now)
                {
                    validationResult += "Norādītā dzimšanas diena ir nākotnē. ";
                }
            }
            return validationResult;
        }

        private bool CanCloseWithoutSaving()
        {
            bool canCloseForm;

            //Salīdzina ar iepriekšējām vērtībām ja tiek rediģēts kontakts
            if(this._selectedContact != null)
            {
                canCloseForm = FirstName.Equals(_selectedContact.FirstName) &&
                               LastName.Equals(_selectedContact.LastName) &&
                               Birthday.Equals(_selectedContact.Birthday) &&
                               PhonePrefix.Equals(_selectedContact.PhonePrefix) &&
                               PhoneNumber.Equals(_selectedContact.PhoneNumber) &&
                               Email.Equals(_selectedContact.Email) &&
                               Notes.Equals(_selectedContact.Notes);
            }
            //Pārbauda vai kādā textboxā ir vērtības ja teikt veidots jauns kontakts
            else
            {
                canCloseForm = string.IsNullOrWhiteSpace(FirstName) &&
                               string.IsNullOrWhiteSpace(LastName) &&
                               !IsBirthdayPickerActive.Checked &&
                               string.IsNullOrWhiteSpace(PhonePrefix) &&
                               string.IsNullOrWhiteSpace(PhoneNumber) &&
                               string.IsNullOrWhiteSpace(Email) &&
                               string.IsNullOrWhiteSpace(Notes);
            }

            return canCloseForm;
        }

        #region Numeric TexBox

        //Atļauj ierakstīt tikai ciparus telefona prefix un numura laukos
        //Risinājums ņemts no 
        //https://ourcodeworld.com/articles/read/507/how-to-allow-only-numbers-inside-a-textbox-in-winforms-c-sharp
        private void PrefixBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PhoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        private void IsBirthdayPickerActive_CheckStateChanged(object sender, EventArgs e)
        {
            this.BirthdayPicker.Enabled = this.IsBirthdayPickerActive.Checked;
        }
    }
}
