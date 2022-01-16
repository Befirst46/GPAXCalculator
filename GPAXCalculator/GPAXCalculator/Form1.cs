namespace GPAXCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strInput = textBoxGPA.Text;

            double sum = 0.0;

            double dInput = double.Parse(strInput);

            sum = sum + dInput;

            textBoxGPAX.Text = sum.ToString();
        }
    }
}