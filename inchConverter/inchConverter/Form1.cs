namespace inchConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            double input = 0;
            
            try
            {
                input = Convert.ToDouble(inputBox.Text);
            }
            catch
            {
                MessageBox.Show("Geben Sie eine Zahl ein");
                return;
            }

            if (direction.Text == "inch->cm")
            {
                inputBox.Text = Convert.ToString(input * 2.54);
            }
            else if (direction.Text == "cm->inch")
            {
                inputBox.Text = Convert.ToString(input / 2.54);
            }

        }
    }
}