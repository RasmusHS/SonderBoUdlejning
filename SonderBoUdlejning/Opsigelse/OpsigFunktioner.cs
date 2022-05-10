using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonderBoUdlejning.Opsigelse
{
    public static class OpsigFunktioner
    {
        public static string DateBuilder(int cBMonthIndex, string year) 
        {
            int monthIndex;
            if (cBMonthIndex > -1)
            {
                if (cBMonthIndex < 9)
                {
                    monthIndex = cBMonthIndex + 1;

                    string yearTB = year;

                    StringBuilder sb = new StringBuilder();

                    sb.Append(yearTB);
                    sb.Append("-");
                    sb.Append("0");
                    sb.Append(monthIndex);
                    sb.Append("-");
                    sb.Append("01");

                    return sb.ToString();
                }
                else
                {
                    monthIndex = Convert.ToInt32(cBMonthIndex) + 1;

                    string yearTB = year;

                    StringBuilder s2 = new StringBuilder();

                    s2.Append(yearTB);
                    s2.Append("-");
                    s2.Append(monthIndex);
                    s2.Append("-");
                    s2.Append("01");

                    return s2.ToString();
                }

            }
            return null;
        }
    }
}
