using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace EAD_Project.DAL
{
    internal class DBHelper : IDisposable
    {
       // data source=375b2c8c-b6ff-48af-8185-a7aa00d72b05.sqlserver.sequelizer.com;initial catalog=db375b2c8cb6ff48af8185a7aa00d72b05;user id=dtffwtqynzwfmlmr;password=kYPqWhncE2V87WsUE7sFzXgryAEshETynTPWG8KaGiNb6NaRMhPEi7puRxZuJ44a;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
        String _connStr = @"Data Source=DESKTOP-AQ23G94\SQLEXPRESS;Initial Catalog=EShopper;Integrated Security=True";
       SqlConnection _conn = null;
            public DBHelper()
            {
                _conn = new SqlConnection(_connStr);
                _conn.Open();
            }

            public int ExecuteQuery(String sqlQuery)
            {
                SqlCommand command = new SqlCommand(sqlQuery, _conn);
                var count = command.ExecuteNonQuery();
                return count;
            }
            public Object ExecuteScalar(String sqlQuery)
            {
                SqlCommand command = new SqlCommand(sqlQuery, _conn);
                return command.ExecuteScalar();
            }

            public SqlDataReader ExecuteReader(String sqlQuery)
            {
                SqlCommand command = new SqlCommand(sqlQuery, _conn);
                return command.ExecuteReader();
            }

            public void Dispose()
            {
                if (_conn != null && _conn.State == System.Data.ConnectionState.Open)
                    _conn.Close();
            }
        }
    }