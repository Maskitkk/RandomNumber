using System;
using System.Windows.Forms;

namespace randomNumbers
{
    public partial class RandoNumberGenerator : Form
    {
        public RandoNumberGenerator()
        {
            InitializeComponent();
        }

        private int? StartValue;
        private int? EndValue;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int UserStartInput))
            {
                StartValue = UserStartInput;
            }
            else
            {
                textBox3.Text = " ";
                StartValue = 0;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int UserEndInput))
            {
                EndValue = UserEndInput;
            }
            else
            {
                textBox3.Text = " ";
                StartValue = 0;
            }
        }

        private void GENERATE_Click(object sender, EventArgs e)
        {
            if (StartValue != null && EndValue != null && !string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) && StartValue < EndValue && StartValue != 0 && EndValue != 0)
            {
                GetRandomNumber(StartValue.Value, EndValue.Value);
            }
            else
            {
                MessageBox.Show("Enter correct numbers", "Error", MessageBoxButtons.OK);
            }
        }

        private void GetRandomNumber(int startValue, int endValue)
        {
            Random random = new Random();
            int result = random.Next(startValue, endValue);
            string resultText = result.ToString();
            textBox3.Text = resultText;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
