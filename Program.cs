using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pol
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string host = "localhost";// Настройки подклюцения к БД
            string port = "5432";
            string database = "master-pol";
            string username = "postgres";
            string password = "1234";
            string connectionString = $"Host={host};Port={port};Database={database};Username={username};Password={password}";
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open(); //открываем подключение к БД
                }
                var db = new Database(connectionString);
                var partnerManager = new PartnerManager(db);
                Application.Run(new PartnerForm(partnerManager));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
