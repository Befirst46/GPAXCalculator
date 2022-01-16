namespace GPAXCalculator
{
    public partial class Form1 : Form
    {
        double sum = 0;
        int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strInput = textBoxGPA.Text;
            double dInput = double.Parse(strInput);
            sum = sum + dInput;
            n = n + 1;
            double result = sum / n;
            textBoxGPAX.Text = result.ToString();
            textBoxGPA.Text = result.ToString();
            textBoxGPA.Text

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxGPA.Text = "";
            textBoxGPAX.Text = "";

            sum = 0;
            n = 0;
        }
    }
}