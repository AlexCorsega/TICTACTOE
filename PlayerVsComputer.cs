using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TICTACTOE
{
    public partial class PlayerVsComputer : Form
    {
       static Random rnd = new Random();
        int random = rnd.Next(0, 2);
        string[] players = { "Player 1", "Computer" };
        string[] signs = { "X", "O" };
        string[,] row = new string[3, 3];
        int[] moves = { 0, 0 };
        int d1 = 0, d2 = 0;
        int forcomputer = 0;
        Button[,] bt = new Button[3,3];
        int tr = 0;
        int ck = 0;
        int passer = 0;
        bool[] cmpcheck = new bool[6];
        bool head = true;
        bool my = false;
        public PlayerVsComputer()
        {
            InitializeComponent();
        }

        private void PlayerVsComputer_Load(object sender, EventArgs e)
        {
            this.tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            bt[0,0] = button1;
            bt[0,1] = button2;
            bt[0,2] = button3;
            bt[1,0] = button4;
            bt[1,1] = button5;
            bt[1,2] = button6;
            bt[2,0] = button7;
            bt[2,1] = button8;
            bt[2,2] = button9;
            for (int i = 0; i < cmpcheck.Length; i++)
            {
                cmpcheck[i] = false;
            }
            if (random == 1)
                head = true;

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

        private void button10_Click(object sender, EventArgs e)
        {
            lblP1.Visible = true;
            lblP2.Visible = true;
            tableLayoutPanel1.Visible = true;
            txtTurn.Visible = true;
            lblTurn.Visible = true;
            label2.Visible = true;
            button10.Visible = false;
            Turn();
        }
        void clear()
        {
            PlayerVsComputer p1 = new PlayerVsComputer();
            this.Dispose();
            p1.ShowDialog();
        }
       void Turn()
        {
            tr = random;
            if (random%2==0)
            {
                txtTurn.Text = players[random];
                moves[0]++;
                random++;
                if (moves[0] >= 3 && moves[0] <= 5)
                {
                    CheckWinner();
                }
                else if (moves[0] == 6)
                {
                    
                    MessageBox.Show("Draw!");
                }
                return;
            }
           
  
            else
            {
                txtTurn.Text = players[random];
                moves[1]++;
                forcomputer = random;
                random--;

                if (moves[1] >= 3 && moves[1] <= 5)
                {
                    CheckWinner();
                }
                else if (moves[1] == 6)
                {
                    MessageBox.Show("Draw!");
                }
                Computer();
                return;
            }
        }
       
        void Brain()
        {
                Random rd = new Random();
                int rand = rd.Next(0, 4);
            passer++;
            if (bt[1,1].Text ==string.Empty)
            {
                bt[1, 1].Text = "O";
                return;
            }
            for (int a = passer; a < 20; a++)
            {            
                    if (rand == 0)
                    {
                        if (bt[0, 0].Text == string.Empty)
                        {
                            bt[0, 0].Text = "O";
                            passer++;
                            return;
                        }
                    }
                    else if (rand == 1)
                    {
                        if (bt[0, 2].Text == string.Empty)
                        {
                            bt[0, 2].Text = "O";
                            passer++;
                            return;
                        }
                    }
                    else if (rand == 2)
                    {
                        if (bt[2, 0].Text == string.Empty)
                        {
                            bt[2, 0].Text = "O";
                            passer++;
                            return;

                        }
                    }
                    else if (rand == 3)
                    {
                        if (bt[2, 2].Text == string.Empty)
                        {
                            bt[2, 2].Text = "O";
                            passer++;
                            return;
                        }
                    }
                    else
                    {
                    continue;
                    }
                
            }
           
                foreach (Button item in bt)
                {
                    if (item.Text == "")
                    {
                        item.Text = "O";
                        break;
                       
                    }
                }
            
        }
        void CheckWinner()
        {
            int win = 0;
            int comwin = 0;
          
            for (int a = 0; a < row.GetLength(0); a++)
            {
                for (int b = 0; b < row.GetLength(1); b++)
                {
                    if (bt[b, a].Text == "X")
                    {
                        win++;                       
                        if (win == 3)
                        {
                            MessageBox.Show("Player 1 Wins!");
                            clear();
                            return;
                        }
                    }
                    else if (bt[b, a].Text == "O")
                    {
                        comwin++;
                       if (comwin == 3)
                        {
                            MessageBox.Show("Computer Wins!");
                            clear();
                            return;
                        }
                    }
                }
                win = comwin = 0;
            }
           

           
            for (int a = 0; a < row.GetLength(0); a++)
            {
                for (int b = 0; b < row.GetLength(1); b++)
                {
                    if (bt[a, b].Text == "X")
                    {
                        win++;
                        if (win == 3)
                        {
                            MessageBox.Show("Player 1 Wins!");
                            clear();
                            return;
                        }
                    }
                    else if (bt[a, b].Text == "O")
                    {
                        comwin++;
                         if (comwin == 3)
                        {
                            MessageBox.Show("Computer Wins!");
                            clear();
                            return;
                        }
                    }
                }
                win = 0;
                comwin = 0;
            }
           

            for (int a = 0; a < 3; a++)
            {
                if (bt[a, a].Text == "X")
                {
                    win++;
                    if (win == 3)
                    {
                        MessageBox.Show("Player 1 Win!");
                        clear();
                        return;
                    }
                }
                 if (bt[a, a].Text == "O")
                {
                    comwin++;                  
                    if (comwin == 3)
                    {
                        MessageBox.Show("Computer Wins!");
                        clear();
                        return;
                    }
                }
            }

            win = 0;
            comwin = 0;
            for (int a = 2,es = 0; a >= 0; a--, es++)
            {
                if (bt[es, a].Text == "X")
                {
                    win++;
                    if (win == 3)
                    {
                        MessageBox.Show("Player 1 Wins!");
                        clear();
                        return;
                    }
                }
                if(bt[es, a].Text == "O")
                {
                    comwin++;
                     if (comwin == 3)
                    {
                        MessageBox.Show("Computer Wins!");
                        clear();
                        return;
                    }
                }
            }
           
           

        }
         async void Computer()
          {
            await Task.Delay(1500);
            int c = 0;
            int d = 0;
            int e = 0;
            
            if (head == true)
            {               
                Brain();              
                Turn();
                head = false;
                return;
            }
            else
            {
                if (moves[0] >= 2)
                {
                    for (int a = 0; a < row.GetLength(0); a++)
                    {
                        for (int b = 0; b < row.GetLength(1); b++)
                        {
                            if (row[b, a] == signs[random])
                            {
                                c++;
                            }
                            if (row[b, a] == null)
                            {
                                d = b;
                            }
                            if (row[b, a] != null)
                                e++;
                        }
                        ck = a;
                        if (c == 2 && cmpcheck[ck] == false && e != 3)
                        {
                            row[d, a] = signs[forcomputer];
                            tr--;
                            Compchek(bt[d, a].TabIndex);
                            Turn();
                            cmpcheck[a] = true;

                            return;
                        }

                        c = 0;
                        e = 0;

                    }

                    for (int a = 0; a < row.GetLength(0); a++)
                    {
                        for (int b = 0; b < row.GetLength(1); b++)
                        {
                            if (row[a, b] == signs[random])
                            {
                                c++;
                            }
                            if (row[a, b] == null)
                                d = b;
                            if (row[a, b] != null)
                                e++;
                        }
                        if (a == 0)
                            ck = 3;
                        else if (a == 1)
                            ck = 4;
                        else if (a == 2)
                            ck = 5;
                        if (c == 2 && cmpcheck[ck] == false && e != 3)
                        {
                            row[a, d] = signs[forcomputer];
                            tr--;
                            Compchek(bt[a, d].TabIndex);
                            Turn();
                            cmpcheck[ck] = true;
                            return;
                        }

                        c = 0;
                        e = 0;
                    }

                    for (int a = 0; a < row.GetLength(0); a++)
                    {
                        if (row[a, a] == signs[random])
                            c++;
                        if (row[a, a] == null)
                            d = a;
                        if (row[a, a] != null)
                            e++;
                    }
                    if (c == 2 && e != 3)
                    {
                        MessageBox.Show("Testsasa");
                        Compchek(bt[d, d].TabIndex);
                        Turn();
                        return;
                    }
                    e = c = 0;
                    int ew = 0;
                    for (int a = 2,ewew=0; a >= 0; a--, ewew++)
                    {
                        if (row[ewew, a] == signs[random])
                            c++;
                        if (row[ewew, a] == null)
                        {
                            d = a;
                            ew = ewew;
                        }
                        if (row[ewew, a] != null)
                            e++;
                    }
                    if (c == 2 && e != 3)
                    {
                        Compchek(bt[ew, d].TabIndex);
                        Turn();
                        return;
                    }

                    Brain();
                    Turn();
                    return;
                }
                else
                {
                    Brain();
                    Turn();
                    return;
                }
            }
        }
        void Compchek(int num)
        {
                if (num == 0 && button1.Text == "")
                {
                    button1.Text = signs[forcomputer];

                }
                else if (num == 1 && button2.Text == "")
                {
                    button2.Text = signs[forcomputer];
                }
                else if (num == 2 && button3.Text == "")
                {
                    button3.Text = signs[forcomputer];
                }
                else if (num == 3 && button4.Text == "")
                {
                    button4.Text = signs[forcomputer];
                }
                else if (num == 4 && button5.Text == "")
                {
                    button5.Text = signs[forcomputer];
                }
                else if (num == 5 && button6.Text == "")
                {
                    button6.Text = signs[forcomputer];
                }
                else if (num == 6 && button7.Text == "")
                {
                    button7.Text = signs[forcomputer];
                }
                else if (num == 7 && button8.Text == "")
                {
                    button8.Text = signs[forcomputer];
                }
                else if (num == 8 && button9.Text == "")
                {
                    button9.Text = signs[forcomputer];
                }
            else
            {
                Brain();
            }
            
        }
        bool Check()
        {
            if (bt[d1, d2].Text == string.Empty)
            {
                return true;
            }
            return false;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.MidnightBlue;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            d1 = 0;
            d2 = 1;
            if (Check() == true)
            {
                button2.Text = signs[tr];
                row[d1, d2] = signs[tr];
                Turn();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            d1 = 0;
            d2 = 2;
            if (Check() == true)
            {
                button3.Text = signs[tr];
                row[d1, d2] = signs[tr];
                Turn();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            d1 = 1;
            d2 = 0;
            if (Check() == true)
            {
                button4.Text = signs[tr];
                row[d1, d2] = signs[tr];
                Turn();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            d1 = 1;
            d2 = 1;
            if (Check() == true)
            {
                button5.Text = signs[tr];
                row[d1, d2] = signs[tr];
                Turn();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            d1 = 1;
            d2 = 2;
            if (Check() == true)
            {
                button6.Text = signs[tr];
                row[d1, d2] = signs[tr];
                Turn();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            d1 = 2;
            d2 = 0;
            if (Check() == true)
            {
                button7.Text = signs[tr];
                row[d1, d2] = signs[tr];
                Turn();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            d1 = 2;
            d2 = 1;
            if (Check() == true)
            {
                button8.Text = signs[tr];
                row[d1, d2] = signs[tr];
                Turn();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            d1 = 2;
            d2 = 2;
            if (Check() == true)
            {
                button9.Text = signs[tr];
                row[d1, d2] = signs[tr];
                Turn();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
     
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            d1 = d2 = 0;
            if(Check() == true)
            {
                button1.Text = signs[tr];
                row[d1, d2] = signs[tr];
                Turn();               
            }
        }
    }
}
