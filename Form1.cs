using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Faradars6
{
    public partial class Form1 : Form
    {
        private readonly Random random = new Random();
        private readonly int randomNumber;

        public Form1()
        {
            InitializeComponent();
            randomNumber = random.Next(11);
        }

        private void TryButton_Click(object sender, EventArgs e)
        {
            try
            {
                int userNumber = Convert.ToInt32(userInput.Text);

                if (userNumber == randomNumber)
                {
                    MessageBox.Show("Yeah! Good for you!", "Congratulation!");
                    userInput.Clear();
                }
                else if (userNumber < 0 || userNumber > 10)
                {
                    MessageBox.Show("My number is between 0 and 10!");
                }
                else
                {
                    MessageBox.Show("Nope.");
                }
            }
            catch
            {
                MessageBox.Show("Your input must be an integer number.", "Error!");
            }
        }

        private void ChangeColor_Click(object sender, EventArgs e)
        {

            if (colorBox.Text == "default")
            {
                this.BackColor = Color.SlateGray;
            }
            else if (colorBox.Text == "white")
            {
                this.BackColor = Color.White;
            }
            else if (colorBox.Text == "peach puff")
            {
                this.BackColor = Color.PeachPuff;
            }
            else
            {
                this.BackColor = Color.DarkCyan;
            }

        }
    }
}
