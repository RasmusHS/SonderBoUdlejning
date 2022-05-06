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
    public partial class TildelBolig : Form
    {
        SQLExecutionHandler tableConn = new SQLExecutionHandler();

        public TildelBolig()
        {
            InitializeComponent();


        }

        private void TildelBolig_Load(object sender, EventArgs e)
        {
            string sqlS1 = "SELECT * FROM Bolig";
            dgvBolig.DataSource = tableConn.tableBinder(sqlS1);

            string sqlS2 = "SELECT * FROM Person";
            dgvVenteliste.DataSource = tableConn.tableBinder(sqlS2);

        }

        private void tbBID_TextChanged(object sender, EventArgs e)
        {
            while (true)
            {
                if (tbBID.Text != null)
                {
                    panelPid.Visible = true;
                    break;
                }
            }
        }

        private void btnFindMedlemsInfo_Click(object sender, EventArgs e)
        {
    
                if (tbPID.Text != null)
                {
                    panelMedlemsinfo.Visible = true;
                    panelØnskerLejlighed.Visible = true;
                }
            
        }

        private void ckbJaTilLejlighed_CheckedChanged(object sender, EventArgs e)
        {
            panelUdskrivLejekontrakt.Visible = true;
        }

        private void btnUdskrivLejekontrakt_Click(object sender, EventArgs e)
        {
            
        }


    }
}
