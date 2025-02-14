using ClassLibrary;
using Microsoft.VisualBasic;

namespace Interface
{
    public partial class Form1 : Form
    {
        private static Dictionary<string, Func<string, double>> calculations = new Dictionary<string, Func<string, double>>
        {
            { "triangle", Farmer.CorTriangle },
            { "rhombus", Farmer.Rhombus },
            { "square", Farmer.Square },
            { "pentagon", Farmer.CorPentagon },
            { "rectangle", Farmer.Rectangle },
            { "circle", Farmer.Circle },
            { "hexagon", Farmer.CorHexagon },
            { "nangle", perimeter => Farmer.CorNgon(perimeter, int.Parse(sides)) }
        };

        private static string figure = "";
        private static string sides = new Form1().nangleSides.Text;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(figure))
                {
                    MessageBox.Show("Выберите фигуру");
                    return;
                }

                if (figure == "nangle")
                {
                    if (!int.TryParse(nangleSides.Text, out var sides))
                    {
                        MessageBox.Show("Количество сторон должно быть целым положительным числом, большим 3\n\nСмотрите справку");
                        return;
                    }

                    if (sides < 3)
                    {
                        MessageBox.Show("Количество сторон должно быть больше либо равно 3\n\nСмотрите справку");
                        return;
                    }
                }

                if (calculations.TryGetValue(figure, out var calculation))
                {
                    double result = calculation(perimeterInput.Text);
                    squareOutput.Text = result.ToString();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == Farmer.invalidPerEx)
                {
                    MessageBox.Show("Некорректный ввод периметра\n\nСмотрите справку");
                }
                else if (ex.Message == Farmer.negNullPerEx)
                {
                    MessageBox.Show("Периметер должен быть больше 0\n\nСмотрите справку");
                }
            }
        }

        private void list_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex < calculations.Count)
            {
                var keys = calculations.Keys;
                figure = calculations.ElementAt(listBox1.SelectedIndex).Key;
                ChangeNSidesVis();
            }
        }

        private void ChangeNSidesVis()
        {
            bool isNangle = figure == "nangle";
            this.label2.Visible = isNangle;
            this.nangleSides.Visible = isNangle;
        }

        private void nangleSides_TextChanged(object sender, EventArgs e)
        {
            sides = nangleSides.Text;
        }
    }
}
