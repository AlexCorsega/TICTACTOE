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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPVP_Click(object sender, EventArgs e)
        {                
            MainUI ui = new MainUI();           
            ui.ShowDialog();
            this.Dispose();
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.BackColor = Color.White;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = Color.MidnightBlue;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnPVC_Click(object sender, EventArgs e)
        {
           PlayerVsComputer pvc = new PlayerVsComputer();                    
            pvc.ShowDialog();
            this.Dispose();
        }
    }
}
