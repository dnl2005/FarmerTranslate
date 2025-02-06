using ClassLibrary;

namespace Interface
{
    public partial class Form1 : Form
    {
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
                    squareOutput.Text = Farmer.CorTriangle(double.Parse(perimeterInput.Text)).ToString();
                    break;
                case "rhombus":
                    squareOutput.Text = Farmer.Rhombus(double.Parse(perimeterInput.Text)).ToString();
                    break;
                case "square":
                    squareOutput.Text = Farmer.Square(double.Parse(perimeterInput.Text)).ToString();
                    break;
                case "pentagon":
                    squareOutput.Text = Farmer.CorPentagon(double.Parse(perimeterInput.Text)).ToString();
                    break;
                case "rectangle":
                    squareOutput.Text = Farmer.Rectangle(double.Parse(perimeterInput.Text)).ToString();
                    break;
                case "circle":
                    squareOutput.Text = Farmer.Circle(double.Parse(perimeterInput.Text)).ToString();
                    break;
                case "hexagon":
                    squareOutput.Text = Farmer.CorHexagon(double.Parse(perimeterInput.Text)).ToString();
                    break;
                case "nangle":
                    int sides;
                    if(int.TryParse(nangleSides.Text, out sides))
                    {
                        squareOutput.Text = Farmer.CorNgon(double.Parse(perimeterInput.Text), sides).ToString();
                    }
                    else
                    {
                        squareOutput.Text = "-1";
                    }
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

        private void nangleFigure_Click(object sender, EventArgs e)
        {
            figure = "nangle";
        }
    }
}
