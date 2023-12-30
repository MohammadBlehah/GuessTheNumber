namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int targetNumber;
        private const int MinNumber = 1;
        private const int MaxNumber = 1000;

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxGuess.Text, out int userGuess))
            {
                EvaluateGuess(userGuess);
            }
            else
            {
                MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EvaluateGuess(int userGuess)
        {
            if (userGuess == targetNumber)
            {
                labelResult.Text = "Correct!";
                MessageBox.Show("Congratulations! You guessed the correct number.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.BackColor = System.Drawing.Color.Green;
                textBoxGuess.Enabled = false;
                buttonGuess.Enabled = false;
            }
            else
            {
                int difference = Math.Abs(targetNumber - userGuess);
                labelResult.Text = userGuess > targetNumber ? "Too High" : "Too Low";
                this.BackColor = difference < 10 ? System.Drawing.Color.Red : System.Drawing.Color.Blue;
            }
        }




        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void InitializeGame()
        {
            Random random = new Random();
            targetNumber = random.Next(MinNumber, MaxNumber + 1);

            labelPrompt.Text = "I have a number between 1 and 1000--can you guess my number?";
            labelResult.Text = "";
            textBoxGuess.Text = "";
            textBoxGuess.Enabled = true;
            buttonGuess.Enabled = true;
            this.BackColor = DefaultBackColor;
        }

    }
}
