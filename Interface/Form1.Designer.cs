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
            components = new System.ComponentModel.Container();
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
            toolTip1 = new ToolTip(components);
            help = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 36F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(279, 36);
            label1.Name = "label1";
            label1.Size = new Size(238, 57);
            label1.TabIndex = 0;
            label1.Text = "Farmer Task";
            // 
            // perimeterInput
            // 
            perimeterInput.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            perimeterInput.Location = new Point(116, 134);
            perimeterInput.Margin = new Padding(3, 4, 3, 4);
            perimeterInput.Name = "perimeterInput";
            perimeterInput.Size = new Size(143, 32);
            perimeterInput.TabIndex = 1;
            perimeterInput.Text = "16";
            toolTip1.SetToolTip(perimeterInput, "asdffd");
            // 
            // squareOutput
            // 
            squareOutput.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            squareOutput.Location = new Point(531, 134);
            squareOutput.Name = "squareOutput";
            squareOutput.Size = new Size(143, 32);
            squareOutput.TabIndex = 2;
            // 
            // calculate
            // 
            calculate.Font = new Font("Monotype Corsiva", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            calculate.Location = new Point(333, 129);
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
            figureSelect.Location = new Point(348, 206);
            figureSelect.Name = "figureSelect";
            figureSelect.Size = new Size(103, 33);
            figureSelect.TabIndex = 12;
            figureSelect.Text = "Фигуры";
            // 
            // nangleSides
            // 
            nangleSides.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nangleSides.Location = new Point(434, 385);
            nangleSides.Margin = new Padding(3, 4, 3, 4);
            nangleSides.Name = "nangleSides";
            nangleSides.Size = new Size(94, 32);
            nangleSides.TabIndex = 14;
            nangleSides.Text = "3";
            nangleSides.Visible = false;
            nangleSides.TextChanged += nangleSides_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(234, 387);
            label2.Name = "label2";
            label2.Size = new Size(184, 25);
            label2.TabIndex = 15;
            label2.Text = "Количество сторон:";
            label2.Visible = false;
            // 
            // perimeterLabel
            // 
            perimeterLabel.AutoSize = true;
            perimeterLabel.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            perimeterLabel.Location = new Point(137, 105);
            perimeterLabel.Name = "perimeterLabel";
            perimeterLabel.Size = new Size(94, 25);
            perimeterLabel.TabIndex = 16;
            perimeterLabel.Text = "Периметр";
            // 
            // squareLabel
            // 
            squareLabel.AutoSize = true;
            squareLabel.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            squareLabel.Location = new Point(557, 105);
            squareLabel.Name = "squareLabel";
            squareLabel.Size = new Size(82, 25);
            squareLabel.TabIndex = 17;
            squareLabel.Text = "Площадь";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("MS Reference Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Items.AddRange(new object[] { "Треугольник", "Ромб", "Квадрат", "Пятиугольник", "Прямоугольник", "Круг", "Шестиугольник", "N-угольник" });
            listBox1.Location = new Point(197, 246);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(411, 116);
            listBox1.TabIndex = 18;
            listBox1.Click += list_Click;
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 100;
            toolTip1.AutoPopDelay = 0;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 20;
            // 
            // help
            // 
            help.AutoSize = true;
            help.BackColor = Color.DeepSkyBlue;
            help.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            help.ForeColor = SystemColors.ControlLightLight;
            help.Location = new Point(763, 409);
            help.Name = "help";
            help.Size = new Size(25, 32);
            help.TabIndex = 19;
            help.Text = "?";
            help.TextAlign = ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(help, "1. Выберите фигуру (в случае выбора н-угольника \r\nукажите количество сторон)\r\n\r\n2. Введите периметер. Например: 16 или 16,32 (через запятую)\r\n\r\n3. Нажмите рассчитать");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(800, 450);
            Controls.Add(help);
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
            HelpButton = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
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
        private ToolTip toolTip1;
        private Label help;
    }
}
