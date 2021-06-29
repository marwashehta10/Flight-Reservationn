using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Phase_2_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         OracleDataAdapter adapter;
         OracleCommandBuilder builder;
         DataSet ds;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_airplane_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl1; User Id=hr; Password=hr;";
            string cmdstr = " ";
            cmdstr = "Select * from AIRPLANE";
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            AirPlane.DataSource = ds.Tables[0];
        }

        private void btn_airport_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl1; User Id=hr; Password=hr;";
            string cmdstr = "";
            cmdstr = "Select * from AIRPORT";
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            AirPort.DataSource = ds.Tables[0];
        }

        private void btn_airline_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl1; User Id=hr; Password=hr;";
            string cmdstr = "";
            cmdstr = "Select * from AIRLINE";
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            AirLine.DataSource = ds.Tables[0];
        }

        private void btn_flight_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl1; User Id=hr; Password=hr;";
            string cmdstr = "";
            cmdstr = "Select * from FLIGHT";
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            Flight.DataSource = ds.Tables[0];
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("UPDATED");
        }

        private void AirPlane_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AirPort_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AirLine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Flight_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
