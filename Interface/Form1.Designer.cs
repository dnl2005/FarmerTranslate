namespace Interface
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            perimeterInput = new TextBox();
            squareOutput = new TextBox();
            calculate = new Button();
            triangleFigure = new Button();
            rhombusFigure = new Button();
            pentagonFigure = new Button();
            rectangleFigure = new Button();
            circleFigure = new Button();
            squareFigure = new Button();
            hexagonFigure = new Button();
            figureSelect = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 36F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(273, 28);
            label1.Name = "label1";
            label1.Size = new Size(238, 57);
            label1.TabIndex = 0;
            label1.Text = "Farmer Task";
            // 
            // perimeterInput
            // 
            perimeterInput.Location = new Point(103, 132);
            perimeterInput.Name = "perimeterInput";
            perimeterInput.Size = new Size(153, 23);
            perimeterInput.TabIndex = 1;
            perimeterInput.TextChanged += perimeterInput_TextChanged;
            // 
            // squareOutput
            // 
            squareOutput.Location = new Point(496, 132);
            squareOutput.Name = "squareOutput";
            squareOutput.Size = new Size(176, 23);
            squareOutput.TabIndex = 2;
            squareOutput.TextChanged += squareOutput_TextChanged;
            // 
            // calculate
            // 
            calculate.Location = new Point(342, 132);
            calculate.Name = "calculate";
            calculate.Size = new Size(75, 23);
            calculate.TabIndex = 3;
            calculate.Text = "Рассчитать";
            calculate.UseVisualStyleBackColor = true;
            calculate.Click += calculate_Click;
            // 
            // triangleFigure
            // 
            triangleFigure.Location = new Point(103, 229);
            triangleFigure.Name = "triangleFigure";
            triangleFigure.Size = new Size(89, 23);
            triangleFigure.TabIndex = 4;
            triangleFigure.Text = "Треугольник";
            triangleFigure.UseVisualStyleBackColor = true;
            triangleFigure.Click += triangleFigure_Click;
            // 
            // rhombusFigure
            // 
            rhombusFigure.Location = new Point(244, 229);
            rhombusFigure.Name = "rhombusFigure";
            rhombusFigure.Size = new Size(75, 23);
            rhombusFigure.TabIndex = 5;
            rhombusFigure.Text = "Ромб";
            rhombusFigure.UseVisualStyleBackColor = true;
            // 
            // pentagonFigure
            // 
            pentagonFigure.Location = new Point(388, 229);
            pentagonFigure.Name = "pentagonFigure";
            pentagonFigure.Size = new Size(94, 23);
            pentagonFigure.TabIndex = 6;
            pentagonFigure.Text = "Пятиугольник";
            pentagonFigure.UseVisualStyleBackColor = true;
            // 
            // rectangleFigure
            // 
            rectangleFigure.Location = new Point(567, 229);
            rectangleFigure.Name = "rectangleFigure";
            rectangleFigure.Size = new Size(105, 23);
            rectangleFigure.TabIndex = 7;
            rectangleFigure.Text = "Прямоугольник";
            rectangleFigure.UseVisualStyleBackColor = true;
            // 
            // circleFigure
            // 
            circleFigure.Location = new Point(332, 293);
            circleFigure.Name = "circleFigure";
            circleFigure.Size = new Size(75, 23);
            circleFigure.TabIndex = 9;
            circleFigure.Text = "Круг";
            circleFigure.UseVisualStyleBackColor = true;
            // 
            // squareFigure
            // 
            squareFigure.Location = new Point(181, 293);
            squareFigure.Name = "squareFigure";
            squareFigure.Size = new Size(75, 23);
            squareFigure.TabIndex = 10;
            squareFigure.Text = "Квадрат";
            squareFigure.UseVisualStyleBackColor = true;
            // 
            // hexagonFigure
            // 
            hexagonFigure.Location = new Point(473, 293);
            hexagonFigure.Name = "hexagonFigure";
            hexagonFigure.Size = new Size(103, 23);
            hexagonFigure.TabIndex = 11;
            hexagonFigure.Text = "Шестиугольник";
            hexagonFigure.UseVisualStyleBackColor = true;
            // 
            // figureSelect
            // 
            figureSelect.AutoSize = true;
            figureSelect.Location = new Point(357, 187);
            figureSelect.Name = "figureSelect";
            figureSelect.Size = new Size(50, 15);
            figureSelect.TabIndex = 12;
            figureSelect.Text = "Фигуры";
            // 
            // button1
            // 
            button1.Location = new Point(462, 365);
            button1.Name = "button1";
            button1.Size = new Size(85, 23);
            button1.TabIndex = 13;
            button1.Text = "N-угольник";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(347, 365);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 369);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 15;
            label2.Text = "Количество углов";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(figureSelect);
            Controls.Add(hexagonFigure);
            Controls.Add(squareFigure);
            Controls.Add(circleFigure);
            Controls.Add(rectangleFigure);
            Controls.Add(pentagonFigure);
            Controls.Add(rhombusFigure);
            Controls.Add(triangleFigure);
            Controls.Add(calculate);
            Controls.Add(squareOutput);
            Controls.Add(perimeterInput);
            Controls.Add(label1);
            Name = "Form1";
            Text = "       ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox perimeterInput;
        private TextBox squareOutput;
        private Button calculate;
        private Button triangleFigure;
        private Button rhombusFigure;
        private Button pentagonFigure;
        private Button rectangleFigure;
        private Button circleFigure;
        private Button squareFigure;
        private Button hexagonFigure;
        private Label figureSelect;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
    }
}
