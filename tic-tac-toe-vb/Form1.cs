using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe_vb
{
    public partial class Form1 : Form
    {
        Boolean checker;
        int plusone;

        void Enable_False()
        {
            TicButton1.Enabled = false;
            TicButton2.Enabled = false;
            TicButton3.Enabled = false;
            TicButton4.Enabled = false;
            TicButton5.Enabled = false;
            TicButton6.Enabled = false;
            TicButton7.Enabled = false;
            TicButton8.Enabled = false;
            TicButton9.Enabled = false;
        }

        void score()
        {
            if (TicButton1.Text =="X" && TicButton2.Text == "X" && TicButton3.Text == "X" )
            {
                TicButton1.BackColor = System.Drawing.Color.DeepPink;
                TicButton2.BackColor = System.Drawing.Color.DeepPink;
                TicButton3.BackColor = System.Drawing.Color.DeepPink;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(PlayerXScore.Text);
                PlayerXScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (TicButton1.Text == "X" && TicButton5.Text == "X" && TicButton9.Text == "X")
            {
                TicButton1.BackColor = System.Drawing.Color.DeepPink;
                TicButton5.BackColor = System.Drawing.Color.DeepPink;
                TicButton9.BackColor = System.Drawing.Color.DeepPink;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(PlayerXScore.Text);
                PlayerXScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (TicButton1.Text == "X" && TicButton4.Text == "X" && TicButton7.Text == "X")
            {
                TicButton1.BackColor = System.Drawing.Color.DeepPink;
                TicButton4.BackColor = System.Drawing.Color.DeepPink;
                TicButton7.BackColor = System.Drawing.Color.DeepPink;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(PlayerXScore.Text);
                PlayerXScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (TicButton2.Text == "X" && TicButton5.Text == "X" && TicButton8.Text == "X")
            {
                TicButton2.BackColor = System.Drawing.Color.DeepPink;
                TicButton5.BackColor = System.Drawing.Color.DeepPink;
                TicButton8.BackColor = System.Drawing.Color.DeepPink;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(PlayerXScore.Text);
                PlayerXScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (TicButton3.Text == "X" && TicButton5.Text == "X" && TicButton7.Text == "X")
            {
                TicButton3.BackColor = System.Drawing.Color.DeepPink;
                TicButton5.BackColor = System.Drawing.Color.DeepPink;
                TicButton7.BackColor = System.Drawing.Color.DeepPink;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(PlayerXScore.Text);
                PlayerXScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (TicButton3.Text == "X" && TicButton6.Text == "X" && TicButton9.Text == "X")
            {
                TicButton3.BackColor = System.Drawing.Color.DeepPink;
                TicButton6.BackColor = System.Drawing.Color.DeepPink;
                TicButton9.BackColor = System.Drawing.Color.DeepPink;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(PlayerXScore.Text);
                PlayerXScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (TicButton4.Text == "X" && TicButton5.Text == "X" && TicButton6.Text == "X")
            {
                TicButton4.BackColor = System.Drawing.Color.DeepPink;
                TicButton5.BackColor = System.Drawing.Color.DeepPink;
                TicButton6.BackColor = System.Drawing.Color.DeepPink;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(PlayerXScore.Text);
                PlayerXScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (TicButton7.Text == "X" && TicButton8.Text == "X" && TicButton9.Text == "X")
            {
                TicButton7.BackColor = System.Drawing.Color.DeepPink;
                TicButton8.BackColor = System.Drawing.Color.DeepPink;
                TicButton9.BackColor = System.Drawing.Color.DeepPink;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(PlayerXScore.Text);
                PlayerXScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            //O

            if (TicButton1.Text == "O" && TicButton2.Text == "O" && TicButton3.Text == "O")
            {
                TicButton1.BackColor = System.Drawing.Color.DeepPink;
                TicButton2.BackColor = System.Drawing.Color.DeepPink;
                TicButton3.BackColor = System.Drawing.Color.DeepPink;
                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(PlayerOScore.Text);
                PlayerOScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (TicButton1.Text == "O" && TicButton5.Text == "O" && TicButton9.Text == "O")
            {
                TicButton1.BackColor = System.Drawing.Color.DeepPink;
                TicButton5.BackColor = System.Drawing.Color.DeepPink;
                TicButton9.BackColor = System.Drawing.Color.DeepPink;
                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(PlayerOScore.Text);
                PlayerOScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (TicButton1.Text == "O" && TicButton4.Text == "O" && TicButton7.Text == "O")
            {
                TicButton1.BackColor = System.Drawing.Color.DeepPink;
                TicButton4.BackColor = System.Drawing.Color.DeepPink;
                TicButton7.BackColor = System.Drawing.Color.DeepPink;
                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(PlayerOScore.Text);
                PlayerOScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (TicButton2.Text == "O" && TicButton5.Text == "O" && TicButton8.Text == "O")
            {
                TicButton2.BackColor = System.Drawing.Color.DeepPink;
                TicButton5.BackColor = System.Drawing.Color.DeepPink;
                TicButton8.BackColor = System.Drawing.Color.DeepPink;
                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(PlayerOScore.Text);
                PlayerOScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (TicButton3.Text == "O" && TicButton5.Text == "O" && TicButton7.Text == "O")
            {
                TicButton3.BackColor = System.Drawing.Color.DeepPink;
                TicButton5.BackColor = System.Drawing.Color.DeepPink;
                TicButton7.BackColor = System.Drawing.Color.DeepPink;
                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(PlayerOScore.Text);
                PlayerOScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (TicButton3.Text == "O" && TicButton6.Text == "O" && TicButton9.Text == "O")
            {
                TicButton3.BackColor = System.Drawing.Color.DeepPink;
                TicButton6.BackColor = System.Drawing.Color.DeepPink;
                TicButton9.BackColor = System.Drawing.Color.DeepPink;
                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(PlayerOScore.Text);
                PlayerOScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (TicButton4.Text == "O" && TicButton5.Text == "O" && TicButton6.Text == "O")
            {
                TicButton4.BackColor = System.Drawing.Color.DeepPink;
                TicButton5.BackColor = System.Drawing.Color.DeepPink;
                TicButton6.BackColor = System.Drawing.Color.DeepPink;
                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(PlayerOScore.Text);
                PlayerOScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (TicButton7.Text == "O" && TicButton8.Text == "O" && TicButton9.Text == "O")
            {
                TicButton7.BackColor = System.Drawing.Color.DeepPink;
                TicButton8.BackColor = System.Drawing.Color.DeepPink;
                TicButton9.BackColor = System.Drawing.Color.DeepPink;
                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(PlayerOScore.Text);
                PlayerOScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (TicButton1.Text == "X" && TicButton2.Text == "X" && TicButton3.Text == "O" &&
                TicButton4.Text == "O" && TicButton5.Text == "O" && TicButton6.Text == "X" &&
                TicButton7.Text == "X" && TicButton8.Text == "O" && TicButton9.Text == "X")
            {
                MessageBox.Show("Draw", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_False();
            }

            if (TicButton1.Text == "X" && TicButton2.Text == "O" && TicButton3.Text == "O" &&
               TicButton4.Text == "O" && TicButton5.Text == "X" && TicButton6.Text == "X" &&
               TicButton7.Text == "X" && TicButton8.Text == "O" && TicButton9.Text == "O")
            {
                MessageBox.Show("Draw", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_False();
            }

        }



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                TicButton4.Text = "X";
                checker = true;
                PlayersTurn.Text = "Player O's turn";
            }
            else
            {
                TicButton4.Text = "O";
                checker = false;
                PlayersTurn.Text = "Player X's turn";
            }
            score();
            TicButton4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                TicButton1.Text = "X";
                checker = true;
                PlayersTurn.Text = "Player O's turn";
            }
            else
            {
                TicButton1.Text = "O";
                checker = false;
                PlayersTurn.Text = "Player X's turn";

            }
            score();
            TicButton1.Enabled = false;

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            try {
                TicButton1.Enabled = true;
                TicButton2.Enabled = true;
                TicButton3.Enabled = true;
                TicButton4.Enabled = true;
                TicButton5.Enabled = true;
                TicButton6.Enabled = true;
                TicButton7.Enabled = true;
                TicButton8.Enabled = true;
                TicButton9.Enabled = true;

                TicButton1.Text = "";
                TicButton2.Text = "";
                TicButton3.Text = "";
                TicButton4.Text = "";
                TicButton5.Text = "";
                TicButton6.Text = "";
                TicButton7.Text = "";
                TicButton8.Text = "";
                TicButton9.Text = "";

                NewGameButton.Enabled = true;

                TicButton1.BackColor = Color.WhiteSmoke;
                TicButton2.BackColor = Color.WhiteSmoke;
                TicButton3.BackColor = Color.WhiteSmoke;
                TicButton4.BackColor = Color.WhiteSmoke;
                TicButton5.BackColor = Color.WhiteSmoke;
                TicButton6.BackColor = Color.WhiteSmoke;
                TicButton7.BackColor = Color.WhiteSmoke;
                TicButton8.BackColor = Color.WhiteSmoke;
                TicButton9.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TicButton2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                TicButton2.Text = "X";
                checker = true;
                PlayersTurn.Text = "Player O's turn";
            }
            else
            {
                TicButton2.Text = "O";
                checker = false;
                PlayersTurn.Text = "Player X's turn";
            }
            score();
            TicButton2.Enabled = false;
        }

        private void TicButton3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                TicButton3.Text = "X";
                checker = true;
                PlayersTurn.Text = "Player O's turn";
            }
            else
            {
                TicButton3.Text = "O";
                checker = false;
                PlayersTurn.Text = "Player X's turn";
            }
            score();
            TicButton3.Enabled = false;
        }

        private void TicButton5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                TicButton5.Text = "X";
                checker = true;
                PlayersTurn.Text = "Player O's turn";
            }
            else
            {
                TicButton5.Text = "O";
                checker = false;
                PlayersTurn.Text = "Player X's turn";
            }
            score();
            TicButton5.Enabled = false;
        }

        private void TicButton6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                TicButton6.Text = "X";
                checker = true;
                PlayersTurn.Text = "Player O's turn";
            }
            else
            {
                TicButton6.Text = "O";
                checker = false;
                PlayersTurn.Text = "Player X's turn";
            }
            score();
            TicButton6.Enabled = false;
        }

        private void TicButton7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                TicButton7.Text = "X";
                checker = true;
                PlayersTurn.Text = "Player O's turn";
            }
            else
            {
                TicButton7.Text = "O";
                checker = false;
                PlayersTurn.Text = "Player X's turn";
            }
            score();
            TicButton7.Enabled = false;
        }

        private void TicButton8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                TicButton8.Text = "X";
                checker = true;
                PlayersTurn.Text = "Player O's turn";
            }
            else
            {
                TicButton8.Text = "O";
                checker = false;
                PlayersTurn.Text = "Player X's turn";
            }
            score();
            TicButton8.Enabled = false;
        }

        private void TicButton9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                TicButton9.Text = "X";
                checker = true;
                PlayersTurn.Text = "Player O's turn";

            }
            else
            {
                TicButton9.Text = "O";
                checker = false;
                PlayersTurn.Text = "Player X's turn";

            }
            score();
            TicButton9.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            try { 
            TicButton1.Enabled = true;
            TicButton2.Enabled = true;
            TicButton3.Enabled = true;
            TicButton4.Enabled = true;
            TicButton5.Enabled = true;
            TicButton6.Enabled = true;
            TicButton7.Enabled = true;
            TicButton8.Enabled = true;
            TicButton9.Enabled = true;

            TicButton1.Text = "";
            TicButton2.Text = "";
            TicButton3.Text = "";
            TicButton4.Text = "";
            TicButton5.Text = "";
            TicButton6.Text = "";
            TicButton7.Text = "";
            TicButton8.Text = "";
            TicButton9.Text = "";

            PlayerXScore.Text = "0";
            PlayerOScore.Text = "0";

            TicButton1.BackColor = Color.WhiteSmoke;
            TicButton2.BackColor = Color.WhiteSmoke;
            TicButton3.BackColor = Color.WhiteSmoke;
            TicButton4.BackColor = Color.WhiteSmoke;
            TicButton5.BackColor = Color.WhiteSmoke;
            TicButton6.BackColor = Color.WhiteSmoke;
            TicButton7.BackColor = Color.WhiteSmoke;
            TicButton8.BackColor = Color.WhiteSmoke;
            TicButton9.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Confirm if you want to exit.", "TicTacToe",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (iExit == DialogResult.OK)
                {
                    Application.Exit();
                  
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
