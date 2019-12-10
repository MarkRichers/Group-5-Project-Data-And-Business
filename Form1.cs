using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace application1Database
{
    
    public partial class Form1 : Form
    {
       
      
        public Form1()
        {
            InitializeComponent();
            groupBox1.Hide();
            groupBox2.Visible = false; 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'livingDatabase1DataSet.Chores' table. You can move, or remove it, as needed.
            this.choresTableAdapter.Fill(this.livingDatabase1DataSet.Chores);
            // TODO: This line of code loads data into the 'livingDatabase1DataSet.Apartments' table. You can move, or remove it, as needed.
            this.apartmentsTableAdapter.Fill(this.livingDatabase1DataSet.Apartments);
            // TODO: This line of code loads data into the '_123DataSet1.Booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this._123DataSet1.Booking);
        }
        private void button1_Click(object sender, EventArgs e)
        {
          
        }
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                groupBox1.Show();
            }            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //load the the chores and price table
            if (checkBox1.Checked)
            {
                groupBox2.Visible = true; 
            }
        }
        private void apartmentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //if the will the feedback from some row include the 
            MessageBox.Show("Announcement has been sent");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //creat a function to get a list of appartment
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source = D:\Studying File\DATA FILES\UNIVERSITY\University\SEMSTER1\Mục Lung tung beng\application1Database\livingDatabase1.accdb";

            cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open  !");
            cnn.Close();
        }
    }
}
