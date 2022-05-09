using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonderBoUdlejning.Admin
{
    public partial class OpsigelseAfBolig : Form
    {
        public OpsigelseAfBolig()
        {
            InitializeComponent();
        }

        SQLExecutionHandler tableConn = new SQLExecutionHandler();
        string sqlS1 = "SELECT * FROM Bolig";
        string sqlS2 = "SELECT * FROM Person";

        private void OpsigelseAfBolig_Load(object sender, EventArgs e)
        {
            DGVBolig.DataSource = tableConn.tableBinder(sqlS1);
            DGVPerson.DataSource = tableConn.tableBinder(sqlS2);
        }
    }
}
