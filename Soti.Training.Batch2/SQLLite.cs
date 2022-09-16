using System;
using System.IO;
using Microsoft.Data.Sqlite;
using Soti.Training.Batch2.Models;
using System.Configuration;

namespace Soti.Training.Batch2
{
    class SQLLiteDemo
    {
        public static void ShowDemo()
        {
            // root@127.0.0.1:3306
            // jdbc:mysql://127.0.0.1:3306/?user=root
            //
            using (var connection = getConnection())
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                @"
                    CREATE TABLE user (
                        id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                        name TEXT NOT NULL
                    );
                    INSERT INTO user
                    VALUES (1, 'Brice'),
                           (2, 'Alexander'),
                           (3, 'Nate');
                ";
                command.ExecuteNonQuery();

                Console.Write("Name: ");
                var name = Console.ReadLine();

                #region snippet_Parameter
                command.CommandText =
                @"
                    INSERT INTO user (name)
                    VALUES ($name)
                ";
                command.Parameters.AddWithValue("$name", name);
                #endregion
                command.ExecuteNonQuery();

                command.CommandText =
                @"
                    SELECT last_insert_rowid()
                ";
                var newId = (long)command.ExecuteScalar();

                Console.WriteLine($"Your new user ID is {newId}.");
            }

            // Open  A Resource // file , dbconnection, network socket for a post 
            // Perfor a Activity using the Resource
            // Close That Connection / Resource Handle

            Console.Write("User ID: ");
            var id = int.Parse(Console.ReadLine());

            #region snippet_HelloWorld
            using (var connection = getConnection())
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                @"
                    SELECT name
                    FROM user
                    WHERE id = $id
                ";
                command.Parameters.AddWithValue("$id", id);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var name = reader.GetString(0);

                        Console.WriteLine($"Hello, {name}!");
                    }
                }
            }
            #endregion

            // Clean up
            //File.Delete("hello.db");
        }

        public static MySql.Data.MySqlClient.MySqlConnection getConnection() {
            //MySql.Data.MySqlClient.MySqlBaseConnectionStringBuilder 
            MySql.Data.MySqlClient.MySqlConnection conn;
            // Server=myServerAddress; Port=1234; Database=myDataBase; Uid=myUsername; Pwd=myPassword;
            //string myConnectionString = "server=127.0.0.1;port=3306;database=world;uid=root;" + "pwd=SurLog12#";
            string myConnectionString = "Getif from APP.config";



            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                return conn;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static void ShowConnectionStrings() {
            ConnectionStringSettingsCollection settings =
                    ConfigurationManager.ConnectionStrings;

              if (settings != null)
                {
                    foreach (ConnectionStringSettings cs in settings)
                    {
                        Console.WriteLine(cs.Name);
                        Console.WriteLine(cs.ProviderName);
                        Console.WriteLine(cs.ConnectionString);
                    }
                }
            Console.WriteLine("The Appsettings are for the environment");
            foreach (var item in ConfigurationManager.AppSettings)
            {
                Console.WriteLine(item);
            }

            }

        

        }
    }

