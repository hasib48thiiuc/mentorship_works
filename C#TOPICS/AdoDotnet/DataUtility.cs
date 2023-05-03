using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDotnet
{
    public  class DataUtility
    {
        private string _connectionstring;

        public DataUtility( string connectionstring)
        {
            _connectionstring = connectionstring;

        }

        private SqlCommand CreateCommand(string sql )
        {

            SqlConnection connection = new SqlConnection(_connectionstring);

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = sql;

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            return command;
        }
        public void AddData(string sql)
        {

            using var command=CreateCommand(sql);

                command.ExecuteNonQuery();

        }

        public List<Dictionary<string,object>> GetData(string query)
        {
            using var command = CreateCommand(query);

            List<Dictionary<string,object>> values= new List<Dictionary<string,object>>();

            using  SqlDataReader  reader=command.ExecuteReader();

            while (reader.Read())
            {
                Dictionary<string, object> row =
                    new Dictionary<string, object>();

                for (int i = 0; i < reader.FieldCount; i++)
                {

                    row.Add(reader.GetName(i), reader.GetValue(i));


                }
                values.Add(row);
            }
            return values;
        }
    }
}
