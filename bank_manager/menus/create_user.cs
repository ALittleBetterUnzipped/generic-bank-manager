using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.InteropServices;
using System.Text;
using bank_manager.items;
using Microsoft.Data.Sqlite;

namespace bank_manager.menus
{
    internal class create_user
    {

        public static User CreateUserMenu()
        {
            Console.Clear();

            Console.WriteLine("Creating User");

            Console.WriteLine("\r\nFirst Name: ");
            string firstName = Console.ReadLine().ToUpper();

            Console.WriteLine("\r\nLast Name: ");
            string lastName = Console.ReadLine().ToLower();

            Console.WriteLine("\r\nEmail: ");
            string email = Console.ReadLine();

            string userID = generateUserID(firstName, lastName);
            User user = new User(userID, firstName, lastName, email);

            Console.WriteLine(userID, firstName, lastName, email);

            var sql = "INSERT INTO users (userID, firstName, lastName, userEmail)" +
                "VALUES (@userID, @firstName, @lastName, @userEmail";

            using var connection = new SqliteConnection(@"Data Source=C:\Users\Dawid\source\repos\bank_manager\bank_manager\data\users.db");
            connection.Open();
            using var command = new SqliteCommand(sql, connection);

            command.Parameters.AddWithValue("@userID", userID);
            command.Parameters.AddWithValue("@firstName", firstName);
            command.Parameters.AddWithValue("@lastName", lastName);
            command.Parameters.AddWithValue("@userEmail", email);

            var rowInserted = command.ExecuteNonQuery();

            connection.Close();

            return user;

        }

        private static string generateUserID(string firstName, string lastName)
        {
            Random rnd = new Random();
            int idSuffix = rnd.Next(1000, 9999);

            char f = firstName[0];
            char l = lastName[0];

            Console.WriteLine($"{f} {l}");

            string strSuffix = idSuffix.ToString();
            string userID = f + l + strSuffix;

            return userID;
        }
    }
}
