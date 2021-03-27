using MySql.Data.MySqlClient;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        public static bool VerifyPassword(string enteredPassword, string storedHash, string storedSalt)
        {
            var saltBytes = Convert.FromBase64String(storedSalt);
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(enteredPassword, saltBytes, 1000);
            return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(80)) == storedHash;
        }

        static void Main(string[] args)
        {
            string cs = @"Server=yvu4xahse0smimsc.chr7pe7iynqr.eu-west-1.rds.amazonaws.com;
                          Port=3306;
                          Database=llbqqdkmx4mkoa68;
                          Uid=ad7cvwajb9snjlqw;
                          Pwd=kxmx6bu9a82k4mbi;";
            string userDB_login = "_";
            string salt = "_";
            string hash = "_";
            var connection = new MySqlConnection(cs);

            string check_auth = $"SELECT user_login, password_hash, password_salt FROM users WHERE user_login = \"gugulenok\"";

            var cmd = new MySqlCommand(check_auth, connection); // executes query on database

            connection.Open();
            MySqlDataReader rdr = cmd.ExecuteReader(); // getting all rows from the users table

            while (rdr.Read())
            {
                userDB_login = rdr.GetString(0); // writing user_name from database to string variable
                hash = rdr.GetString(1); // writing password_hash from database to string variable
                salt = rdr.GetString(2); // writing password_salt from database to string variable
            }

            bool isPasswordMatched = VerifyPassword("sdfgsdfgsdfg", hash, salt);

            Console.WriteLine($"{userDB_login} : {hash} : {salt}");
            Console.WriteLine($"{isPasswordMatched}");
            connection.Close();
            Console.ReadLine();

        }
    }
}
