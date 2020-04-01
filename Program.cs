using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CS291_Project
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{

			using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;" +
																	"AttachDbFilename=|DataDirectory|Database1.mdf;" +
																	"Integrated Security=True"))
			{
				conn.Open();
				SqlCommand comm = new SqlCommand();
				comm.Connection = conn;
				comm.CommandText = "select count (*) from branch";
				int userCount = Convert.ToInt32(comm.ExecuteScalar());

				if (userCount == 0)
				{
					comm.CommandText = "insert into branch (name) values (@name)";
					comm.Parameters.AddWithValue("@name", "Xaviers Branch");
					comm.ExecuteNonQuery();
				}

				conn.Close();

			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new LoginForm());
		}
	}
}
