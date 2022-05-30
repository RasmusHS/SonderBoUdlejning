using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;
using SonderBoUdlejning.BookingSystems;

namespace SonderBoUdlejning.Admin
{
    public partial class Booking : Form
    {
        ConnString connString = ConnString.getConnInstance;
        SQLExecutionHandler tableConn = new SQLExecutionHandler();
        string sqlS1 = "SELECT Person.pId AS 'Person ID', fNavn AS 'Fulde Navn', resNr AS 'Reservations Nr.', Ressourcer.rId AS 'Ressource ID', rTypeNavn AS 'Ressource Navn', rType AS 'Ressource Type', rStartDato AS 'Start Dato', rSlutDato AS 'Slut Dato' FROM Ressourcer INNER JOIN Reservationer ON Ressourcer.rId = Reservationer.rId INNER JOIN Person ON Person.pId=Reservationer.pId ORDER BY Person.pId";
        string sqlS2 = "SELECT rId AS 'Ressource ID', rTypeNavn AS 'Ressource Navn', rType AS 'Ressource Type' FROM Ressourcer WHERE rId NOT IN(SELECT rId AS 'Ressource ID' FROM Reservationer WHERE GETDATE() BETWEEN rStartDato AND rSlutDato)";

        List<string> listBeboer = new List<string>();
        List<int> listBeboerID = new List<int>();

        List<string> listResource = new List<string>();
        List<int> listResourceID = new List<int>();

        public Booking()
        {
            InitializeComponent();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            dgvReservationer.DataSource = tableConn.tableBinder(sqlS1);
            dgvRessourcer.DataSource = tableConn.tableBinder(sqlS2);

            dgvReservationer.RowHeadersVisible = false;
            dgvReservationer.BorderStyle = BorderStyle.FixedSingle;
            dgvReservationer.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReservationer.RowTemplate.Height = 30;
            dgvReservationer.RowTemplate.DividerHeight = 1;
            dgvReservationer.GridColor = Color.Black;
            dgvReservationer.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192);

            dgvRessourcer.RowHeadersVisible = false;
            dgvRessourcer.BorderStyle = BorderStyle.FixedSingle;
            dgvRessourcer.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRessourcer.RowTemplate.Height = 30;
            dgvRessourcer.RowTemplate.DividerHeight = 1;
            dgvRessourcer.GridColor = Color.Black;
            dgvRessourcer.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192);

            /*
            .RowHeadersVisible = false;
            .BorderStyle = BorderStyle.FixedSingle;
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            .RowTemplate.Height = 30;
            .RowTemplate.DividerHeight = 1;
            .GridColor = Color.Black;
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192);
             */

            string date = DateTime.Today.ToString("yyyy-MM-dd");
            dtpStart.Text = date;

            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.CustomFormat = "dd-MM-yyyy";

            BookingFacade.getPersonList(listBeboerID, listBeboer);
            BookingFacade.getRessourceList(listResourceID, listResource, date);

            foreach (string item in listResource)
            {
                comboResource.Items.Add(item);
            }

