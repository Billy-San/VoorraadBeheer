using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoorraadBeheer
{
    internal class functies
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string ConString;

        public functies()
        { 
            ConString= @"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\Documents\\MeubleMalin.mdf;Integrated Security=True;Connect Timeout=30";
            con = new SqlConnection(ConString);
            cmd = new SqlCommand();
            cmd.Connection = con;  
        }

        public DataTable gegevensopnemen(string Req) 
        {
        dt = new DataTable();
        sda = new SqlDataAdapter(Req, ConString);
            sda.Fill(dt);
            return dt;
        }

        public int stuurgegevens(string Req)
        {
            int cnt = 0;
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandText = Req;
            cnt = cmd.ExecuteNonQuery();
            return cnt;
        }
    }
}
