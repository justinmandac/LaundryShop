using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace LaundryShop.mySQL_Library
{
    class ConnectToMySQL
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //initialize database connection
        //by default server variable = localhost 
        public void Initialize(string server, string database, string uid, string password)
        {
            this.server = server;
            this.database = database;
            this.uid = uid;
            this.password = password;

            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                //have yet to populate error codes
                /*
                switch (e.Number)
                {
                    case 0: MessageBox.Show("Cannot connect to server.");
                        break;
                    case 1045: MessageBox.Show("Invalid username/password.");
                        break;
                }
                */
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        //INSERT STATEMENT
        //accepts query variable which contains the desired query
        public void Insert(string query)
        {
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
            else
            {
                MessageBox.Show("Error in Insert.");
            }
        }

        //UPDATE STATEMENT
        public void Update(string query)
        {
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
            else
            {
                MessageBox.Show("Error in Update.");
            }
        }

        //DELETE STATEMENT
        public void Delete(string query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
            else
            {
                MessageBox.Show("Error in Delete.");
            }
        }

        //the past three methods may seem redundant. can be reduced to a single "Query(string query)" method

        //have yet to implement select statement and figure a way to implement prepared statements
    }
}
