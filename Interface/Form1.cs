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
            try
            {
                double per;
                if (!double.TryParse(perimeterInput.Text, out per))
                {
                    throw new Exception();
                }

                if (per < 0)
                {
                    throw new Exception();
                }
                else if (per == 0)
                {
                    MessageBox.Show("������� �������� ���������,\n �������� �� ����");
                }

                switch (figure)
                {
                    case "triangle":
                        squareOutput.Text = perimeterInput.Text == "0" ? "" : Farmer.CorTriangle(perimeterInput.Text).ToString();
                        break;
                    case "rhombus":
                        squareOutput.Text = perimeterInput.Text == "0" ? "" : Farmer.Rhombus(perimeterInput.Text).ToString();
                        break;
                    case "square":
                        squareOutput.Text = perimeterInput.Text == "0" ? "" : Farmer.Square(perimeterInput.Text).ToString();
                        break;
                    case "pentagon":
                        squareOutput.Text = perimeterInput.Text == "0" ? "" : Farmer.CorPentagon(perimeterInput.Text).ToString();
                        break;
                    case "rectangle":
                        squareOutput.Text = perimeterInput.Text == "0" ? "" : Farmer.Rectangle(perimeterInput.Text).ToString();
                        break;
                    case "circle":
                        squareOutput.Text = perimeterInput.Text == "0" ? "" : Farmer.Circle(perimeterInput.Text).ToString();
                        break;
                    case "hexagon":
                        squareOutput.Text = perimeterInput.Text == "0" ? "" : Farmer.CorHexagon(perimeterInput.Text).ToString();
                        break;
                    case "nangle":
                        int sides;
                        if (int.TryParse(nangleSides.Text, out sides))
                        {
                            if (sides >= 3)
                            {
                                squareOutput.Text = perimeterInput.Text == "0" ? "" : Farmer.CorNgon(perimeterInput.Text, sides).ToString();
                            }
                            else if (sides < 0)
                            {
                                MessageBox.Show("Ęîëč÷ĺńňâî óăëîâ íĺ äîëćíî áűňü îňđčöŕňĺëüíűě");
                            }
                            else
                            {
                                MessageBox.Show("Ęîëč÷ĺńňâî óăëîâ äîëćíî áűňü íĺ ěĺíüřĺ 3");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Íĺâĺđíűé ââîä óăëîâ");
                        }
                        break;
                    default:
                        MessageBox.Show("Âűáĺđčňĺ ôčăčđó");
                        break;
                }
            }
            catch
            {
                MessageBox.Show("������ ����� ���������");//error_Catcher();
            }
        }

        // ÄŔËĹĹ ĎĐČĚĹÍĹÍČĹ ŃŇČËČÉ ĎĐČ ÍŔĆŔŇČČ ĘÍÎĎĘČ
        private void list_Click(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0: figure = "triangle"; break;
                case 1: figure = "rhombus"; break;
                case 2: figure = "pentagon"; break;
                case 3: figure = "rectangle"; break;
                case 4: figure = "square"; break;
                case 5: figure = "circle"; break;
                case 6: figure = "hexagon"; break;
                case 7:
                    figure = "nangle";
                    label2.Visible = true;
                    nangleSides.Visible = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
