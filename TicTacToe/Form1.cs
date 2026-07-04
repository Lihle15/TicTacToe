namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool isXTurn = true;   // true = X's turn
        int moveCount = 0;

        int xScore = 0;
        int oScore = 0;
        int draws = 0;
        int roundsPlayed = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text != "")
                return;

            btn.Text = isXTurn ? "X" : "O";

            isXTurn = !isXTurn;
            moveCount++;

            lblStatus.Text = isXTurn ? "Player X turn" : "Player O turn";

            CheckWinner();
        }

        private void CheckWinner()
        {
            bool winner = false;

            // Horizontal
            if (btn1.Text == btn2.Text && btn2.Text == btn3.Text && btn1.Text != "") winner = true;
            if (btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn4.Text != "") winner = true;
            if (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn7.Text != "") winner = true;

            // Vertical
            if (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn1.Text != "") winner = true;
            if (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn2.Text != "") winner = true;
            if (btn3.Text == btn6.Text && btn6.Text == btn9.Text && btn3.Text != "") winner = true;

            // Diagonals
            if (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn1.Text != "") winner = true;
            if (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn3.Text != "") winner = true;

            if (winner)
            {
                string winnerPlayer = isXTurn ? "O" : "X";

                lblStatus.Text = $"Player {winnerPlayer} Wins!";
                DisableButtons();

                // UPDATE SCOREBOARD
                if (winnerPlayer == "X")
                {
                    xScore++;
                    lblXScore.Text = "X: " + xScore;
                }
                else
                {
                    oScore++;
                    lblOScore.Text = "O: " + oScore;
                }

                roundsPlayed++;
                CheckMatchOver();   // ?? NEW
            }
            else if (moveCount == 9) // draw
            {
                lblStatus.Text = "Draw!";

                draws++;
                lblDraws.Text = "Draws: " + draws;

                roundsPlayed++;
                CheckMatchOver();   // ?? NEW
            }

        }
        private void CheckMatchOver()
        {
            if (roundsPlayed < 5)
                return;

            // 5 rounds finished
            string finalWinner;

            if (xScore > oScore)
                finalWinner = "X is the final winner of the match!";
            else if (oScore > xScore)
                finalWinner = "O is the final winner of the match!";
            else
                finalWinner = "The match ends in a tie!";

            MessageBox.Show(finalWinner, "Match Result");

            // RESET EVERYTHING
            roundsPlayed = 0;
            xScore = 0;
            oScore = 0;
            draws = 0;

            lblXScore.Text = "X: 0";
            lblOScore.Text = "O: 0";
            lblDraws.Text = "Draws: 0";

            // Clear board but keep player turn
            BtnRestart_Click(null, null);
        }


        private void DisableButtons()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button && c.Name.StartsWith("btn"))
                    c.Enabled = false;
            }
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            isXTurn = true;
            moveCount = 0;

            lblStatus.Text = "Player X turn";

            foreach (Control c in this.Controls)
            {
                if (c is Button && c.Name.StartsWith("btn") && c.Name != "btnRestart")
                {
                    c.Enabled = true;
                    c.Text = "";
                }
            }
        }
    }
}
