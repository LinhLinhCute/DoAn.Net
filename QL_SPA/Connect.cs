using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_SPA
{
    internal class Connect
    {
        public SqlConnection connect;
        public Connect()
        {
            connect = new SqlConnection("Data Source =ADMIN\\SQLEXPRESS; Initial Catalog= QL_Spa; Integrated Security = true");
        }
        public Connect(string strcn)
        {
            connect = new SqlConnection(strcn);
        }


    }
    
}
