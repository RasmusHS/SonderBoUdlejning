using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SonderBoUdlejning.InputCheck;

namespace SonderBoUdlejning.VentelisteSystems
{
    public class vGetPos
    {
        ConnString connString = ConnString.getConnInstance;

        public string vGetPosition(string pId, string bId)
        {
            string position;
            SqlConnection conn = new SqlConnection(connString.connStr);
            conn.Open();
            string sqlS = $"SELECT ROW_NUMBER() OVER(ORDER BY signUpDato ASC) AS row_num, signUpDato, bId, pId FROM Venteliste WHERE bId = {bId}";
            SqlCommand cmd = new SqlCommand(sqlS, conn);

            SqlDataReader reader = cmd.ExecuteReader();
            List<int> getNumbersList = new List<int>();
            while (reader.Read())
            {
                getNumbersList.Add(Convert.ToInt32(reader.GetValue(3)));
            }
            conn.Close();

            int[] positionenArray = getNumbersList.ToArray();

            position = Convert.ToString(Array.IndexOf(positionenArray, Convert.ToInt32(pId)) + 1);

            if (ErrorMessage.injectedSQL == 1)
            {
                position = null;
                conn.Close();
            }
            else
            {
                conn.Close();
                return position;
            }
            return position;

        }
    }
}
