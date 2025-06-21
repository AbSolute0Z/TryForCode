using Npgsql;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pol
{
    class Database
    {
        private readonly string _connectionString;
        
        public Database(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataTable ExecuteQuery(string query, NpgsqlParameter[] parameters = null)
        {
            using(var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using(var command = new NpgsqlCommand(query, connection))
                {
                    if(parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    using(var dataadapter = new NpgsqlDataAdapter(command))
                    {
                        var dataTable = new DataTable();
                        dataadapter.Fill(dataTable);
                        //MessageBox.Show(Convert.ToString(dataTable.Rows.Count));
                        return dataTable;
                    }
                }
            }
        }

        public int ExecuteNonQuery(string query, NpgsqlParameter[] parameters = null)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    return command.ExecuteNonQuery();
                }
            }
        }

        public object ExecuteScalar(string query, NpgsqlParameter[] parameters = null)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    return command.ExecuteScalar();
                }
            }
        }

    }
}
