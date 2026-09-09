namespace SimpleGradeCal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtScore.Text, out int score) && score >= 0 && score <= 100)
            {
                lblResult.Text = $"Valid score entered: {score}";
            }
            else
            {
                lblResult.Text = "Invalid input. Please enter a whole number from 0 to 100.";
            }

        }
    }
}
