using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grifindo_Toys.CommonClasses
{
    internal class dbconnection
    {
        public SqlConnection mycon = new SqlConnection("Data Source=SALMAN_FARIS\\SQLEXPRESS;Initial Catalog=Grifindo_Toys;Integrated Security=True;Encrypt=False");
    }
}
