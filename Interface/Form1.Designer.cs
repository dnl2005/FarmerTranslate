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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 36F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(262, 29);
            label1.Name = "label1";
            label1.Size = new Size(238, 57);
            label1.TabIndex = 0;
            label1.Text = "Farmer Task";
            // 
            // perimeterInput
            // 
            perimeterInput.Location = new Point(133, 132);
            perimeterInput.Name = "perimeterInput";
            perimeterInput.Size = new Size(126, 23);
            perimeterInput.TabIndex = 1;
            // 
            // squareOutput
            // 
            squareOutput.Location = new Point(513, 132);
            squareOutput.Name = "squareOutput";
            squareOutput.Size = new Size(129, 23);
            squareOutput.TabIndex = 2;
            // 
            // calculate
            // 
            calculate.Location = new Point(327, 125);
            calculate.Name = "calculate";
            calculate.Size = new Size(120, 35);
            calculate.TabIndex = 3;
            calculate.Text = "Рассчитать";
            calculate.UseVisualStyleBackColor = true;
            calculate.Click += calculate_Click;
            // 
            // triangleFigure
            // 
            triangleFigure.Location = new Point(103, 229);
            triangleFigure.Name = "triangleFigure";
            triangleFigure.Size = new Size(120, 35);
            triangleFigure.TabIndex = 4;
            triangleFigure.Text = "Треугольник";
            triangleFigure.UseVisualStyleBackColor = true;
            triangleFigure.Click += triangleFigure_Click;
            // 
            // rhombusFigure
            // 
            rhombusFigure.Location = new Point(252, 229);
            rhombusFigure.Name = "rhombusFigure";
            rhombusFigure.Size = new Size(120, 35);
            rhombusFigure.TabIndex = 5;
            rhombusFigure.Text = "Ромб";
            rhombusFigure.UseVisualStyleBackColor = true;
            rhombusFigure.Click += rhombusFigure_Click;
            // 
            // pentagonFigure
            // 
            pentagonFigure.Location = new Point(402, 229);
            pentagonFigure.Name = "pentagonFigure";
            pentagonFigure.Size = new Size(120, 35);
            pentagonFigure.TabIndex = 6;
            pentagonFigure.Text = "Пятиугольник";
            pentagonFigure.UseVisualStyleBackColor = true;
            pentagonFigure.Click += pentagonFigure_Click;
            // 
            // rectangleFigure
            // 
            rectangleFigure.Location = new Point(553, 229);
            rectangleFigure.Name = "rectangleFigure";
            rectangleFigure.Size = new Size(120, 35);
            rectangleFigure.TabIndex = 7;
            rectangleFigure.Text = "Прямоугольник";
            rectangleFigure.UseVisualStyleBackColor = true;
            rectangleFigure.Click += rectangleFigure_Click;
            // 
            // circleFigure
            // 
            circleFigure.Location = new Point(327, 293);
            circleFigure.Name = "circleFigure";
            circleFigure.Size = new Size(120, 35);
            circleFigure.TabIndex = 9;
            circleFigure.Text = "Круг";
            circleFigure.UseVisualStyleBackColor = true;
            circleFigure.Click += circleFigure_Click;
            // 
            // squareFigure
            // 
            squareFigure.Location = new Point(177, 293);
            squareFigure.Name = "squareFigure";
            squareFigure.Size = new Size(120, 35);
            squareFigure.TabIndex = 10;
            squareFigure.Text = "Квадрат";
            squareFigure.UseVisualStyleBackColor = true;
            squareFigure.Click += squareFigure_Click;
            // 
            // hexagonFigure
            // 
            hexagonFigure.Location = new Point(473, 293);
            hexagonFigure.Name = "hexagonFigure";
            hexagonFigure.Size = new Size(120, 35);
            hexagonFigure.TabIndex = 11;
            hexagonFigure.Text = "Шестиугольник";
            hexagonFigure.UseVisualStyleBackColor = true;
            hexagonFigure.Click += hexagonFigure_Click;
            // 
            // figureSelect
            // 
            figureSelect.AutoSize = true;
            figureSelect.Location = new Point(359, 187);
            figureSelect.Name = "figureSelect";
            figureSelect.Size = new Size(50, 15);
            figureSelect.TabIndex = 12;
            figureSelect.Text = "Фигуры";
            // 
            // nangleFigure
            // 
            nangleFigure.Location = new Point(453, 365);
            nangleFigure.Name = "nangleFigure";
            nangleFigure.Size = new Size(85, 23);
            nangleFigure.TabIndex = 13;
            nangleFigure.Text = "N-угольник";
            nangleFigure.UseVisualStyleBackColor = true;
            nangleFigure.Click += nangleFigure_Click;
            // 
            // nangleSides
            // 
            nangleSides.Location = new Point(336, 365);
            nangleSides.Name = "nangleSides";
            nangleSides.Size = new Size(100, 23);
            nangleSides.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 369);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 15;
            label2.Text = "Количество углов";
            // 
            // perimeterLabel
            // 
            perimeterLabel.AutoSize = true;
            perimeterLabel.Location = new Point(166, 114);
            perimeterLabel.Name = "perimeterLabel";
            perimeterLabel.Size = new Size(63, 15);
            perimeterLabel.TabIndex = 16;
            perimeterLabel.Text = "Периметр";
            // 
            // squareLabel
            // 
            squareLabel.AutoSize = true;
            squareLabel.Location = new Point(549, 113);
            squareLabel.Name = "squareLabel";
            squareLabel.Size = new Size(59, 15);
            squareLabel.TabIndex = 17;
            squareLabel.Text = "Площадь";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
