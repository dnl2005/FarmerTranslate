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
            { "nangle", perimeter => Farmer.CorNgon(perimeter, sides) }
        };
        
        private static string figure = "";
        private static int sides = int.Parse(new Form1().nangleSides.Text);
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (calculations.TryGetValue(figure, out var calculation))
                {
                    double result = calculation(perimeterInput.Text);
                    squareOutput.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Ошибка выбора фигуры");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
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
            if(!int.TryParse(nangleSides.Text, out sides))
            {
                MessageBox.Show("Введите корректное число сторон\n\nСмотрите справку");
            }
        }
    }
}
