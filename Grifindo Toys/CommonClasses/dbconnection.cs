﻿using System.Data.SqlClient;

namespace Grifindo_Toys.CommonClasses
{
    internal class dbconnection
    {
        public SqlConnection mycon = new SqlConnection("Data Source=MMSALMANFARIS;Initial Catalog=Grifindo_Toys;Integrated Security=True;Encrypt=False");
    }
}



