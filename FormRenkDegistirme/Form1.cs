namespace FormRenkDegistirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void gameOver()
        {
            button1.Enabled = true;
            button2.Enabled = false;
            textBox1.Enabled = false;
            textBox1.Clear();
            label1.Text = "Score :";
        }

        int score;
        int number;
        private void button1_Click(object sender, EventArgs e)
        {
            score = 100;
            label1.Text = "Score : " + score;
            Random rastgele = new Random();
            number = rastgele.Next(1, 101);
            button1.Enabled = false;
            MessageBox.Show("I mentally kept a number from 1 to 100." + Environment.NewLine + "You have 10 guesses." + Environment.NewLine + "Write your guess.");
            button2.Enabled = true;
            textBox1.Enabled = true;
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Write your guess.");
                textBox1.Focus();
                return;
            }

            int guess = Convert.ToInt32(textBox1.Text);

            if (score == 10 &&  guess != number)
            {
                MessageBox.Show("GAME OVER" + Environment.NewLine + "It was " + number);
                gameOver();
                return;
            }
            if (guess > number)
            {
                MessageBox.Show("Down");
                score -= 10;
            }
            else if (guess < number)
            {
                MessageBox.Show("Up");
                score -= 10;
            }
            else
            {
                MessageBox.Show("Congratulations." + Environment.NewLine + "Your Score is " + score);
                gameOver();
                return;
            }
            label1.Text = "Score : " + score;
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}