using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace arduino
{
    class DbAdaptor
    {
        String server = "ftp.anvr.ro";
        String database = "loredana";
        String uid = "loredana";
        String password = "loredana123";
        MySqlConnection connection;
        String connectionString;
        
        public DbAdaptor() {
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void executeQuery(String query)
        {
            try
            {
                OpenConnection();
                MySqlCommand command;
                command = new MySqlCommand(query, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    Console.Write("Done!");
                }
                else
                {
                    Console.Write("Not Executed!");
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void InsertProfiles(List<DataProfile> list)
        {
            if (list[0].Name.Length > 1)
            {
                // Folosim siruri prelucrate pentru a preveni erori și pentru securitatea codului SQL
                try
                {
                    OpenConnection();
                    MySqlCommand command;
                    // Nu încadrăm @id în apostrof!
                    command = new MySqlCommand("INSERT INTO profiles(name, delay, start, end) VALUES(@tname, @tdelay, @tstart, @tend);", connection);
                    // Atribui la @id valoarea ID care va fi înlocuită '<nr>'
                    command.Parameters.AddWithValue("@tname", list[0].Name);
                    command.Parameters.AddWithValue("@tdelay", list[0].Delay);
                    command.Parameters.AddWithValue("@tstart", list[0].HourStart);
                    command.Parameters.AddWithValue("@tend", list[0].HourEnd);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Done!");
                    }
                    else
                    {
                        MessageBox.Show("Not Executed!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    CloseConnection();
                }
            } /// endif ID != 0
            else
                MessageBox.Show("Numele profilului trebuie să aibă cel puțin 2 caractere!", "Nume prea scurt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            // METODĂ DE CURĂȚARE
        }

        public void InsertUsers(List<DataUser> list)
        {
            try
            {
                OpenConnection();
                MySqlCommand command;
                command = new MySqlCommand("INSERT INTO arduino_db (name, pass, phone) VALUES (@name, @pass, @phone);", connection);
                command.Parameters.AddWithValue("@name", list[0].Name);
                command.Parameters.AddWithValue("@pass", list[0].Pass);
                command.Parameters.AddWithValue("@phone", list[0].Phone);
                if (command.ExecuteNonQuery() == 1)
                {
                    //Console.Write("Done!");
                    MessageBox.Show(
                        "Succes!", 
                        "Adăugare utilizator", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                }
                else
                {
                    Console.Write("Not Executed!");
                    MessageBox.Show(
                        "Eșec!!",
                        "Adăugare utilizator",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk
                        );
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                MessageBox.Show(
                        "Eroare la adăugare \n" + ex.Message,
                        "Adăugare utilizator",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
            }
            finally
            {
                CloseConnection();
            }
        }

        public void UpdateProfiles(List<DataProfile> list)
        {
            int id = list[0].Id;
            if (id > 0)
            {
                // Folosim siruri prelucrate pentru a preveni erori și pentru securitatea codului SQL
                try
                {
                    OpenConnection();
                    MySqlCommand command;
                    // Nu încadrăm @id în apostrof!
                    command = new MySqlCommand("UPDATE profiles SET name = @tname , delay = @tdelay , start = @tstart , end = @tend WHERE id = @id ;", connection);
                    // Atribui la @id valoarea ID care va fi înlocuită '<nr>'
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@tname", list[0].Name);
                    command.Parameters.AddWithValue("@tdelay", list[0].Delay);
                    command.Parameters.AddWithValue("@tstart", list[0].HourStart);
                    command.Parameters.AddWithValue("@tend", list[0].HourEnd);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Done!");
                    }
                    else
                    {
                        MessageBox.Show("Not Executed!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    CloseConnection();
                }
            } /// endif ID != 0
            else
                MessageBox.Show("Câmpurile sunt goale! \nSelectați un rând dând click pe coloana dinaintea cifrei!", "Nu ați selectat vreun rând", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        public void UpdateUsers(List<DataUser> list)
        {
            int id = list[0].Id;
            if (id > 0)
            {
                try
                {
                    OpenConnection();
                    MySqlCommand command;
                    command = new MySqlCommand("UPDATE arduino_db SET name = @name , pass = @pass , phone = @phone WHERE id = @id ;", connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@name", list[0].Name);
                    command.Parameters.AddWithValue("@pass", list[0].Pass);
                    command.Parameters.AddWithValue("@phone", list[0].Phone);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        Console.Write("Done!");
                        MessageBox.Show(
                        "Succes!",
                        "Adăugare utilizator",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                    }
                    else
                    {
                        Console.Write("Not Executed!");
                        MessageBox.Show(
                        "Eșec!!",
                        "Adăugare utilizator",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk
                        );
                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }
                finally
                {
                    CloseConnection();
                }
            } /// endif ID != 0
            else
                Console.Write("Câmpurile sunt goale! \nSelectați un rând dând click pe coloana dinaintea cifrei!");
        }

        public void DeleteProfiles(int id = 0)
        {
            if (id != 0)
            {
                // Folosim siruri prelucrate pentru a preveni erori și pentru securitatea codului SQL
                try
                {
                    OpenConnection();
                    MySqlCommand command;
                    // Nu încadrăm @id în apostrof!
                    command = new MySqlCommand("DELETE FROM profiles WHERE id = @id ;", connection);
                    // Atribui la @id valoarea ID care va fi înlocuită '<nr>'
                    command.Parameters.AddWithValue("@id", id);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Done!");
                    }
                    else
                    {
                        MessageBox.Show("Not Executed!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    CloseConnection();
                }
            } /// endif ID != 0
            else
                MessageBox.Show("Câmpurile sunt goale! \nSelectați un rând dând click pe coloana dinaintea cifrei!", "Nu ați selectat vreun rând", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void DeleteUsers(int id = 0)
        {
            if(id > 0)
            {
                try
                {
                    OpenConnection();
                    MySqlCommand command;
                    command = new MySqlCommand("DELETE FROM arduino_db WHERE id = @id ;", connection);
                    command.Parameters.AddWithValue("@id", id);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        Console.Write("Done");
                    }
                    else
                    {
                    Console.Write("Not Executed!");
                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }
                finally
                {
                    CloseConnection();
                }
            } /// endif ID != 0
            else
                Console.Write("Câmpurile sunt goale! \nSelectați un rând dând click pe coloana dinaintea cifrei!");
        }

        public String SyncUsers()
        {
            string selectQuery = "select * from arduino_db";
            DataUser dataUser = new DataUser();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            List<DataUser> usersTable = new List<DataUser>();
            foreach (DataRow row in table.Rows)
            {
                usersTable.Add(new DataUser() { Id = Convert.ToInt16(row["id"]), Name = row["name"].ToString(), Pass = row["pass"].ToString(), Phone = row["phone"].ToString() });
            }
            return ArduSerial.SerialJoin(usersTable);
            //Console.Write(ArduSerial.SerialJoin(usersTable));
        }


        public DataTable PopulateDGVUsers()
        {
            string selectQuery = "select * from arduino_db ";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            return table;
        }

        public DataTable PopulateDGVProfiles()
        {
            string selectQuery = "select * from profiles ";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            return table;
        }


    }
}
