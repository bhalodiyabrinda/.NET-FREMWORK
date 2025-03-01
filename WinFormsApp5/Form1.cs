using System.Xml.Linq;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string name = textBox1.Text;
            string organization = textBox2.Text;
            string comment = textBox3.Text;

            string message = $"Message of {name} from {organization} with {comment}";

            textBox4.Text = message;
        }
    }
}
