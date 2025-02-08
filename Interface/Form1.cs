using ClassLibrary;

namespace Interface
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// переменная выбора фигуры
        /// </summary>
        private static string figure = "";
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// обнуление стилий для дальнейшего выбора кнопки
        /// </summary>
        /*private void clearStyles()
        {
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
        }*/

        /// <summary>
        /// Обработка нажатия кнопки и вычисление площади
        /// </summary>
        private void calculate_Click(object sender, EventArgs e)
        {
              
            try
            {
                double per;
                if (!double.TryParse(perimeterInput.Text, out per))
                {
                    throw new Exception();
                }

                if(per < 0)
                {
                    throw new Exception();
                }
                else if (per == 0)
                {
                    MessageBox.Show("Введите периметр");
                }

                switch (figure)
                {
                    case "triangle":
                        squareOutput.Text = perimeterInput.Text == "0" ? "" : Farmer.CorTriangle(per).ToString();
                        break;
                    case "rhombus":
                        squareOutput.Text = perimeterInput.Text == "0" ? "" : Farmer.Rhombus(per).ToString();
                        break;
                    case "square":
                        squareOutput.Text = perimeterInput.Text == "0" ? "" : Farmer.Square(per).ToString();
                        break;
                    case "pentagon":
                        squareOutput.Text = perimeterInput.Text == "0" ? "" : Farmer.CorPentagon(per).ToString();
                        break;
                    case "rectangle":
                        squareOutput.Text = perimeterInput.Text == "0" ? "" : Farmer.Rectangle(per).ToString();
                        break;
                    case "circle":
                        squareOutput.Text = perimeterInput.Text == "0" ? "" : Farmer.Circle(per).ToString();
                        break;
                    case "hexagon":
                        squareOutput.Text = perimeterInput.Text == "0" ? "" : Farmer.CorHexagon(per).ToString();
                        break;
                    case "nangle":
                        int sides;
                        if (int.TryParse(nangleSides.Text, out sides))
                        {
                            if(sides >= 3)
                            {
                                squareOutput.Text = perimeterInput.Text == "0" ? "" : Farmer.CorNgon(per, sides).ToString();
                            }
                            else if(sides < 0)
                            {
                                MessageBox.Show("Количество углов не должно быть отрицательным");
                            }
                            else
                            {
                                MessageBox.Show("Количество углов должно быть не меньше 3");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Неверный ввод углов");
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

        // ДАЛЕЕ ПРИМЕНЕНИЕ СТИЛИЙ ПРИ НАЖАТИИ КНОПКИ
        private void list_Click(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0: figure = "triangle"; break; case 1: figure = "rhombus"; break; 
                case 2: figure = "pentagon"; break; case 3: figure = "rectangle"; break;
                case 4: figure = "square"; break; case 5: figure = "circle"; break;
                case 6: figure = "hexagon"; break; 
                case 7: 
                    figure = "nangle"; 
                    label2.Visible = true;
                    nangleSides.Visible = true;
                    break;

            }
        } 
        /*private void triangleFigure_Click(object sender, EventArgs e)
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
        *
        private void nangleFigure_Click(object sender, EventArgs e)
        {
            figure = "nangle";
            clearStyles();
            nangleFigure.BackColor = Color.Teal;
            nangleFigure.ForeColor = Color.White;
        }*/
    }
}
