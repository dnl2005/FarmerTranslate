using ClassLibrary;

namespace Interface
{
    public partial class Form1 : Form
    {
        bool isSelected = false;

        private static string figure = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void clearStyles()
        {
            isSelected = false;

            triangleFigure.BackColor = Color.White;
            triangleFigure.ForeColor = Color.Black;
            rhombusFigure.BackColor = Color.White;
            rhombusFigure.ForeColor = Color.Black;
            squareFigure.BackColor = Color.White;
            squareFigure.ForeColor = Color.Black;
            pentagonFigure.BackColor = Color.White;
            pentagonFigure.ForeColor = Color.Black;
            hexagonFigure.BackColor = Color.White;
            hexagonFigure.ForeColor = Color.Black;
            nangleFigure.BackColor = Color.White;
            nangleFigure.ForeColor = Color.Black;
            rectangleFigure.BackColor = Color.White;
            rectangleFigure.ForeColor = Color.Black;
            circleFigure.BackColor = Color.White;
            circleFigure.ForeColor = Color.Black;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            try
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
                        if (int.TryParse(nangleSides.Text, out sides))
                        {
                            if(sides >= 3)
                            {
                                squareOutput.Text = Farmer.CorNgon(double.Parse(perimeterInput.Text), sides).ToString();
                            }
                            else
                            {
                                MessageBox.Show("Количество сторон должно быть не меньше 3");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Неверный ввод сторон");
                        }
                        break;
                    default:
                        MessageBox.Show("Выберите фигиру");
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка ввода периметра");
            }
        }

        private void triangleFigure_Click(object sender, EventArgs e)
        {
            figure = "triangle";
            clearStyles();
            triangleFigure.BackColor = Color.Teal;
            triangleFigure.ForeColor = Color.White;
        }

        private void rhombusFigure_Click(object sender, EventArgs e)
        {
            figure = "rhombus";
            clearStyles();
            rhombusFigure.BackColor = Color.Teal;
            rhombusFigure.ForeColor = Color.White;
        }

        private void squareFigure_Click(object sender, EventArgs e)
        {
            figure = "square";
            clearStyles();
            squareFigure.BackColor = Color.Teal;
            squareFigure.ForeColor = Color.White;
        }

        private void pentagonFigure_Click(object sender, EventArgs e)
        {
            figure = "pentagon";
            clearStyles();
            pentagonFigure.BackColor = Color.Teal;
            pentagonFigure.ForeColor = Color.White;
        }

        private void rectangleFigure_Click(object sender, EventArgs e)
        {
            figure = "rectangle";
            clearStyles();
            rectangleFigure.BackColor = Color.Teal;
            rectangleFigure.ForeColor = Color.White;
        }

        private void circleFigure_Click(object sender, EventArgs e)
        {
            figure = "circle";
            clearStyles();
            circleFigure.BackColor = Color.Teal;
            circleFigure.ForeColor = Color.White;
        }

        private void hexagonFigure_Click(object sender, EventArgs e)
        {
            figure = "hexagon";
            clearStyles();
            hexagonFigure.BackColor = Color.Teal;
            hexagonFigure.ForeColor = Color.White;
        }

        private void nangleFigure_Click(object sender, EventArgs e)
        {
            figure = "nangle";
            clearStyles();
            nangleFigure.BackColor = Color.Teal;
            nangleFigure.ForeColor = Color.White;
        }
    }
}
