using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace SonderBoUdlejning.SQLBuilders
{
    internal interface ISQLBuilder
    {
        string SQLBuilder();
        
        //Field/property or method for errorHandling is still WIP
    }
}
