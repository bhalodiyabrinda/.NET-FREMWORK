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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        string gender, choice;

        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void label5_Click(object sender, EventArgs e)
        {
        }
        private void label6_Click(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string q;
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\.NET\\WinFormsApp7\\StudentDatabase.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();

            if (checkBox1.Checked == true)
            {
                choice = "APS.NET";
            }
            else
            {
                choice = "C#";
            }

            if (radioButton1.Checked == true)
            {
                gender = "MALE";
            }
            else
            {
                gender = "FEMALE";
            }

            q = "insert into STUDENT_DATABADS (NAME,BRANCH,SEM,CITY,GENDER,CHOICE)values(@NAME,@BRANCH,@SEM,@CITY,@GENDER,@CHOICE)";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@NAME", textBox1.Text);
            cmd.Parameters.AddWithValue("@BRANCH", textBox3.Text);
            cmd.Parameters.AddWithValue("@SEM", textBox4.Text);
            cmd.Parameters.AddWithValue("@CITY", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@GENDER", gender);
            cmd.Parameters.AddWithValue("@CHOICE", choice);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "your_connection_string";
            string query = "UPDATE STUDENT_DATABADS ( Name = @Name, Branch = @Branch, Sem = @Sem, City = @City, Gender = @Gender, Choice = @Choice WHERE ID = @ID)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                command.Parameters.AddWithValue("@Name", textBox1.Text);
                command.Parameters.AddWithValue("@Branch", textBox3.Text);
                command.Parameters.AddWithValue("@Sem", textBox4.Text);
                command.Parameters.AddWithValue("@City", comboBox1.SelectedItem.ToString());
                
                if (checkBox1.Checked == true)
                {
                    choice = "APS.NET";
                }
                else
                {
                    choice = "C#";
                }

                if (radioButton1.Checked == true)
                {
                    gender = "MALE";
                }
                else
                {
                    gender = "FEMALE";
                }
                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Record updated successfully.");
                }
                else
                {
                    MessageBox.Show("Update failed.");
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
