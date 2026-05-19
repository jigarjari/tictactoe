namespace tictactoe
{
    public partial class Form1 : Form
    {
        Boolean flag = true;
        int x = 0, o = 0;

        void reset()
        {
            btn1.Text = " ";
            btn2.Text = " ";
            btn3.Text = " ";
            btn4.Text = " ";
            btn5.Text = " ";
            btn6.Text = " ";
            btn7.Text = " ";
            btn8.Text = " ";
            btn9.Text = " ";

            btn1.BackColor = Color.LightYellow;
            btn2.BackColor = Color.LightYellow;
            btn3.BackColor = Color.LightYellow;
            btn4.BackColor = Color.LightYellow;
            btn5.BackColor = Color.LightYellow;
            btn6.BackColor = Color.LightYellow;
            btn7.BackColor = Color.LightYellow;
            btn8.BackColor = Color.LightYellow;
            btn9.BackColor = Color.LightYellow;

            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }
        void checkO()
        {
            if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
            {
                btn1.BackColor = Color.Cyan;
                btn2.BackColor = Color.Cyan;
                btn3.BackColor = Color.Cyan;
                o += 1;
                scoreO.Text = o.ToString();
                MessageBox.Show("O WIN \n SCORE O : " + o + " X : " + x);
                reset();
            }
            if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")
            {
                btn4.BackColor = Color.Cyan;
                btn5.BackColor = Color.Cyan;
                btn6.BackColor = Color.Cyan;
                o += 1;
                scoreO.Text = o.ToString();
                MessageBox.Show("O WIN \n SCORE O : " + o + " X : " + x);
                reset();
            }
            if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
            {
                btn7.BackColor = Color.Cyan;
                btn8.BackColor = Color.Cyan;
                btn9.BackColor = Color.Cyan;
                o += 1;
                scoreO.Text = o.ToString();
                MessageBox.Show("O WIN \n SCORE O : " + o + " X : " + x);
                reset();
            }
            if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")
            {
                btn1.BackColor = Color.Cyan;
                btn4.BackColor = Color.Cyan;
                btn7.BackColor = Color.Cyan;
                o += 1;
                scoreO.Text = o.ToString();
                MessageBox.Show("O WIN \n SCORE O : " + o + " X : " + x);
                reset();
            }
            if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
            {
                btn2.BackColor = Color.Cyan;
                btn5.BackColor = Color.Cyan;
                btn8.BackColor = Color.Cyan;
                o += 1;
                scoreO.Text = o.ToString();
                MessageBox.Show("O WIN \n SCORE O : " + o + " X : " + x);
                reset();
            }
            if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
            {
                btn3.BackColor = Color.Cyan;
                btn6.BackColor = Color.Cyan;
                btn9.BackColor = Color.Cyan;
                o += 1;
                scoreO.Text = o.ToString();
                MessageBox.Show("O WIN \n SCORE O : " + o + " X : " + x);
                reset();
            }
            if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
            {
                btn1.BackColor = Color.Cyan;
                btn5.BackColor = Color.Cyan;
                btn9.BackColor = Color.Cyan;
                o += 1;
                scoreO.Text = o.ToString();
                MessageBox.Show("O WIN \n SCORE O : " + o + " X : " + x);
                reset();
            }
            if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                btn3.BackColor = Color.Cyan;
                btn5.BackColor = Color.Cyan;
                btn7.BackColor = Color.Cyan;
                o += 1;
                scoreO.Text = o.ToString();
                MessageBox.Show("O WIN \n SCORE O : " + o + " X : " + x);
                reset();
            }
        }

        void checkX()
        {
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
            {
                btn1.BackColor = Color.Cyan;
                btn2.BackColor = Color.Cyan;
                btn3.BackColor = Color.Cyan;
                x += 1;
                scoreX.Text = x.ToString();
                MessageBox.Show("X WIN \n SCORE O : " + o + " X : " + x);
                reset();
            }
            if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
            {
                btn4.BackColor = Color.Cyan;
                btn5.BackColor = Color.Cyan;
                btn6.BackColor = Color.Cyan;
                x += 1;
                scoreX.Text = x.ToString();
                MessageBox.Show("X WIN \n SCORE O : " + o + " X : " + x);
                reset();
            }
            if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
            {
                btn7.BackColor = Color.Cyan;
                btn8.BackColor = Color.Cyan;
                btn9.BackColor = Color.Cyan;
                x += 1;
                scoreX.Text = x.ToString();
                MessageBox.Show("X WIN \n SCORE O : " + o + " X : " + x);
                reset();
            }
            if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
            {
                btn1.BackColor = Color.Cyan;
                btn4.BackColor = Color.Cyan;
                btn7.BackColor = Color.Cyan;
                x += 1;
                scoreX.Text = x.ToString();
                MessageBox.Show("O WIN \n SCORE O : " + o + " X : " + x);
                reset();
            }
            if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
            {
                btn2.BackColor = Color.Cyan;
                btn5.BackColor = Color.Cyan;
                btn8.BackColor = Color.Cyan;
                x += 1;
                scoreX.Text = x.ToString();
                MessageBox.Show("X WIN \n SCORE O : " + o + " X : " + x);
                reset();
            }
            if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
            {
                btn3.BackColor = Color.Cyan;
                btn6.BackColor = Color.Cyan;
                btn9.BackColor = Color.Cyan;
                x += 1;
                scoreX.Text = x.ToString();
                MessageBox.Show("X WIN \n SCORE O : " + o + " X : " + x);
                reset();
            }
            if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                btn1.BackColor = Color.Cyan;
                btn5.BackColor = Color.Cyan;
                btn9.BackColor = Color.Cyan;
                x += 1;
                scoreX.Text = x.ToString();
                MessageBox.Show("X WIN \n SCORE O : " + o + " X : " + x);
                reset();
            }
            if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                btn3.BackColor = Color.Cyan;
                btn5.BackColor = Color.Cyan;
                btn7.BackColor = Color.Cyan;
                x += 1;
                scoreX.Text = x.ToString();
                MessageBox.Show("X WIN \n SCORE O : " + o + " X : " + x);
                reset();
            }
        }
        public Form1()
        {
            InitializeComponent();
            btn1.BackColor = Color.LightYellow;
            btn2.BackColor = Color.LightYellow;
            btn3.BackColor = Color.LightYellow;
            btn4.BackColor = Color.LightYellow;
            btn5.BackColor = Color.LightYellow;
            btn6.BackColor = Color.LightYellow;
            btn7.BackColor = Color.LightYellow;
            btn8.BackColor = Color.LightYellow;
            btn9.BackColor = Color.LightYellow;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                btn1.Text = "O";
                flag = false;
            }
            else
            {
                btn1.Text = "X";
                flag = true;
            }
            btn1.Enabled = false;
            checkO();
            checkX();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                btn2.Text = "O";
                flag = false;
            }
            else
            {
                btn2.Text = "X";
                flag = true;
            }
            btn2.Enabled = false;
            checkO();
            checkX();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                btn3.Text = "O";
                flag = false;
            }
            else
            {
                btn3.Text = "X";
                flag = true;
            }
            btn3.Enabled = false;
            checkO();
            checkX();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                btn4.Text = "O";
                flag = false;
            }
            else
            {
                btn4.Text = "X";
                flag = true;
            }
            btn4.Enabled = false;
            checkO();
            checkX();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                btn5.Text = "O";
                flag = false;
            }
            else
            {
                btn5.Text = "X";
                flag = true;
            }
            btn5.Enabled = false;
            checkO();
            checkX();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                btn6.Text = "O";
                flag = false;
            }
            else
            {
                btn6.Text = "X";
                flag = true;
            }
            btn6.Enabled = false;
            checkO();
            checkX();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                btn7.Text = "O";
                flag = false;
            }
            else
            {
                btn7.Text = "X";
                flag = true;
            }
            btn7.Enabled = false;
            checkO();
            checkX();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                btn8.Text = "O";
                flag = false;
            }
            else
            {
                btn8.Text = "X";
                flag = true;
            }
            btn8.Enabled = false;
            checkO();
            checkX();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                btn9.Text = "O";
                flag = false;
            }
            else
            {
                btn9.Text = "X";
                flag = true;
            }
            btn9.Enabled = false;
            checkO();
            checkX();
        }

        private void newgame_Click(object sender, EventArgs e)
        {
            if (x > o)
            {
                MessageBox.Show("X WIN THIS GAME");
            }
            else if(x == o)
            {
                MessageBox.Show("THIS GAME IS TIED");
            }
            else
            {
                MessageBox.Show("O WIN THIS GAME");
            }
            reset();
            x = o = 0;
            scoreX.Text = x.ToString();
            scoreO.Text = o.ToString();
        }
    }
}
