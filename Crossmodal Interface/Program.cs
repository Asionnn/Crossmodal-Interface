using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Configuration;

namespace Crossmodal_Interface
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
			string provider = ConfigurationManager.AppSettings["provider"];
			string connectionString = ConfigurationManager.AppSettings["connectionString"];
			DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

			string cmd = "";
			using (DbConnection connection =
				factory.CreateConnection())
			{
				if (connection == null)
				{
					Console.WriteLine("Connection Error");
					Console.ReadLine();
					return;
				}

				connection.ConnectionString = connectionString;

				connection.Open();
				DbCommand command = factory.CreateCommand();
				
				if (command == null)
				{
					Console.WriteLine("Command Error");
					Console.ReadLine();
					return;
				}

				command.Connection = connection;

				command.CommandText = "INSERT INTO Users ([FirstName], [LastName], [Visual], [Auditory], [Tactile]) VALUES ('Han', 'Wang', 1, 1, 1)";

				command.ExecuteNonQuery();

			}
            */
			Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
            
        }
	
	}
}
