namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Welcome to First Windows Application";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
