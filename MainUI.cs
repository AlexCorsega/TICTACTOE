using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TICTACTOE
{
    public partial class MainUI : Form
    {
       static Random rnd = new Random();
        int random = rnd.Next(0, 2);
        string[,] row = new string[3, 3];
        int[] moves = { 0, 0 };
        int turn = 0,turn2=0;
        int d1 = 0,d2=0;

        string[] Players = {"X","O"};
        string winner = "";
        public MainUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            d1 = d2 = 0;
            if (Check() == true)
            {
                button1.Text = Players[turn2];
                CheckWin();
                Checkit();
            }


        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            this.tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
        }

        private void btnTurn_Click(object sender, EventArgs e)
        {
            
        
        }
        bool Check()
        {
            if (row[d1, d2] == null)
            {              
                Display();               
                row[d1, d2] = Players[turn2];
                winner = txtTurn.Text;
                PTurn();
                return true;
            }
            return false;
        }

        bool CheckWin()
        {
            int a = 0,d=0;
            if (moves[0] > 2 || moves[1] > 2)
            {
                if(row[0,0] == row[1,1] && row[0, 0] == row[2, 2])
                {
                    txtTurn.Text = winner;
                    MessageBox.Show(winner + " Wins!");
                    Clear();
                    return true;
                }
                if(row[0, 2] == row[1, 1] && row[0, 2] == row[2, 0])
                {
                    txtTurn.Text = winner;
                    MessageBox.Show(winner + " Wins!");
                    Clear();
                    return true;
                }
                for (int i = 0; i < row.GetLength(0); i++)
                {
                    for (int b = 0; b < row.GetLength(1); b++)
                    {
                        if (row[b, i] == Players[turn2])
                        {
                            a++;
                        }
                        else
                            a--;
                    }
                    if (a == 3)
                    {
                        txtTurn.Text = winner;
                        MessageBox.Show(winner + " Wins!");
                        Clear();
                        return true;
                    }
                    a = 0;
                }
                for (int i = 0; i < row.GetLength(0); i++)
                {
                    for (int b = 0; b < row.GetLength(1); b++)
                    {
                        if (row[i, b] == Players[turn2])
                        {
                            d++;
                        }
                        else
                            d--;
                    }
                    if (d == 3)
                    {
                        txtTurn.Text = winner;
                        MessageBox.Show(winner + " Wins!");
                        Clear();
                        return true;
                    }
                    d = 0;
                }


            }
            return false;
        }
        void Clear()
        {
            MainUI ui = new MainUI();
            this.Dispose();
            ui.ShowDialog();

        }
        void Checkit()
        {
            if (moves[0] == 5 || moves[1] == 5)
            {
                MessageBox.Show("Draw!");
                Clear();
            }
        }
        void Display()
        {
            ++turn2;
            if (turn2 % 2 == 0)
                turn2 = 0;
            else
                turn2 = 1;
        }
        void PTurn()
        {
            if (turn%2 == 1)
            {
                turn = 1;
                txtTurn.Text = "Player 1";
                moves[0]++;
            }
            else
            {
                turn = 2;
                txtTurn.Text = "Player 2";
                moves[1]++;
            }
            turn++;         
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(turn == 0)
            { 
                if (random % 2 == 1)
                {
                    turn = 1;
                    txtTurn.Text = "Player 1";
                }
                else
                {
                    turn = 2;
                    txtTurn.Text = "Player 2";
                }
                turn++;
                button10.Visible = false;
                label2.Visible = true;
                lblP1.Visible = true;
                lblP2.Visible = true;
                tableLayoutPanel1.Visible = true;
                lblTurn.Visible = true;
                txtTurn.Visible = true;
            }
            turn2 = turn;
            PTurn();        
        }

        private void lblP1_VisibleChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            d1 = 0;
            d2 = 2;
            if (Check() == true)
            {
                button3.Text = Players[turn2];
                CheckWin();
                Checkit();
            }
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            d1 = 1;
            d2 = 0;
            if (Check() == true)
            {
                button4.Text = Players[turn2];
                CheckWin();
                Checkit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            d1 = 1;
            d2 = 1;
            if (Check() == true)
            {
                button5.Text = Players[turn2];
                CheckWin();
                Checkit();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            d1 = 1;
            d2 = 2;
            if (Check() == true)
            {
                button6.Text = Players[turn2];
                CheckWin();
                Checkit();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            d1 = 2;
            d2 = 0;
            if (Check() == true)
            {
                button7.Text = Players[turn2];
                CheckWin();
                Checkit();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            d1 = 2;
            d2 = 1;
            if (Check() == true)
            {
                button8.Text = Players[turn2];
                CheckWin();
                Checkit();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            d1 = 2;
            d2 = 2;
            if (Check() == true)
            {
                button9.Text = Players[turn2];
                CheckWin();
                Checkit();
            }
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.MidnightBlue;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.White;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.BackColor = Color.White;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.MidnightBlue;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            
        }

        private void lblP1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            d1 = 0;
            d2 = 1;
            if (Check() == true)
            {
                button2.Text = Players[turn2];
                CheckWin();
                Checkit();
            }
        }
    }
}
