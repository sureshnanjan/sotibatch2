using System;
using System.IO;
using Microsoft.Data.Sqlite;
using Soti.Training.Batch2.Models;
using System.Configuration;



namespace Soti.Training.Batch2
{
    public class SQLLiteDemo
    {

        public static void ShowConnectionStrings()
        {
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