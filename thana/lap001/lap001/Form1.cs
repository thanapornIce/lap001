namespace lap001
{
    public partial class Form1 : Form
    {
        double num1 = 0.0;
        double num2 = 0.0;
        string operatorlist = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            answer1.Text = "0";
            answer2.Text = "";
            operatorlist = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (answer1.Text == "0")
            { answer1.Text = string.Empty; }
            answer1.Text = answer1.Text + "0";
            answer1.Text = String.Format("{0:#,##0.############}", double.Parse(answer1.Text));
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (answer1.Text == "0")
            { answer1.Text = string.Empty; }
            answer1.Text = answer1.Text + "1";
            answer1.Text = String.Format("{0:#,##0.############}", double.Parse(answer1.Text));
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (answer1.Text == "0")
            { answer1.Text = string.Empty; }
            answer1.Text = answer1.Text + "2";
            answer1.Text = String.Format("{0:#,##0.############}", double.Parse(answer1.Text));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (answer1.Text == "0")
            { answer1.Text = string.Empty; }
            answer1.Text = answer1.Text + "3";
            answer1.Text = String.Format("{0:#,##0.############}", double.Parse(answer1.Text));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (answer1.Text == "0")
            { answer1.Text = string.Empty; }
            answer1.Text = answer1.Text + "4";
            answer1.Text = String.Format("{0:#,##0.############}", double.Parse(answer1.Text));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (answer1.Text == "0")
            { answer1.Text = string.Empty; }
            answer1.Text = answer1.Text + "5";
            answer1.Text = String.Format("{0:#,##0.############}", double.Parse(answer1.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (answer1.Text == "0")
            { answer1.Text = string.Empty; }
            answer1.Text = answer1.Text + "6";
            answer1.Text = String.Format("{0:#,##0.############}", double.Parse(answer1.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (answer1.Text == "0")
            { answer1.Text = string.Empty; }
            answer1.Text = answer1.Text + "7";
            answer1.Text = String.Format("{0:#,##0.############}", double.Parse(answer1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (answer1.Text == "0")
            { answer1.Text = string.Empty; }
            answer1.Text = answer1.Text + "8";
            answer1.Text = String.Format("{0:#,##0.############}", double.Parse(answer1.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (answer1.Text == "0")
            { answer1.Text = string.Empty; }
            answer1.Text = answer1.Text + "9";
            answer1.Text = String.Format("{0:#,##0.############}", double.Parse(answer1.Text));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            answer1.Text = answer1.Text + ".";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(answer1.Text);
            operatorlist = "+";
            answer2.Text = answer1.Text + operatorlist;
            answer1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(answer1.Text);
            operatorlist = "-";
            answer2.Text = answer1.Text + operatorlist;
            answer1.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(answer1.Text);
            operatorlist = "*";
            answer2.Text = answer1.Text + operatorlist;
            answer1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(answer1.Text);
            operatorlist = "/";
            answer2.Text = answer1.Text + operatorlist;
            answer1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(answer1.Text);
            if (operatorlist == "+")
            {
                answer2.Text = num1.ToString() + operatorlist + num2.ToString() + "=";
                answer1.Text = (num1 + num2).ToString();
            }
            if (operatorlist == "-")
            {
                answer2.Text = num1.ToString() + operatorlist + num2.ToString() + "=";

                answer1.Text = (num1 - num2).ToString();
            }
            if (operatorlist == "*")
            {
                answer2.Text = num1.ToString() + operatorlist + num2.ToString() + "=";

                answer1.Text = (num1 * num2).ToString();
            }
            if (operatorlist == "/")
            {
                answer2.Text = num1.ToString() + operatorlist + num2.ToString() + "=";

                answer1.Text = (num1 / num2).ToString();
            }
        }
    }
}