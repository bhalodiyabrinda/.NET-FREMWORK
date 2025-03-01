namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            this.ForeColor = Color.Black;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.ForeColor = Color.White;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.ForeColor = Color.Red;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;

        }
    }
}
