using System.Data.SqlClient;

namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string q;
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\.NET\\WinFormsApp8\\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            q = "insert into [dbo].[Table] (EnrlNo,NAME,AGE,CITY)values(@EnrlNo,@NAME,@AGE,@CITY)";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@EnrlNo", textBox1.Text);
            cmd.Parameters.AddWithValue("@NAME", textBox2.Text);
            cmd.Parameters.AddWithValue("@AGE", textBox3.Text);
            cmd.Parameters.AddWithValue("@CITY", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string q;
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\.NET\\WinFormsApp8\\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            q = "UPDATE [dbo].[Table] SET EnrlNo = @EnrlNo, NAME = @NAME, AGE = @AGE, CITY = @CITY WHERE EnrlNo = @EnrlNo";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@EnrlNo", textBox1.Text);
            cmd.Parameters.AddWithValue("@NAME", textBox2.Text);
            cmd.Parameters.AddWithValue("@AGE", textBox3.Text);
            cmd.Parameters.AddWithValue("@CITY", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string q;
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\.NET\\WinFormsApp8\\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            q = "DELETE FROM [dbo].[Register] WHERE EnrlNo = @EnrlNo";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@EnrlNo", textBox1.Text);
            cmd.Parameters.AddWithValue("@NAME", textBox2.Text);
            cmd.Parameters.AddWithValue("@AGE", textBox3.Text);
            cmd.Parameters.AddWithValue("@CITY", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string q;
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\.NET\\WinFormsApp8\\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            q = "insert into [dbo].[Table] (EnrlNo,NAME,AGE,CITY)values(@EnrlNo,@NAME,@AGE,@CITY)";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@EnrlNo", textBox1.Text);
            cmd.Parameters.AddWithValue("@NAME", textBox2.Text);
            cmd.Parameters.AddWithValue("@AGE", textBox3.Text);
            cmd.Parameters.AddWithValue("@CITY", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
