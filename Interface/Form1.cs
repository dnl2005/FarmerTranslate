using ClassLibrary;

namespace Interface
{
    public partial class Form1 : Form
    {
        private static double perimeter;
        private static string figure = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            switch (figure)
            {
                case "triangle":
                    squareOutput.Text = Faremer.CorTriangle(double.Parse(perimeterInput.Text)).ToString();
                    break;
                case "rhombus":
                    squareOutput.Text = Faremer.CorRhombus(double.Parse(perimeterInput.Text)).ToString();
                    break;
                case "square":
                    squareOutput.Text = Faremer.CorSquare(double.Parse(perimeterInput.Text)).ToString();
                    break;
                case "pentagon":
                    squareOutput.Text = Faremer.CorPentagon(double.Parse(perimeterInput.Text)).ToString();
                    break;
                case "rectangle":
                    squareOutput.Text = Faremer.CorRectangle(double.Parse(perimeterInput.Text)).ToString();
                    break;
                case "circle":
                    squareOutput.Text = Faremer.CorCircle(double.Parse(perimeterInput.Text)).ToString();
                    break;
                case "hexagon":
                    squareOutput.Text = Faremer.CorHexagon(double.Parse(perimeterInput.Text)).ToString();
                    break;
            }
        }

        private void triangleFigure_Click(object sender, EventArgs e)
        {
            figure = "triangle";
        }

        private void rhombusFigure_Click(object sender, EventArgs e)
        {
            figure = "rhombus";
        }

        private void squareFigure_Click(object sender, EventArgs e)
        {
            figure = "square";
        }

        private void pentagonFigure_Click(object sender, EventArgs e)
        {
            figure = "pentagon";
        }

        private void rectangleFigure_Click(object sender, EventArgs e)
        {
            figure = "rectangle";
        }

        private void circleFigure_Click(object sender, EventArgs e)
        {
            figure = "circle";
        }

        private void hexagonFigure_Click(object sender, EventArgs e)
        {
            figure = "hexagon";
        }
    }
}
