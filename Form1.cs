namespace Calculatorr1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String CalTotal;
        int num1;
        int num2;
        String option;
        int result;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + btn3.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + btn8.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + btn9.Text;
        }

        private void btnAddiction_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(Display.Text);

            Display.Clear();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + btn4.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + btn5.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + btn6.Text;
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(Display.Text);

            Display.Clear();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + btn2.Text;
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(Display.Text);

            Display.Clear();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + btn0.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Display.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(Display.Text);

            Display.Clear();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(Display.Text);

            if (option.Equals("+"))
                result = num1 + num2;

            if (option.Equals("-"))
            result = num1 - num2;

            if (option.Equals("*")) 
            result = num1 * num2;

            if (option.Equals("/")) 
            result = num1 / num2;

            Display.Text = result + "";
        }
    }
}