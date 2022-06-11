using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        char turn = 'X';
        sbyte turns = 0;

        public TicTacToe()
        {
            InitializeComponent();
        }

        private void Top1_Click(object sender, EventArgs e)
        {
            if (Top1.Text == "")
            {
                Top1.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }
                if (Top1.Text == "")
                {

                }
                if (Top1.Text == Top2.Text)
                {
                    if (Top2.Text == Top3.Text)
                    {
                        MessageBox.Show(Top1.Text + " have won the game!");
                        Top1.Enabled = false;
                        Top2.Enabled = false;
                        Top3.Enabled = false;
                        Mid1.Enabled = false;
                        Mid2.Enabled = false;
                        Mid3.Enabled = false;
                        Bot1.Enabled = false;
                        Bot2.Enabled = false;
                        Bot3.Enabled = false;
                    }
                }
                if (Top1.Text == Mid2.Text)
                {
                    if (Mid2.Text == Bot3.Text)
                    {
                        MessageBox.Show(Top1.Text + " have won the game!");
                        Top1.Enabled = false;
                        Top2.Enabled = false;
                        Top3.Enabled = false;
                        Mid1.Enabled = false;
                        Mid2.Enabled = false;
                        Mid3.Enabled = false;
                        Bot1.Enabled = false;
                        Bot2.Enabled = false;
                        Bot3.Enabled = false;
                    }
                }
                if (Top1.Text == Mid1.Text)
                {
                    if (Mid1.Text == Bot1.Text)
                    {
                        MessageBox.Show(Top1.Text + " have won the game!");
                        Top1.Enabled = false;
                        Top2.Enabled = false;
                        Top3.Enabled = false;
                        Mid1.Enabled = false;
                        Mid2.Enabled = false;
                        Mid3.Enabled = false;
                        Bot1.Enabled = false;
                        Bot2.Enabled = false;
                        Bot3.Enabled = false;
                    }
                }
            }
            turns++;
            if (turns == 9)
                MessageBox.Show("Draw!");
        }

        private void Top2_Click(object sender, EventArgs e)
        {
            if (Top2.Text == "")
            {
                Top2.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }
                if (Top1.Text == Top2.Text)
                {
                    if (Top2.Text == Top3.Text)
                    {
                        MessageBox.Show(Top2.Text + " have won the game!");
                        Top1.Enabled = false;
                        Top2.Enabled = false;
                        Top3.Enabled = false;
                        Mid1.Enabled = false;
                        Mid2.Enabled = false;
                        Mid3.Enabled = false;
                        Bot1.Enabled = false;
                        Bot2.Enabled = false;
                        Bot3.Enabled = false;
                    }
                }
                if (Mid2.Text == Top2.Text)
                {
                    if (Mid2.Text == Bot2.Text)
                    {
                        MessageBox.Show(Top2.Text + " have won the game!");
                        Top1.Enabled = false;
                        Top2.Enabled = false;
                        Top3.Enabled = false;
                        Mid1.Enabled = false;
                        Mid2.Enabled = false;
                        Mid3.Enabled = false;
                        Bot1.Enabled = false;
                        Bot2.Enabled = false;
                        Bot3.Enabled = false;
                    }
                }
            }
            turns++;
            if (turns == 9)
                MessageBox.Show("Draw!");
        }
        private void Top3_Click(object sender, EventArgs e)
        {
            if (Top3.Text == "")
            {
                Top3.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }
                if (Top3.Text == Top2.Text)
                {
                    if (Top2.Text == Top1.Text)
                    {
                        MessageBox.Show(Top3.Text + " have won the game!");
                        Top1.Enabled = false;
                        Top2.Enabled = false;
                        Top3.Enabled = false;
                        Mid1.Enabled = false;
                        Mid2.Enabled = false;
                        Mid3.Enabled = false;
                        Bot1.Enabled = false;
                        Bot2.Enabled = false;
                        Bot3.Enabled = false;
                    }
                }
                if (Top3.Text == Mid2.Text)
                {
                    if (Mid2.Text == Bot1.Text)
                    {
                        MessageBox.Show(Top3.Text + " have won the game!");
                        Top1.Enabled = false;
                        Top2.Enabled = false;
                        Top3.Enabled = false;
                        Mid1.Enabled = false;
                        Mid2.Enabled = false;
                        Mid3.Enabled = false;
                        Bot1.Enabled = false;
                        Bot2.Enabled = false;
                        Bot3.Enabled = false;
                    }
                }
                if (Top3.Text == Mid3.Text)
                {
                    if (Mid3.Text == Bot3.Text)
                    {
                        MessageBox.Show(Top3.Text + " have won the game!");
                        Top1.Enabled = false;
                        Top2.Enabled = false;
                        Top3.Enabled = false;
                        Mid1.Enabled = false;
                        Mid2.Enabled = false;
                        Mid3.Enabled = false;
                        Bot1.Enabled = false;
                        Bot2.Enabled = false;
                        Bot3.Enabled = false;
                    }
                }
            }
            turns++;
            if (turns == 9)
                MessageBox.Show("Draw!");
        }

        private void Mid1_Click(object sender, EventArgs e)
        {
            if (Mid1.Text == "")
            {
                Mid1.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }
            }
            if (Mid1.Text == Top1.Text)
            {
                if (Top1.Text == Bot1.Text)
                {
                    MessageBox.Show(Mid1.Text + " have won the game!");
                    Top1.Enabled = false;
                    Top2.Enabled = false;
                    Top3.Enabled = false;
                    Mid1.Enabled = false;
                    Mid2.Enabled = false;
                    Mid3.Enabled = false;
                    Bot1.Enabled = false;
                    Bot2.Enabled = false;
                    Bot3.Enabled = false;
                }
            }
            if (Mid1.Text == Mid2.Text)
            {
                if (Mid2.Text == Mid3.Text)
                {
                    MessageBox.Show(Mid1.Text + " have won the game!");
                    Top1.Enabled = false;
                    Top2.Enabled = false;
                    Top3.Enabled = false;
                    Mid1.Enabled = false;
                    Mid2.Enabled = false;
                    Mid3.Enabled = false;
                    Bot1.Enabled = false;
                    Bot2.Enabled = false;
                    Bot3.Enabled = false;
                }
            }
            turns++;
            if (turns == 9)
                MessageBox.Show("Draw!");
        }

        private void Mid2_Click(object sender, EventArgs e)
        {
            if (Mid2.Text == "")
            {
                Mid2.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }
            }
            if (Top1.Text == Mid2.Text)
            {
                if (Mid2.Text == Bot3.Text)
                {
                    MessageBox.Show(Mid2.Text + " have won the game!");
                    Top1.Enabled = false;
                    Top2.Enabled = false;
                    Top3.Enabled = false;
                    Mid1.Enabled = false;
                    Mid2.Enabled = false;
                    Mid3.Enabled = false;
                    Bot1.Enabled = false;
                    Bot2.Enabled = false;
                    Bot3.Enabled = false;
                }
            }
            if (Top2.Text == Mid2.Text)
            {
                if (Mid2.Text == Bot2.Text)
                {
                    MessageBox.Show(Mid2.Text + " have won the game!");
                    Top1.Enabled = false;
                    Top2.Enabled = false;
                    Top3.Enabled = false;
                    Mid1.Enabled = false;
                    Mid2.Enabled = false;
                    Mid3.Enabled = false;
                    Bot1.Enabled = false;
                    Bot2.Enabled = false;
                    Bot3.Enabled = false;
                }
            }
            if (Top3.Text == Mid2.Text)
            {
                if (Mid2.Text == Bot1.Text)
                {
                    MessageBox.Show(Mid2.Text + " have won the game!");
                    Top1.Enabled = false;
                    Top2.Enabled = false;
                    Top3.Enabled = false;
                    Mid1.Enabled = false;
                    Mid2.Enabled = false;
                    Mid3.Enabled = false;
                    Bot1.Enabled = false;
                    Bot2.Enabled = false;
                    Bot3.Enabled = false;
                }
            }
            if (Mid1.Text == Mid2.Text)
            {
                if (Mid2.Text == Mid3.Text)
                {
                    MessageBox.Show(Mid2.Text + " have won the game!");
                    Top1.Enabled = false;
                    Top2.Enabled = false;
                    Top3.Enabled = false;
                    Mid1.Enabled = false;
                    Mid2.Enabled = false;
                    Mid3.Enabled = false;
                    Bot1.Enabled = false;
                    Bot2.Enabled = false;
                    Bot3.Enabled = false;
                }
            }
            turns++;
            if (turns == 9)
                MessageBox.Show("Draw!");
        }

        private void Mid3_Click(object sender, EventArgs e)
        {
            if (Mid3.Text == "")
            {
                Mid3.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }
            }
            if (Top3.Text == Mid3.Text)
            {
                if (Mid3.Text == Bot3.Text)
                {
                    MessageBox.Show(Mid3.Text + " have won the game!");
                    Top1.Enabled = false;
                    Top2.Enabled = false;
                    Top3.Enabled = false;
                    Mid1.Enabled = false;
                    Mid2.Enabled = false;
                    Mid3.Enabled = false;
                    Bot1.Enabled = false;
                    Bot2.Enabled = false;
                    Bot3.Enabled = false;
                }
            }
            if (Mid1.Text == Mid3.Text)
            {
                if (Mid3.Text == Mid2.Text)
                {
                    MessageBox.Show(Mid3.Text + " have won the game!");
                    Top1.Enabled = false;
                    Top2.Enabled = false;
                    Top3.Enabled = false;
                    Mid1.Enabled = false;
                    Mid2.Enabled = false;
                    Mid3.Enabled = false;
                    Bot1.Enabled = false;
                    Bot2.Enabled = false;
                    Bot3.Enabled = false;
                }
            }
            turns++;
            if (turns == 9)
                MessageBox.Show("Draw!");
        }

        private void Bot1_Click(object sender, EventArgs e)
        {
            if (Bot1.Text == "")
            {
                Bot1.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }
            }
            if (Bot1.Text == Mid1.Text)
            {
                if (Mid1.Text == Top1.Text)
                {
                    MessageBox.Show(Bot1.Text + " have won the game!");
                    Top1.Enabled = false;
                    Top2.Enabled = false;
                    Top3.Enabled = false;
                    Mid1.Enabled = false;
                    Mid2.Enabled = false;
                    Mid3.Enabled = false;
                    Bot1.Enabled = false;
                    Bot2.Enabled = false;
                    Bot3.Enabled = false;
                }
            }
            if (Bot1.Text == Mid2.Text)
            {
                if (Mid2.Text == Top3.Text)
                {
                    MessageBox.Show(Bot1.Text + " have won the game!");
                    Top1.Enabled = false;
                    Top2.Enabled = false;
                    Top3.Enabled = false;
                    Mid1.Enabled = false;
                    Mid2.Enabled = false;
                    Mid3.Enabled = false;
                    Bot1.Enabled = false;
                    Bot2.Enabled = false;
                    Bot3.Enabled = false;
                }
            }
            if (Bot1.Text == Bot2.Text)
            {
                if (Bot2.Text == Bot3.Text)
                {
                    MessageBox.Show(Bot1.Text + " have won the game!");
                    Top1.Enabled = false;
                    Top2.Enabled = false;
                    Top3.Enabled = false;
                    Mid1.Enabled = false;
                    Mid2.Enabled = false;
                    Mid3.Enabled = false;
                    Bot1.Enabled = false;
                    Bot2.Enabled = false;
                    Bot3.Enabled = false;
                }
            }
            turns++;
            if (turns == 9)
                MessageBox.Show("Draw!");
        }

        private void Bot2_Click(object sender, EventArgs e)
        {
            if (Bot2.Text == "")
            {
                Bot2.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }
            }
            if (Bot2.Text == Mid2.Text)
            {
                if (Mid2.Text == Top2.Text)
                {
                    MessageBox.Show(Bot2.Text + " have won the game!");
                    Top1.Enabled = false;
                    Top2.Enabled = false;
                    Top3.Enabled = false;
                    Mid1.Enabled = false;
                    Mid2.Enabled = false;
                    Mid3.Enabled = false;
                    Bot1.Enabled = false;
                    Bot2.Enabled = false;
                    Bot3.Enabled = false;
                }
            }
            if (Bot2.Text == Bot1.Text)
            {
                if (Bot1.Text == Bot3.Text)
                {
                    MessageBox.Show(Bot2.Text + " have won the game!");
                    Top1.Enabled = false;
                    Top2.Enabled = false;
                    Top3.Enabled = false;
                    Mid1.Enabled = false;
                    Mid2.Enabled = false;
                    Mid3.Enabled = false;
                    Bot1.Enabled = false;
                    Bot2.Enabled = false;
                    Bot3.Enabled = false;
                }
            }
            turns++;
            if (turns == 9)
                MessageBox.Show("Draw!");
        }

        private void Bot3_Click_1(object sender, EventArgs e)
        {
            if (Bot3.Text == "")
            {
                Bot3.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }
            }
            if (Bot3.Text == Mid3.Text)
            {
                if (Mid3.Text == Top3.Text)
                {
                    MessageBox.Show(Bot3.Text + " have won the game!");
                    Top1.Enabled = false;
                    Top2.Enabled = false;
                    Top3.Enabled = false;
                    Mid1.Enabled = false;
                    Mid2.Enabled = false;
                    Mid3.Enabled = false;
                    Bot1.Enabled = false;
                    Bot2.Enabled = false;
                    Bot3.Enabled = false;
                }
            }
            if (Bot3.Text == Mid2.Text)
            {
                if (Mid2.Text == Top1.Text)
                {
                    MessageBox.Show(Bot3.Text + " have won the game!");
                    Top1.Enabled = false;
                    Top2.Enabled = false;
                    Top3.Enabled = false;
                    Mid1.Enabled = false;
                    Mid2.Enabled = false;
                    Mid3.Enabled = false;
                    Bot1.Enabled = false;
                    Bot2.Enabled = false;
                    Bot3.Enabled = false;
                }
            }
            if (Bot3.Text == Bot2.Text)
            {
                if (Bot2.Text == Bot1.Text)
                {
                    MessageBox.Show(Bot3.Text + " have won the game!");
                    Top1.Enabled = false;
                    Top2.Enabled = false;
                    Top3.Enabled = false;
                    Mid1.Enabled = false;
                    Mid2.Enabled = false;
                    Mid3.Enabled = false;
                    Bot1.Enabled = false;
                    Bot2.Enabled = false;
                    Bot3.Enabled = false;
                }
            }
            turns++;
            if (turns == 9)
                MessageBox.Show("Draw!");

        }
    }
}