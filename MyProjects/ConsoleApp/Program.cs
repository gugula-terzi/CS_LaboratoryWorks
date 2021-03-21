using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
			var cs = "Server=ec2-34-252-251-16.eu-west-1.compute.amazonaws.com;Port=5432;Database=d3t3lvjvav8bdv;User Id=johafurigtkxbk;Password=f1d60e9f18c1f99d34f6d3d6d52701ed4bd7fdf8c6b77e45fe31b77045be84eb;SSL Mode=Require;Trust Server Certificate=True";

			var con = new NpgsqlConnection(cs);
			con.Open();

			string sql = "SELECT * FROM users";
			string check_auth = $"SELECT user_name, user_password FROM users WHERE user_name = 'gugulenok' AND user_password = 'testpass'";
			var cmd = new NpgsqlCommand(check_auth, con);

			NpgsqlDataReader rdr = cmd.ExecuteReader();

			while (rdr.Read())
			{
				Console.WriteLine("{0} {1}", rdr.GetString(0), rdr.GetString(1));
			}
			Console.ReadLine();
		}
    }
}
