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
            figureSelect = new Label();
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
            perimeterInput.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            perimeterInput.Location = new Point(152, 176);
            perimeterInput.Margin = new Padding(3, 4, 3, 4);
            perimeterInput.Name = "perimeterInput";
            perimeterInput.Size = new Size(143, 38);
            perimeterInput.TabIndex = 1;
            perimeterInput.Text = "16";
            // 
            // squareOutput
            // 
            squareOutput.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            squareOutput.Location = new Point(586, 176);
            squareOutput.Margin = new Padding(3, 4, 3, 4);
            squareOutput.Name = "squareOutput";
            squareOutput.Size = new Size(147, 38);
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
            // figureSelect
            // 
            figureSelect.AutoSize = true;
            figureSelect.Font = new Font("Monotype Corsiva", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            figureSelect.Location = new Point(374, 338);
            figureSelect.Name = "figureSelect";
            figureSelect.Size = new Size(129, 41);
            figureSelect.TabIndex = 12;
            figureSelect.Text = "Фигуры";
            // 
            // nangleSides
            // 
            nangleSides.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nangleSides.Location = new Point(458, 252);
            nangleSides.Margin = new Padding(3, 4, 3, 4);
            nangleSides.Name = "nangleSides";
            nangleSides.Size = new Size(114, 38);
            nangleSides.TabIndex = 14;
            nangleSides.Text = "3";
            nangleSides.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(225, 255);
            label2.Name = "label2";
            label2.Size = new Size(219, 31);
            label2.TabIndex = 15;
            label2.Text = "Количество сторон:";
            label2.Visible = false;
            // 
            // perimeterLabel
            // 
            perimeterLabel.AutoSize = true;
            perimeterLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            perimeterLabel.Location = new Point(162, 140);
            perimeterLabel.Name = "perimeterLabel";
            perimeterLabel.Size = new Size(120, 31);
            perimeterLabel.TabIndex = 16;
            perimeterLabel.Text = "Периметр";
            // 
            // squareLabel
            // 
            squareLabel.AutoSize = true;
            squareLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            squareLabel.Location = new Point(608, 140);
            squareLabel.Name = "squareLabel";
            squareLabel.Size = new Size(111, 31);
            squareLabel.TabIndex = 17;
            squareLabel.Text = "Площадь";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("MS Reference Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 34;
            listBox1.Items.AddRange(new object[] { "Треугольник", "Ромб", "Пятиугольник", "Прямоугольник", "Квадрат", "Круг", "Шестиугольник", "N-угольник" });
            listBox1.Location = new Point(152, 410);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(581, 140);
            listBox1.TabIndex = 18;
            listBox1.Click += list_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(914, 600);
            Controls.Add(listBox1);
            Controls.Add(squareLabel);
            Controls.Add(perimeterLabel);
            Controls.Add(label2);
            Controls.Add(nangleSides);
            Controls.Add(figureSelect);
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
        private Label figureSelect;
        private TextBox nangleSides;
        private Label label2;
        private Label perimeterLabel;
        private Label squareLabel;
        private ListBox listBox1;
    }
}
