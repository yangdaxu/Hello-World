using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApplication1
{
    public class sqlhelper
    {
        public void ExecuteNonQuery(string strSql)
        {
            using (SqlConnection conn = new SqlConnection("data source=yangdaxu;initial catalog=test;user id=sa;password=123;"))
            {
                SqlCommand sc = new SqlCommand(strSql, conn);
                conn.Open();
                sc.ExecuteNonQuery();
            }
        }
    }
}
