using System.Runtime.ExceptionServices;

namespace SimpleFormApp
{
    public partial class Form1 : Form
    {
        private object lastNameValue;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fNameValue = firstName.Text;
            string fLastNameValue = lastName.Text;
            string fMiddleNameValue = middleName.Text;
            string fsuffixValue = suffix.Text;
            MessageBox.Show($"Hello There! {fNameValue} {fLastNameValue} {fMiddleNameValue} {fsuffixValue}", "Greetings!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void suffix_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
