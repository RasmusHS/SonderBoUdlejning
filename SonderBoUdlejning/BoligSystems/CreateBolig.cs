﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SonderBoUdlejning.InputCheck;

namespace SonderBoUdlejning.BoligSystems
{
    internal class CreateBolig
    {
        ConnString connString = ConnString.getConnInstance;
        
        public void opretBolig(string adresse, string postNr, string bId, string indflytDato)
        {
            string sqlS = "INSERT INTO Bolig VALUES (@adresse, @postNr, @bId, @indflytDato)";
            SqlConnection conn = new SqlConnection(connString.connStr);
            SqlCommand cmd = new SqlCommand(sqlS, conn);

            cmd.Parameters.Clear();

            cmd.Parameters.Add("@adresse", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@adresse"].Value = Convert.ToString(adresse);

            cmd.Parameters.Add("@postNr", System.Data.SqlDbType.Int);
            cmd.Parameters["@postNr"].Value = Convert.ToInt32(postNr);
            
            cmd.Parameters.Add("@bId", System.Data.SqlDbType.Int);
            cmd.Parameters["@bId"].Value = Convert.ToInt32(bId);

            cmd.Parameters.Add("@indflytDato", System.Data.SqlDbType.Date);
            cmd.Parameters["@indflytDato"].Value = $"{indflytDato.Substring(4, 4)}-{indflytDato.Substring(2, 2)}-{indflytDato.Substring(0, 2)}";

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("SUCCESS :\n" + sqlS + "\nmed værdierne: (" +
                                    cmd.Parameters["@adresse"].Value + ", " +
                                    cmd.Parameters["@postNr"].Value + ", " +
                                    cmd.Parameters["@bId"].Value + ", " +
                                    cmd.Parameters["@indflytDato"].Value +
                                    ")");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
