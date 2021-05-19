using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjectCNPM
{
    class cla_crud
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-R7FSL09R\SQLEXPRESS;Initial Catalog=ProjectCNPM;Integrated Security=True");

        private void OpenConnect()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        private void CloseConnect()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public Boolean ExceData(string cmd)
        {
            OpenConnect();

            Boolean check = false;

            try
            {
                SqlCommand command = new SqlCommand(cmd, conn);
                command.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }

            CloseConnect();

            return check;
        }

        public DataTable ReadData(string cmd)
        {
            OpenConnect();

            DataTable dt = new DataTable();

            try
            {
                SqlCommand command = new SqlCommand(cmd, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dt);
            }
            catch (Exception)
            {
                dt = null;
            }

            CloseConnect();

            return dt;
        }


    }
}
