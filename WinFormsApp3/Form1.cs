using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query;
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\.NET\\WinFormsApp3\\AdminData.mdf;Integrated Security=True";
            SqlConnection con= new SqlConnection(constring);
            con.Open();
            query = "insert into Table (NAME,BRINCH,DIV,SEM)values(@NAME,@BRINCH,@DIV,@DIV)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@NAME", textBox1.Text);
            cmd.Parameters.AddWithValue("@BRINCH", textBox2.Text);
            cmd.Parameters.AddWithValue("@DIV", textBox3.Text);
            cmd.Parameters.AddWithValue("@SEM",Convert.ToInt32 (textBox4.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Registers Succefully!!!");
        }
    }
}
