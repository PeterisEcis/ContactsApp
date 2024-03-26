using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ContactsApp
{
    public class DatabaseManager
    {
        private SQLiteConnection _connection;

        public DatabaseManager()
        {
            this.CreateConnection();
            this.CreateContactsTable();
        }

        private bool CheckConnection()
        {
            if (this._connection == null || this._connection.State != System.Data.ConnectionState.Open)
            {
                this.CreateConnection();
            }
            return this._connection.State == System.Data.ConnectionState.Open;
        }
        public bool CreateConnection()
        {
            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection($"Data Source={Constants.DatabaseName}; Version = 3; New = True; Compress = True; ");
           // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
                catch (Exception ex)
            {
                 return false;
            }
            this._connection = sqlite_conn;
            return true;
        }

        public void CloseConnection()
        {
            if (this._connection != null && this._connection.State != System.Data.ConnectionState.Closed)
            {
                this._connection.Close();
                this._connection.Dispose();
                GC.Collect();
            }
        }

        public void CreateContactsTable()
        {
            if (this.CheckConnection())
            {
                SQLiteCommand sqlite_cmd;
                string createSql = $@"CREATE TABLE IF NOT EXISTS {Constants.ContactsTable} (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        FirstName TEXT,
                        LastName TEXT,
                        Birthday DATETIME,
                        PhonePrefix TEXT,
                        PhoneNumber TEXT,
                        Email TEXT,
                        Notes TEXT
                    )";
                sqlite_cmd = this._connection.CreateCommand();
                sqlite_cmd.CommandText = createSql;
                sqlite_cmd.ExecuteNonQuery();
            }
        }

        public void InsertNewContact(Contact contact)
        {
            if (this.CheckConnection())
            {
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = this._connection.CreateCommand();
                sqlite_cmd.CommandText = $"INSERT INTO {Constants.ContactsTable} " +
                    "(Id, FirstName, LastName, Birthday, PhonePrefix, PhoneNumber, Email, Notes) " +
                    "VALUES (@Id, @FirstName, @LastName, @Birthday, @PhonePrefix, @PhoneNumber, @Email, @Notes)";

                sqlite_cmd.Parameters.AddWithValue("@Id", contact.Id);
                sqlite_cmd.Parameters.AddWithValue("@FirstName", contact.FirstName);
                sqlite_cmd.Parameters.AddWithValue("@LastName", contact.LastName);
                sqlite_cmd.Parameters.AddWithValue("@Birthday", contact.Birthday);
                sqlite_cmd.Parameters.AddWithValue("@PhonePrefix", contact.PhonePrefix);
                sqlite_cmd.Parameters.AddWithValue("@PhoneNumber", contact.PhoneNumber);
                sqlite_cmd.Parameters.AddWithValue("@Email", contact.Email);
                sqlite_cmd.Parameters.AddWithValue("@Notes", contact.Notes);

                sqlite_cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Nevar izveidot savienojumu ar datubāzi! \nKontakts nav saglabāts!", "Kļūda!", MessageBoxButtons.OK);
            }
        }

        public void EditExistingContact(Contact contact)
        {
            if (this.CheckConnection())
            {
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = this._connection.CreateCommand();
                sqlite_cmd.CommandText = $"UPDATE {Constants.ContactsTable} " +
                    "SET FirstName = @FirstName, LastName = @LastName, Birthday = @Birthday, " +
                    "PhonePrefix = @PhonePrefix, PhoneNumber = @PhoneNumber, Email = @Email, " +
                    "Notes = @Notes " +
                    "WHERE Id = @Id";

                sqlite_cmd.Parameters.AddWithValue("@Id", contact.Id);
                sqlite_cmd.Parameters.AddWithValue("@FirstName", contact.FirstName);
                sqlite_cmd.Parameters.AddWithValue("@LastName", contact.LastName);
                sqlite_cmd.Parameters.AddWithValue("@Birthday", contact.Birthday);
                sqlite_cmd.Parameters.AddWithValue("@PhonePrefix", contact.PhonePrefix);
                sqlite_cmd.Parameters.AddWithValue("@PhoneNumber", contact.PhoneNumber);
                sqlite_cmd.Parameters.AddWithValue("@Email", contact.Email);
                sqlite_cmd.Parameters.AddWithValue("@Notes", contact.Notes);

                sqlite_cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Nevar izveidot savienojumu ar datubāzi! \nKontakts nav saglabāts!", "Kļūda!", MessageBoxButtons.OK);
            }
        }

        public void DeleteContact(int id)
        {
            if (this.CheckConnection())
            {
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = this._connection.CreateCommand();
                sqlite_cmd.CommandText = $"DELETE FROM {Constants.ContactsTable} WHERE Id = @IdToDelete";
                sqlite_cmd.Parameters.AddWithValue("@IdToDelete", id);
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Nevar izveidot savienojumu ar datubāzi! \nKontakts nav saglabāts!", "Kļūda!", MessageBoxButtons.OK);
            }
        }

        public List<Contact> GetAllContacts()
        {
            var contacts = new List<Contact>();
            if (this.CheckConnection())
            {
                SQLiteDataReader sqlite_datareader;
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = this._connection.CreateCommand();
                sqlite_cmd.CommandText = $"SELECT * FROM {Constants.ContactsTable}";

                sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    var idxId = sqlite_datareader.GetOrdinal("Id");
                    var idxName = sqlite_datareader.GetOrdinal("FirstName");
                    var idxLastName = sqlite_datareader.GetOrdinal("LastName");
                    var idxBirthday = sqlite_datareader.GetOrdinal("Birthday");
                    var idxPrefix = sqlite_datareader.GetOrdinal("PhonePrefix");
                    var idxPhone = sqlite_datareader.GetOrdinal("PhoneNumber");
                    var idxEmail = sqlite_datareader.GetOrdinal("Email");
                    var idxNotes = sqlite_datareader.GetOrdinal("Notes");

                    Contact contact = new Contact()
                    {
                        Id = sqlite_datareader.GetInt32(idxId),
                        FirstName = sqlite_datareader.GetString(idxName),
                        LastName = sqlite_datareader.GetString(idxLastName),
                        Birthday = GetNullableDateTime(sqlite_datareader[idxBirthday]),
                        PhonePrefix = sqlite_datareader.GetString(idxPrefix),
                        PhoneNumber = sqlite_datareader.GetString(idxPhone),
                        Email = sqlite_datareader.GetString(idxEmail),
                        Notes = sqlite_datareader.GetString(idxNotes)
                    };
                    contacts.Add(contact);
                }
            }
            return contacts;
        }

        //https://stackoverflow.com/a/47756534
        private static DateTime? GetNullableDateTime(object o)
        {
            return (o == DBNull.Value || o == null) ? (DateTime?)null : Convert.ToDateTime(o);
        }
    }
}
