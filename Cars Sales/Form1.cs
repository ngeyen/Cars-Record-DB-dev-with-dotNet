using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Cars_Sales
{
    public partial class FormRecordCars : Form
    {
        public FormRecordCars()
        {
            InitializeComponent();
        }
        private void FormRecordClars_Load(object sender, EventArgs e)
        {
            OleDbConnection tr_Connection = new OleDbConnection();
            tr_Connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\CarsDB.mdb";
            tr_Connection.Open();
            string selectAllQuery = "Select * from CarsDB";

            //Declaring the adapter that is assigned the value of str
            OleDbDataAdapter recordToCarsDB = new OleDbDataAdapter(selectAllQuery, tr_Connection);

            //Declare a dataset called ds
            DataSet ds = new DataSet();
            recordToCarsDB.Fill(ds, "CarsDB");

            //Declare a data row (drow)
            DataRow dataR;
            dataR = ds.Tables["CarsDB"].Rows[0];

            //Assigning values to Fields on the form

            CarID.Text = dataR.ItemArray.GetValue(0).ToString();
            Make.Text = dataR.ItemArray.GetValue(1).ToString();
            Model.Text = dataR.ItemArray.GetValue(2).ToString();
            Price.Text = dataR.ItemArray.GetValue(3).ToString();
            tr_Connection.Close();
        }


        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Make_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
