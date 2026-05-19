namespace tictactoe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            label1 = new Label();
            label2 = new Label();
            scoreX = new TextBox();
            scoreO = new TextBox();
            newgame = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn1.Location = new Point(118, 182);
            btn1.Margin = new Padding(4, 3, 4, 3);
            btn1.Name = "btn1";
            btn1.Size = new Size(112, 90);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.Control;
            btn2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn2.Location = new Point(237, 182);
            btn2.Margin = new Padding(4, 3, 4, 3);
            btn2.Name = "btn2";
            btn2.Size = new Size(112, 90);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.Control;
            btn3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn3.Location = new Point(355, 182);
            btn3.Margin = new Padding(4, 3, 4, 3);
            btn3.Name = "btn3";
            btn3.Size = new Size(112, 90);
            btn3.TabIndex = 2;
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.Control;
            btn4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn4.Location = new Point(118, 278);
            btn4.Margin = new Padding(4, 3, 4, 3);
            btn4.Name = "btn4";
            btn4.Size = new Size(112, 90);
            btn4.TabIndex = 3;
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.Control;
            btn5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn5.Location = new Point(237, 278);
            btn5.Margin = new Padding(4, 3, 4, 3);
            btn5.Name = "btn5";
            btn5.Size = new Size(112, 90);
            btn5.TabIndex = 4;
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.Control;
            btn6.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn6.Location = new Point(355, 278);
            btn6.Margin = new Padding(4, 3, 4, 3);
            btn6.Name = "btn6";
            btn6.Size = new Size(112, 90);
            btn6.TabIndex = 5;
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.Control;
            btn7.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn7.Location = new Point(118, 374);
            btn7.Margin = new Padding(4, 3, 4, 3);
            btn7.Name = "btn7";
            btn7.Size = new Size(112, 90);
            btn7.TabIndex = 6;
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.Control;
            btn8.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn8.Location = new Point(237, 374);
            btn8.Margin = new Padding(4, 3, 4, 3);
            btn8.Name = "btn8";
            btn8.Size = new Size(112, 90);
            btn8.TabIndex = 7;
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.Control;
            btn9.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn9.Location = new Point(355, 374);
            btn9.Margin = new Padding(4, 3, 4, 3);
            btn9.Name = "btn9";
            btn9.Size = new Size(112, 90);
            btn9.TabIndex = 8;
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(598, 107);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 23);
            label1.TabIndex = 9;
            label1.Text = "Player X :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(598, 167);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 10;
            label2.Text = "Player O :";
            // 
            // scoreX
            // 
            scoreX.Location = new Point(688, 110);
            scoreX.Name = "scoreX";
            scoreX.ReadOnly = true;
            scoreX.Size = new Size(74, 27);
            scoreX.TabIndex = 11;
            // 
            // scoreO
            // 
            scoreO.Location = new Point(688, 164);
            scoreO.Name = "scoreO";
            scoreO.ReadOnly = true;
            scoreO.Size = new Size(74, 27);
            scoreO.TabIndex = 12;
            // 
            // newgame
            // 
            newgame.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            newgame.Location = new Point(607, 246);
            newgame.Name = "newgame";
            newgame.Size = new Size(155, 55);
            newgame.TabIndex = 13;
            newgame.Text = "NEW GAME";
            newgame.UseVisualStyleBackColor = true;
            newgame.Click += newgame_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sans Serif Collection", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(119, 42);
            label5.Name = "label5";
            label5.Size = new Size(348, 74);
            label5.TabIndex = 16;
            label5.Text = "TIC TAC TOE";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 498);
            Controls.Add(label5);
            Controls.Add(newgame);
            Controls.Add(scoreO);
            Controls.Add(scoreX);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ForeColor = Color.DarkViolet;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "SS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Label label1;
        private Label label2;
        private TextBox scoreX;
        private TextBox scoreO;
        private Button newgame;
        private Label label5;
    }
}
