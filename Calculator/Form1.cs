namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        Double firstParameter = 0;
        Double secondParameter = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed) || resultValue != 0)
            {
                textBox_Result.Clear();
            }
            
            isOperationPerformed= false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text += button.Text;
            }
            else
            {
                textBox_Result.Text += button.Text;
            }
            
            
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                buttonEquals.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                firstParameter = Double.Parse(textBox_Result.Text);
                labelCurrentOperation.Text = firstParameter + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
            labelCurrentOperation.Text = "";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            secondParameter = Double.Parse(textBox_Result.Text);
            switch(operationPerformed) 
            {
                case "+":
                    resultValue = firstParameter + secondParameter;
                    textBox_Result.Text = resultValue.ToString();
                    break;
                case "-":
                    resultValue = firstParameter - secondParameter;
                    textBox_Result.Text = resultValue.ToString();
                    break;
                case "*":
                    resultValue = firstParameter * secondParameter;
                    textBox_Result.Text = resultValue.ToString();
                    break;
                case "/":
                    resultValue = firstParameter / secondParameter;
                    textBox_Result.Text = resultValue.ToString();
                    break;
                default: break;
            }
            //firstParameter = resultValue;
            resultValue = Double.Parse(textBox_Result.Text);
            labelCurrentOperation.Text += " " + secondParameter.ToString() + " =";
            
        }
    }
}