using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Medicine_312
{
   class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=KSAN;Initial Catalog=Medicine_312;Integrated Security=True");


        public void openConnection()
        {
            if(sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();   
            }
        }
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public SqlConnection qetConnetion()
        {
            return sqlConnection;
        }



    }

}