            foreach (string item in listBeboer) 
            {
                comboMembers.Items.Add(item);
                comboMembersRes.Items.Add(item);
                comboDeleteResFromBeboer.Items.Add(item);

            }
        }

        private void CBMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] arrayBeboerID = listBeboerID.ToArray(); 
            PanelPersonInfo.Visible = true;
            int personID = arrayBeboerID[comboMembers.SelectedIndex];
            tbPId.Text = personID.ToString();

            string queryTlf = $"SELECT pTlf FROM Person WHERE pId = {personID}";
            string queryMail = $"SELECT pMail FROM Person WHERE pId = {personID}";

            SqlConnection conn = new SqlConnection(connString.connStr);
            SqlCommand cmd = new SqlCommand(queryTlf, conn);
            conn.Open();
            tbTlf.Text = Convert.ToString(cmd.ExecuteScalar());
            conn.Close();

            SqlCommand cmd2 = new SqlCommand(queryMail, conn);
            conn.Open();
            tbMail.Text = Convert.ToString(cmd2.ExecuteScalar());
            conn.Close();

            if (PanelResource.Visible == true)
            {
                btnConfirmBooking.Visible = true;
            }
        }
        

        private void CBResource_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Denne text box skal slettes. det er bare for at se om den ID er korrekt
            int[] arrayResourceID = listResourceID.ToArray();
            int resourceID = arrayResourceID[comboResource.SelectedIndex];
            tbResourceID.Text = resourceID.ToString();
            PanelResource.Visible = true;

            if (PanelPersonInfo.Visible == true) 
            {
                btnConfirmBooking.Visible = true;
            }
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            dtpStart.CustomFormat = "yyyy-MM-dd";
            string sqlS2 = "SELECT rId AS 'Ressource ID', rTypeNavn AS 'Ressource Navn', rType AS 'Ressource Type' FROM Ressourcer WHERE rId NOT IN(SELECT rId FROM Reservationer WHERE '" + dtpStart.Text + "' BETWEEN rStartDato AND rSlutDato)";
            dgvRessourcer.DataSource = tableConn.tableBinder(sqlS2);

            listResource.Clear();
            listResourceID.Clear();
            comboResource.Items.Clear();
            BookingFacade.getRessourceList(listResourceID, listResource, dtpStart.Text);
            foreach (string item in listResource)
            {
                comboResource.Items.Add(item);
            }

            tbResourceID.Text = "";
            dtpStart.CustomFormat = "dd-MM-yyyy";
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString.connStr);
            dtpStart.CustomFormat = "yyyy-MM-dd";
            dtpSlut.CustomFormat = "yyyy-MM-dd";
            DateTime dateToday = Convert.ToDateTime(dtpStart.Text);
            DateTime dateSlutDato = Convert.ToDateTime(dtpSlut.Text);
                
            if (dateSlutDato >= dateToday)
            {
                BookingFacade.checkSlutDato(dtpSlut.Text, tbResourceID.Text);
                int antalBookings = BookingFacade.slutDato;
                
                BookingFacade.checkMellemDatoer(dtpStart.Text, dtpSlut.Text, Convert.ToInt32(tbResourceID.Text));
                int antalBookingsBetweenDates = BookingFacade.mellemDatoer;

                try
                {
                    if (antalBookings == 0 && antalBookingsBetweenDates == 0)
                    {
                        //BookingSystems.CheckResourceIdType.getResourceIdType(TBResourceID.Text);
                        BookingFacade.checkRessourceIdType(tbResourceID.Text);

                        string checkAlreadyBookedQuery = $"SELECT COUNT(resNr) FROM Reservationer INNER JOIN Ressourcer ON Reservationer.rId = Ressourcer.rId WHERE pId = {Convert.ToInt32(tbPId.Text)} AND rType = {BookingFacade.ressourceIdType} AND rSlutDato >= GETDATE();";
                        SqlCommand cmdAlreadyBooked = new SqlCommand(checkAlreadyBookedQuery, conn);
                        conn.Open();
                        int AlreadyBookedQuery = Convert.ToInt32(cmdAlreadyBooked.ExecuteScalar());
                        conn.Close();
                        if (AlreadyBookedQuery < 4)
                        {
                            string query = "INSERT INTO Reservationer VALUES(" + Convert.ToInt32(tbResourceID.Text) + ", " + Convert.ToInt32(tbPId.Text) + ",'" + dtpStart.Text + "','" + dtpSlut.Text + "')";

                            SqlCommand cmd = new SqlCommand(query, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            MessageBox.Show("Reservation oprettet!");
                            dgvReservationer.DataSource = tableConn.tableBinder(sqlS1);
                        }
                        else
                        {
                            string input = comboResource.Text;
                            int index = input.LastIndexOf(" ");
                            if (index > 0)
                                input = input.Substring(0, index);
                            MessageBox.Show($"Denne beboer har opnået maks (3) antal bookings af {input}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ressource kan ikke bookes da en anden beboer har en reservation i det tidsrum.");
                    }
                }
                catch
                {
                    MessageBox.Show("Husk at vælge både beboer og en ressource.");
                }


                //Tjek om kunde allerede har en reservation af den resource type, dere r SQL i tableplus der finder ud af det!
                //if (0) {udfør booking}
                //else {"kunde har allerede en booking på denne resource type"}
                    

            }
            else 
            {
                MessageBox.Show("Slut dato kan ikke være før start dato");
            }
            dtpStart.CustomFormat = "dd-MM-yyyy";
            dtpSlut.CustomFormat = "dd-MM-yyyy";
        }

        private void btnAntalRes_Click(object sender, EventArgs e)
        {
            string query = "SELECT Person.pId AS 'Person ID', fNavn AS 'Fulde Navn', COUNT(resNr) AS 'Antal Reservationer' FROM Reservationer LEFT JOIN Person ON Reservationer.pId = Person.pId GROUP BY Person.pId, fNavn;";
            dgvReservationer.DataSource = tableConn.tableBinder(query);
        }

        private void btnSePersonRes_Click(object sender, EventArgs e)
        {
            try{
                int[] arrayBeboerID = listBeboerID.ToArray();
                int personID = arrayBeboerID[comboMembersRes.SelectedIndex];

                //string query = $"SELECT fNavn, resNr, rTypeNavn, rStartDato, rSlutDato FROM Reservationer INNER JOIN Person ON Reservationer.pId = Person.pId INNER JOIN Ressourcer ON Reservationer.rId = Ressourcer.rId WHERE Person.pId = {personID};";
                string query = $"SELECT fNavn AS 'Fulde navn', resNr AS 'Reservations nr.', rTypeNavn AS 'Ressource navn', rStartDato AS 'Start dato', rSlutDato AS 'Slut dato' FROM Reservationer INNER JOIN Person ON Reservationer.pId = Person.pId INNER JOIN Ressourcer ON Reservationer.rId = Ressourcer.rId WHERE Person.pId = {personID};";
                dgvReservationer.DataSource = tableConn.tableBinder(query);
            }
            catch
            {
                MessageBox.Show("Du skal vælge person for at se deres reservationer");
            }
        }

        List<int> beboerResID = new List<int>();
        private void comboDeleteResFromBeboer_SelectedIndexChanged(object sender, EventArgs e)
        {
            beboerResID.Clear();
            tbResNr.Text = "";
            comboDeleteBeboerResource.Items.Clear();
            comboDeleteBeboerResource.Visible = true;
            lblPickPRes.Visible = true;
            string query = $"SELECT COUNT(rTypeNavn) FROM Ressourcer INNER JOIN Reservationer ON Ressourcer.rId = Reservationer.rId WHERE pId = {comboDeleteResFromBeboer.SelectedIndex} + 1;";
            SqlConnection conn = new SqlConnection(connString.connStr);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int antalReservationerPRBeboer = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            string query2 = $"SELECT rTypeNavn FROM Ressourcer INNER JOIN Reservationer ON Ressourcer.rId = Reservationer.rId WHERE pId = {comboDeleteResFromBeboer.SelectedIndex} + 1 ORDER BY rTypeNavn;";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            conn.Open();
            SqlDataReader reader = cmd2.ExecuteReader();
            for (int i = 0; i < antalReservationerPRBeboer; i++)
            {
                while (reader.Read())
                {
                    comboDeleteBeboerResource.Items.Add(reader.GetString(i));
                }
            }
            conn.Close();


            
            string query3 = $"SELECT resNr FROM Ressourcer INNER JOIN Reservationer ON Ressourcer.rId = Reservationer.rId WHERE pId = {comboDeleteResFromBeboer.SelectedIndex} + 1 ORDER BY rTypeNavn;";
            SqlCommand cmd3 = new SqlCommand(query3, conn);
            conn.Open();
            SqlDataReader reader2 = cmd3.ExecuteReader();
            for (int i = 0; i < antalReservationerPRBeboer; i++)
            {
                while (reader2.Read())
                {
                    beboerResID.Add(reader2.GetInt32(i));
                }
            }
            conn.Close();
        }

        private void btnDeleteRes_Click(object sender, EventArgs e)
        {
            
            int[] listBeboerIDArray = listBeboerID.ToArray();
            if (string.IsNullOrEmpty(tbResNr.Text))
            {
                MessageBox.Show("Vælg venligst en beboer og en af deres reservationer");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Er du sikker på du vil slette denne reservation?", "Sikker?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int resNr = Convert.ToInt32(tbResNr.Text);
                    string query = $"DELETE FROM Reservationer WHERE resNr = {resNr};";
                    SqlConnection conn = new SqlConnection(connString.connStr);
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    int antalReservationerPRBeboer = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                    MessageBox.Show($"Reservation {resNr} blev slettet");
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Reservationen blev ikke slettet");
                }
            }
        }

        private void comboDeleteBeboerResource_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] beboerResIDArray = beboerResID.ToArray();
            tbResNr.Text = Convert.ToString(beboerResIDArray[comboDeleteBeboerResource.SelectedIndex]);
        }

        private void btnGetReservations_Click(object sender, EventArgs e)
        {
            //Statistik over alle ressourcer
            CreateDir.CreateDirectory();
            string username = Environment.UserName;
            string filePath = $@"C:\Users\{username}\Documents\SønderBoUdlejning\Statistik\AntalReservationer For Ressourcer.txt";
            string[] rTypeNavnArray = new string[30];
            string[] antalReservationerArray = new string[30];
            SqlConnection conn = new SqlConnection(connString.connStr);
            BookingFacade.setArrayInfo(rTypeNavnArray, antalReservationerArray, conn);

            StringBuilder sb = new StringBuilder();

            string time = DateTime.Now.ToString("dd-MM-yyyy");

            sb.Append($"Datointerval: 01-01-2022 - {time}");
            sb.Append(Environment.NewLine); //Change line
            sb.Append(Environment.NewLine); //Change line
            sb.Append("Type Resource:");
            sb.Append("\t"); //Add tabulation
            sb.Append("\t"); //Add tabulation
            sb.Append("Antal Reservationer:");
            sb.Append(Environment.NewLine); //Change line

            for (int i = 0; i < rTypeNavnArray.Length; i++) {
                sb.Append(rTypeNavnArray[i]);
                sb.Append("\t"); //Add tabulation
                if (i < 20) 
                {
                    sb.Append("\t"); //Add tabulation
                }
                sb.Append(antalReservationerArray[i]);
                sb.Append(Environment.NewLine); //Change line
                
            }
            using (StreamWriter sw = new StreamWriter(filePath)) 
            {
                sw.WriteLine(sb.ToString());
            }
            MessageBox.Show($"Fil er gemt i {filePath}");
            
        }

        private void btnGetDateReservationer_Click(object sender, EventArgs e)
        {
            //Statistik over hvem har brugt hvad
            CreateDir.CreateDirectory();
            string username = Environment.UserName;
            string filePath = $@"C:\Users\{username}\Documents\SønderBoUdlejning\Statistik\Individuelle Reservationer.txt";
            SqlConnection conn = new SqlConnection(connString.connStr);
            dtpStatistik.CustomFormat = "yyyy-MM-dd";
            string query = $"SELECT COUNT(DISTINCT Person.pId) FROM Reservationer INNER JOIN Ressourcer ON Reservationer.rId = Ressourcer.rId INNER JOIN Person ON Reservationer.pId = Person.pId WHERE'{dtpStatistik.Text}'BETWEEN rStartDato AND rSlutDato;";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int arrayLenth = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            int[] personIdArray = new int[arrayLenth];
            string[] fuldeNavnArray = new string[arrayLenth];
            string[] adresseArray = new string[arrayLenth];
            string[] reservationerArray = new string[arrayLenth];
            

            //Get personIdArray list
            conn.Open();
            int i = 0;
            query = $"SELECT DISTINCT Person.pId, fNavn AS FuldeNavn, Lejemaal.adresse, ( SELECT', '+ CAST(rTypeNavn AS VARCHAR(MAX)) FROM Reservationer INNER JOIN Ressourcer ON Reservationer.rId = Ressourcer.rId WHERE pId = Person.pId AND'{dtpStatistik.Text}'BETWEEN rStartDato AND rSlutDato FOR XML PATH('') ) AS Reservationer FROM Reservationer INNER JOIN Ressourcer ON Reservationer.rId = Ressourcer.rId INNER JOIN Person ON Reservationer.pId = Person.pId INNER JOIN Lejemaal ON Person.pId = Lejemaal.pId WHERE'{dtpStatistik.Text}'BETWEEN rStartDato AND rSlutDato;";
                cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    personIdArray[i] = reader.GetInt32(0);
                    fuldeNavnArray[i] = reader.GetString(1);
                    adresseArray[i] = reader.GetString(2);
                    reservationerArray[i] = reader.GetString(3);
                    reservationerArray[i] = reservationerArray[i].Remove(0, 2);
                i++;
                }                
            conn.Close();
            dtpStatistik.CustomFormat = "dd-MM-yyyy";

            StringBuilder sb = new StringBuilder();

            sb.Append($"Dato: {dtpStatistik.Text}");
            sb.Append(Environment.NewLine); //Change line
            sb.Append("Person ID:");
            sb.Append("\t"); //Add tabulation       
            sb.Append("Fulde Navn:");
            sb.Append("\t"); //Add tabulation
            sb.Append("Adresse");
            sb.Append("\t"); //Add tabulation
            sb.Append("\t"); //Add tabulation
            sb.Append("Reserverede resourcer:");
            sb.Append(Environment.NewLine); //Change line
            

            for (int l = 0; l < arrayLenth; l++)
            {
                sb.Append(personIdArray[l]);
                sb.Append("\t"); //Add tabulation 
                sb.Append("\t"); //Add tabulation 
                sb.Append(fuldeNavnArray[l]);
                sb.Append("\t"); //Add tabulation
                if (fuldeNavnArray[l].Length < 8) 
                {
                    sb.Append("\t"); //Add tabulation
                }
                
                if (fuldeNavnArray[l].Length > 12) 
                {
                    sb.Append("\t"); //Add tabulation
                }
                sb.Append(adresseArray[l]);
                sb.Append("\t");
                sb.Append(reservationerArray[l]);
                sb.Append(Environment.NewLine); //Change line

            }
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine(sb.ToString());
                MessageBox.Show($@"Statistik blev genereret og ligger i C:\Brugere\{username}\Dokumenter\SønderBoUdlejning\Statistik");
            }

            MessageBox.Show($"Fil er gemt i {filePath}");
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvReservationer.DataSource = tableConn.tableBinder(sqlS1);
            dgvRessourcer.DataSource = tableConn.tableBinder(sqlS2);

            comboResource.Items.Clear();
            comboMembers.Items.Clear();
            comboMembersRes.Items.Clear();
            comboDeleteResFromBeboer.Items.Clear();
            tbPId.Text = "";
            tbMail.Text = "";
            tbTlf.Text = "";
            tbResourceID.Text = "";
            tbResNr.Text = "";
            comboDeleteBeboerResource.Items.Clear();
            comboDeleteBeboerResource.Visible = false;
            lblPickPRes.Visible = false;

            foreach (string item in listResource)
            {
                comboResource.Items.Add(item);
            }

            foreach (string item in listBeboer)
            {
                comboMembers.Items.Add(item);
                comboMembersRes.Items.Add(item);
                comboDeleteResFromBeboer.Items.Add(item);

            }
        }
    }
}
