using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StudentRegistrationSystem
{
    class connection
    {
        SqlConnection con;

        public connection()
        {
            con = new SqlConnection("Data source=DESKTOP-7FJG2JU;Initial Catalog=studentdata;Integrated Security=True");
        }

        public SqlConnection opencon()
        {
            try
            {
                con.Open();
            }
            catch (Exception )
            {
             
                
            }

            return con;
        }

        public void conclose()
        {
            try
            {
                con.Close();
            }
            catch (Exception)
            {

              
            }
        }
           
    }
}
