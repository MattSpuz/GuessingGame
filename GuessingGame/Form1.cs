using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand = new Random();
        int n, guess, attempt;

        private void ResetButton_Click(object sender, EventArgs e)
        {
            InputBox.Text = string.Empty;
            OutputLabel.Text = string.Empty;
            InputBox.Focus();
            getNumber();
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(InputBox.Text, out guess))
            {
                attempt++;
                if (guess == n)
                {
                    OutputLabel.Text = "You've attempted " + attempt + " time(s).\nYour last guess is " + guess + "\n" +
                        "Congratulations! You Won!";
                }
                else if(guess > n)
                {
                    OutputLabel.Text = "Sorry, Too high\nGuess Again";
                }
                else
                    OutputLabel.Text = "Sorry, Too Low\nGuess Again";
            }
            InputBox.Text = String.Empty;
            InputBox.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            n = rand.Next(0, 99) + 1;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //closes the program
            this.Close();
        }

        public void getNumber()
        {
            n = rand.Next(0, 99) + 1;
            attempt = 0;
        }
    }
}
