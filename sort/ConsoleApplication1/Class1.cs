using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Class1
    {
        public void execprocedure(object strsql)
        {
            sqlhelper obj = new sqlhelper();
            obj.ExecuteNonQuery(strsql.ToString());
        }
    }
}
