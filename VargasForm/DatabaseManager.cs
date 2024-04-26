﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VargasForm
{

    internal class DatabaseManager
    {
        public MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public DatabaseManager()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "mike2";
            uid = "root";
            password = "Vmikel_2";
            string connectionString;
            connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                // Handle exception
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                // Handle exception
                return false;
            }
        }
    }
}