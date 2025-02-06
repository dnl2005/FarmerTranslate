namespace Interface
{
    public partial class Form1 : Form
    {
        private static string figure = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void perimeterInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void squareOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            squareOutput.Text = perimeterInput.Text;
        }

        private void triangleFigure_Click(object sender, EventArgs e)
        {

        }
    }
}
