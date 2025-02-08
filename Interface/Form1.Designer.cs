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
            nangleFigure = new Button();
            nangleSides = new TextBox();
            label2 = new Label();
            perimeterLabel = new Label();
            squareLabel = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 36F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(299, 39);
            label1.Name = "label1";
            label1.Size = new Size(296, 72);
            label1.TabIndex = 0;
            label1.Text = "Farmer Task";
            // 
            // perimeterInput
            // 
            perimeterInput.Location = new Point(152, 176);
            perimeterInput.Margin = new Padding(3, 4, 3, 4);
            perimeterInput.Name = "perimeterInput";
            perimeterInput.Size = new Size(143, 27);
            perimeterInput.TabIndex = 1;
            perimeterInput.Text = "16";
            // 
            // squareOutput
            // 
            squareOutput.Location = new Point(586, 176);
            squareOutput.Margin = new Padding(3, 4, 3, 4);
            squareOutput.Name = "squareOutput";
            squareOutput.Size = new Size(147, 27);
            squareOutput.TabIndex = 2;
            // 
            // calculate
            // 
            calculate.Location = new Point(374, 167);
            calculate.Margin = new Padding(3, 4, 3, 4);
            calculate.Name = "calculate";
            calculate.Size = new Size(137, 47);
            calculate.TabIndex = 3;
            calculate.Text = "Рассчитать";
            calculate.UseVisualStyleBackColor = true;
            calculate.Click += calculate_Click;
            // 
            // triangleFigure
            // 
            triangleFigure.BackColor = SystemColors.ButtonHighlight;
            triangleFigure.Location = new Point(118, 344);
            triangleFigure.Margin = new Padding(3, 4, 3, 4);
            triangleFigure.Name = "triangleFigure";
            triangleFigure.Size = new Size(137, 47);
            triangleFigure.TabIndex = 4;
            triangleFigure.Text = "Треугольник";
            triangleFigure.UseVisualStyleBackColor = false;
            triangleFigure.Click += triangleFigure_Click;
            // 
            // rhombusFigure
            // 
            rhombusFigure.Location = new Point(299, 344);
            rhombusFigure.Margin = new Padding(3, 4, 3, 4);
            rhombusFigure.Name = "rhombusFigure";
            rhombusFigure.Size = new Size(137, 47);
            rhombusFigure.TabIndex = 5;
            rhombusFigure.Text = "Ромб";
            rhombusFigure.UseVisualStyleBackColor = true;
            rhombusFigure.Click += rhombusFigure_Click;
            // 
            // pentagonFigure
            // 
            pentagonFigure.Location = new Point(459, 344);
            pentagonFigure.Margin = new Padding(3, 4, 3, 4);
            pentagonFigure.Name = "pentagonFigure";
            pentagonFigure.Size = new Size(137, 47);
            pentagonFigure.TabIndex = 6;
            pentagonFigure.Text = "Пятиугольник";
            pentagonFigure.UseVisualStyleBackColor = true;
            pentagonFigure.Click += pentagonFigure_Click;
            // 
            // rectangleFigure
            // 
            rectangleFigure.Location = new Point(632, 344);
            rectangleFigure.Margin = new Padding(3, 4, 3, 4);
            rectangleFigure.Name = "rectangleFigure";
            rectangleFigure.Size = new Size(137, 47);
            rectangleFigure.TabIndex = 7;
            rectangleFigure.Text = "Прямоугольник";
            rectangleFigure.UseVisualStyleBackColor = true;
            rectangleFigure.Click += rectangleFigure_Click;
            // 
            // circleFigure
            // 
            circleFigure.Location = new Point(374, 429);
            circleFigure.Margin = new Padding(3, 4, 3, 4);
            circleFigure.Name = "circleFigure";
            circleFigure.Size = new Size(137, 47);
            circleFigure.TabIndex = 9;
            circleFigure.Text = "Круг";
            circleFigure.UseVisualStyleBackColor = true;
            circleFigure.Click += circleFigure_Click;
            // 
            // squareFigure
            // 
            squareFigure.Location = new Point(202, 429);
            squareFigure.Margin = new Padding(3, 4, 3, 4);
            squareFigure.Name = "squareFigure";
            squareFigure.Size = new Size(137, 47);
            squareFigure.TabIndex = 10;
            squareFigure.Text = "Квадрат";
            squareFigure.UseVisualStyleBackColor = true;
            squareFigure.Click += squareFigure_Click;
            // 
            // hexagonFigure
            // 
            hexagonFigure.Location = new Point(541, 429);
            hexagonFigure.Margin = new Padding(3, 4, 3, 4);
            hexagonFigure.Name = "hexagonFigure";
            hexagonFigure.Size = new Size(137, 47);
            hexagonFigure.TabIndex = 11;
            hexagonFigure.Text = "Шестиугольник";
            hexagonFigure.UseVisualStyleBackColor = true;
            hexagonFigure.Click += hexagonFigure_Click;
            // 
            // figureSelect
            // 
            figureSelect.AutoSize = true;
            figureSelect.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            figureSelect.Location = new Point(398, 281);
            figureSelect.Name = "figureSelect";
            figureSelect.Size = new Size(97, 33);
            figureSelect.TabIndex = 12;
            figureSelect.Text = "Фигуры";
            // 
            // nangleFigure
            // 
            nangleFigure.Location = new Point(518, 525);
            nangleFigure.Margin = new Padding(3, 4, 3, 4);
            nangleFigure.Name = "nangleFigure";
            nangleFigure.Size = new Size(97, 31);
            nangleFigure.TabIndex = 13;
            nangleFigure.Text = "N-угольник";
            nangleFigure.UseVisualStyleBackColor = true;
            nangleFigure.Click += nangleFigure_Click;
            // 
            // nangleSides
            // 
            nangleSides.Location = new Point(384, 525);
            nangleSides.Margin = new Padding(3, 4, 3, 4);
            nangleSides.Name = "nangleSides";
            nangleSides.Size = new Size(114, 27);
            nangleSides.TabIndex = 14;
            nangleSides.Text = "3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 531);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 15;
            label2.Text = "Количество углов";
            // 
            // perimeterLabel
            // 
            perimeterLabel.AutoSize = true;
            perimeterLabel.Location = new Point(190, 152);
            perimeterLabel.Name = "perimeterLabel";
            perimeterLabel.Size = new Size(80, 20);
            perimeterLabel.TabIndex = 16;
            perimeterLabel.Text = "Периметр";
            // 
            // squareLabel
            // 
            squareLabel.AutoSize = true;
            squareLabel.Location = new Point(627, 151);
            squareLabel.Name = "squareLabel";
            squareLabel.Size = new Size(73, 20);
            squareLabel.TabIndex = 17;
            squareLabel.Text = "Площадь";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Треугольник", "Ромб", "Пятиугольник", "Прямоугольник", "Квадрат", "Круг", "Шестиугольник" });
            listBox1.Location = new Point(615, 242);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 18;
            listBox1.Click += list_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(listBox1);
            Controls.Add(squareLabel);
            Controls.Add(perimeterLabel);
            Controls.Add(label2);
            Controls.Add(nangleSides);
            Controls.Add(nangleFigure);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Button nangleFigure;
        private TextBox nangleSides;
        private Label label2;
        private Label perimeterLabel;
        private Label squareLabel;
        private ListBox listBox1;
    }
}
