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
        
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void Top1_Click(object sender, EventArgs e)
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
        }

        private void Top2_Click(object sender, EventArgs e)
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
        }

        private void Top3_Click(object sender, EventArgs e)
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
        }

        private void Mid1_Click(object sender, EventArgs e)
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

        private void Mid2_Click(object sender, EventArgs e)
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

        private void Mid3_Click(object sender, EventArgs e)
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

        private void Bot1_Click(object sender, EventArgs e)
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

        private void Bot2_Click(object sender, EventArgs e)
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

        private void Bot3_Click(object sender, EventArgs e)
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
    }
}
