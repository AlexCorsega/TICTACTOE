namespace TICTACTOE
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPVP = new System.Windows.Forms.Button();
            this.btnPVC = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIC TAC TOE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-21, -30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 126);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 116);
            this.label3.TabIndex = 2;
            this.label3.Text = "O";
            // 
            // btnPVP
            // 
            this.btnPVP.BackColor = System.Drawing.Color.Yellow;
            this.btnPVP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPVP.ForeColor = System.Drawing.Color.Black;
            this.btnPVP.Location = new System.Drawing.Point(68, 121);
            this.btnPVP.Name = "btnPVP";
            this.btnPVP.Size = new System.Drawing.Size(186, 45);
            this.btnPVP.TabIndex = 3;
            this.btnPVP.Text = "PLAY WITH FRIENDS";
            this.btnPVP.UseVisualStyleBackColor = false;
            this.btnPVP.Click += new System.EventHandler(this.btnPVP_Click);
            // 
            // btnPVC
            // 
            this.btnPVC.BackColor = System.Drawing.Color.Yellow;
            this.btnPVC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPVC.ForeColor = System.Drawing.Color.Black;
            this.btnPVC.Location = new System.Drawing.Point(68, 198);
            this.btnPVC.Name = "btnPVC";
            this.btnPVC.Size = new System.Drawing.Size(186, 45);
            this.btnPVC.TabIndex = 4;
            this.btnPVC.Text = "PLAY WITH COMPUTER";
            this.btnPVC.UseVisualStyleBackColor = false;
            this.btnPVC.Click += new System.EventHandler(this.btnPVC_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(291, -2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(316, 342);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPVC);
            this.Controls.Add(this.btnPVP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPVP;
        private System.Windows.Forms.Button btnPVC;
        private System.Windows.Forms.Label label4;
    }
}

