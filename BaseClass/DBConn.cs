using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManagementSystem.BaseClass
{
    internal class DBConn
    {
        public static SqlConnection CyCon()
        {
            return new SqlConnection("server=(local);database=FoodManagementDB;uid=sa;pwd=123456");
        }
    }
}
