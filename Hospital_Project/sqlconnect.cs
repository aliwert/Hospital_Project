﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Hospital_Project
{
    internal class sqlconnect
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan=new SqlConnection("Data Source=DESKTOP-LRMEISB\\SQLEXPRESS;Initial Catalog=HospitalProject;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
