namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            tbxResult = new TextBox();
            tbxEquation = new TextBox();
            tableLayout = new TableLayoutPanel();
            reciprocal = new Button();
            button1 = new Button();
            root = new Button();
            percent = new Button();
            square = new Button();
            backspace = new Button();
            clear = new Button();
            equal = new Button();
            add = new Button();
            sub = new Button();
            mul = new Button();
            dot = new Button();
            toggle = new Button();
            button0 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            div = new Button();
            tableLayout.SuspendLayout();
            SuspendLayout();
            // 
            // tbxResult
            // 
            tbxResult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbxResult.BackColor = Color.Firebrick;
            tbxResult.Font = new Font("Agency FB", 50.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxResult.ForeColor = Color.White;
            tbxResult.Location = new Point(12, 12);
            tbxResult.Multiline = true;
            tbxResult.Name = "tbxResult";
            tbxResult.ReadOnly = true;
            tbxResult.ScrollBars = ScrollBars.Horizontal;
            tbxResult.Size = new Size(390, 126);
            tbxResult.TabIndex = 0;
            tbxResult.TabStop = false;
            tbxResult.Text = "0";
            tbxResult.TextAlign = HorizontalAlignment.Right;
            // 
            // tbxEquation
            // 
            tbxEquation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbxEquation.BackColor = Color.Firebrick;
            tbxEquation.BorderStyle = BorderStyle.None;
            tbxEquation.Font = new Font("Agency FB", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxEquation.ForeColor = Color.LightGray;
            tbxEquation.Location = new Point(25, 94);
            tbxEquation.Multiline = true;
            tbxEquation.Name = "tbxEquation";
            tbxEquation.ReadOnly = true;
            tbxEquation.Size = new Size(364, 33);
            tbxEquation.TabIndex = 1;
            tbxEquation.TabStop = false;
            tbxEquation.TextAlign = HorizontalAlignment.Right;
            // 
            // tableLayout
            // 
            tableLayout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayout.BackColor = Color.Transparent;
            tableLayout.ColumnCount = 4;
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayout.Controls.Add(reciprocal, 2, 1);
            tableLayout.Controls.Add(button1, 0, 4);
            tableLayout.Controls.Add(root, 1, 1);
            tableLayout.Controls.Add(percent, 2, 0);
            tableLayout.Controls.Add(square, 0, 1);
            tableLayout.Controls.Add(backspace, 1, 0);
            tableLayout.Controls.Add(clear, 0, 0);
            tableLayout.Controls.Add(equal, 3, 4);
            tableLayout.Controls.Add(add, 3, 3);
            tableLayout.Controls.Add(sub, 3, 2);
            tableLayout.Controls.Add(mul, 3, 1);
            tableLayout.Controls.Add(dot, 2, 5);
            tableLayout.Controls.Add(toggle, 0, 5);
            tableLayout.Controls.Add(button0, 1, 5);
            tableLayout.Controls.Add(button2, 1, 4);
            tableLayout.Controls.Add(button3, 2, 4);
            tableLayout.Controls.Add(button4, 0, 3);
            tableLayout.Controls.Add(button5, 1, 3);
            tableLayout.Controls.Add(button6, 2, 3);
            tableLayout.Controls.Add(button7, 0, 2);
            tableLayout.Controls.Add(button8, 1, 2);
            tableLayout.Controls.Add(button9, 2, 2);
            tableLayout.Controls.Add(div, 3, 0);
            tableLayout.Location = new Point(12, 149);
            tableLayout.Name = "tableLayout";
            tableLayout.RowCount = 6;
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayout.Size = new Size(390, 485);
            tableLayout.TabIndex = 3;
            // 
            // reciprocal
            // 
            reciprocal.BackColor = Color.MistyRose;
            reciprocal.Dock = DockStyle.Fill;
            reciprocal.Font = new Font("Agency FB", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reciprocal.ForeColor = Color.Brown;
            reciprocal.Location = new Point(197, 83);
            reciprocal.Name = "reciprocal";
            reciprocal.Size = new Size(91, 74);
            reciprocal.TabIndex = 24;
            reciprocal.Text = "1/x";
            reciprocal.UseVisualStyleBackColor = false;
            reciprocal.Click += btnExtensions_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MistyRose;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Agency FB", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Brown;
            button1.Location = new Point(3, 323);
            button1.Name = "button1";
            button1.Size = new Size(91, 74);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnDigits_Click;
            // 
            // root
            // 
            root.BackColor = Color.MistyRose;
            root.Dock = DockStyle.Fill;
            root.Font = new Font("Agency FB", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            root.ForeColor = Color.Brown;
            root.Location = new Point(100, 83);
            root.Name = "root";
            root.Size = new Size(91, 74);
            root.TabIndex = 23;
            root.Text = "n!";
            root.UseVisualStyleBackColor = false;
            root.Click += btnExtensions_Click;
            // 
            // percent
            // 
            percent.BackColor = Color.MistyRose;
            percent.Dock = DockStyle.Fill;
            percent.Font = new Font("Agency FB", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            percent.ForeColor = Color.Brown;
            percent.Location = new Point(197, 3);
            percent.Name = "percent";
            percent.Size = new Size(91, 74);
            percent.TabIndex = 21;
            percent.Text = "%";
            percent.UseVisualStyleBackColor = false;
            percent.Click += btnExtensions_Click;
            // 
            // square
            // 
            square.BackColor = Color.MistyRose;
            square.Dock = DockStyle.Fill;
            square.Font = new Font("Agency FB", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            square.ForeColor = Color.Brown;
            square.Location = new Point(3, 83);
            square.Name = "square";
            square.Size = new Size(91, 74);
            square.TabIndex = 22;
            square.Text = "x²";
            square.UseVisualStyleBackColor = false;
            square.Click += btnExtensions_Click;
            // 
            // backspace
            // 
            backspace.BackColor = Color.MistyRose;
            backspace.Dock = DockStyle.Fill;
            backspace.Font = new Font("Agency FB", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backspace.ForeColor = Color.Brown;
            backspace.Image = (Image)resources.GetObject("backspace.Image");
            backspace.Location = new Point(100, 3);
            backspace.Name = "backspace";
            backspace.Size = new Size(91, 74);
            backspace.TabIndex = 20;
            backspace.UseVisualStyleBackColor = false;
            backspace.Click += btnBackspace_Click;
            // 
            // clear
            // 
            clear.BackColor = Color.Brown;
            clear.Dock = DockStyle.Fill;
            clear.Font = new Font("Agency FB", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clear.ForeColor = Color.MistyRose;
            clear.Location = new Point(3, 3);
            clear.Name = "clear";
            clear.Size = new Size(91, 74);
            clear.TabIndex = 19;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = false;
            clear.Click += btnClear_Click;
            // 
            // equal
            // 
            equal.BackColor = Color.Brown;
            equal.Dock = DockStyle.Fill;
            equal.Font = new Font("Agency FB", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            equal.ForeColor = Color.MistyRose;
            equal.Location = new Point(294, 323);
            equal.Name = "equal";
            tableLayout.SetRowSpan(equal, 2);
            equal.Size = new Size(93, 159);
            equal.TabIndex = 18;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = false;
            equal.Click += btnEquals_Click;
            // 
            // add
            // 
            add.BackColor = Color.MistyRose;
            add.Dock = DockStyle.Fill;
            add.Font = new Font("Agency FB", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add.ForeColor = Color.Brown;
            add.Location = new Point(294, 243);
            add.Name = "add";
            add.Size = new Size(93, 74);
            add.TabIndex = 17;
            add.Text = "+";
            add.UseVisualStyleBackColor = false;
            add.Click += btnOperators_Click;
            // 
            // sub
            // 
            sub.BackColor = Color.MistyRose;
            sub.Dock = DockStyle.Fill;
            sub.Font = new Font("Agency FB", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sub.ForeColor = Color.Brown;
            sub.Location = new Point(294, 163);
            sub.Name = "sub";
            sub.Size = new Size(93, 74);
            sub.TabIndex = 16;
            sub.Text = "-";
            sub.UseVisualStyleBackColor = false;
            sub.Click += btnOperators_Click;
            // 
            // mul
            // 
            mul.BackColor = Color.MistyRose;
            mul.Dock = DockStyle.Fill;
            mul.Font = new Font("Agency FB", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mul.ForeColor = Color.Brown;
            mul.Location = new Point(294, 83);
            mul.Name = "mul";
            mul.Size = new Size(93, 74);
            mul.TabIndex = 15;
            mul.Text = "×";
            mul.UseVisualStyleBackColor = false;
            mul.Click += btnOperators_Click;
            // 
            // dot
            // 
            dot.BackColor = Color.MistyRose;
            dot.Dock = DockStyle.Fill;
            dot.Font = new Font("Agency FB", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dot.ForeColor = Color.Brown;
            dot.Location = new Point(197, 403);
            dot.Name = "dot";
            dot.Size = new Size(91, 79);
            dot.TabIndex = 13;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = false;
            dot.Click += btnDecimal_Click;
            // 
            // toggle
            // 
            toggle.BackColor = Color.MistyRose;
            toggle.Dock = DockStyle.Fill;
            toggle.Font = new Font("Agency FB", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toggle.ForeColor = Color.Brown;
            toggle.Location = new Point(3, 403);
            toggle.Name = "toggle";
            toggle.Size = new Size(91, 79);
            toggle.TabIndex = 12;
            toggle.Text = "+/-";
            toggle.UseVisualStyleBackColor = false;
            toggle.Click += btnToggle_Click;
            // 
            // button0
            // 
            button0.BackColor = Color.MistyRose;
            button0.Dock = DockStyle.Fill;
            button0.Font = new Font("Agency FB", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button0.ForeColor = Color.Brown;
            button0.Location = new Point(100, 403);
            button0.Name = "button0";
            button0.Size = new Size(91, 79);
            button0.TabIndex = 11;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += btnDigits_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MistyRose;
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Agency FB", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Brown;
            button2.Location = new Point(100, 323);
            button2.Name = "button2";
            button2.Size = new Size(91, 74);
            button2.TabIndex = 5;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnDigits_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MistyRose;
            button3.Dock = DockStyle.Fill;
            button3.Font = new Font("Agency FB", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Brown;
            button3.Location = new Point(197, 323);
            button3.Name = "button3";
            button3.Size = new Size(91, 74);
            button3.TabIndex = 4;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnDigits_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.MistyRose;
            button4.Dock = DockStyle.Fill;
            button4.Font = new Font("Agency FB", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Brown;
            button4.Location = new Point(3, 243);
            button4.Name = "button4";
            button4.Size = new Size(91, 74);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnDigits_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.MistyRose;
            button5.Dock = DockStyle.Fill;
            button5.Font = new Font("Agency FB", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Brown;
            button5.Location = new Point(100, 243);
            button5.Name = "button5";
            button5.Size = new Size(91, 74);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += btnDigits_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.MistyRose;
            button6.Dock = DockStyle.Fill;
            button6.Font = new Font("Agency FB", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Brown;
            button6.Location = new Point(197, 243);
            button6.Name = "button6";
            button6.Size = new Size(91, 74);
            button6.TabIndex = 7;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += btnDigits_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.MistyRose;
            button7.Dock = DockStyle.Fill;
            button7.Font = new Font("Agency FB", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Brown;
            button7.Location = new Point(3, 163);
            button7.Name = "button7";
            button7.Size = new Size(91, 74);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += btnDigits_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.MistyRose;
            button8.Dock = DockStyle.Fill;
            button8.Font = new Font("Agency FB", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.Brown;
            button8.Location = new Point(100, 163);
            button8.Name = "button8";
            button8.Size = new Size(91, 74);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += btnDigits_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.MistyRose;
            button9.Dock = DockStyle.Fill;
            button9.Font = new Font("Agency FB", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.Brown;
            button9.Location = new Point(197, 163);
            button9.Name = "button9";
            button9.Size = new Size(91, 74);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += btnDigits_Click;
            // 
            // div
            // 
            div.BackColor = Color.MistyRose;
            div.Dock = DockStyle.Fill;
            div.Font = new Font("Agency FB", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            div.ForeColor = Color.Brown;
            div.Location = new Point(294, 3);
            div.Name = "div";
            div.Size = new Size(93, 74);
            div.TabIndex = 14;
            div.Text = "÷";
            div.UseVisualStyleBackColor = false;
            div.Click += btnOperators_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(414, 646);
            Controls.Add(tableLayout);
            Controls.Add(tbxEquation);
            Controls.Add(tbxResult);
            Name = "Calculator";
            ShowIcon = false;
            tableLayout.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxResult;
        private TextBox tbxEquation;
        private TableLayoutPanel tableLayout;
        private Button button2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button6;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button0;
        private Button toggle;
        private Button button1;
        private Button dot;
        private Button div;
        private Button mul;
        private Button sub;
        private Button add;
        private Button equal;
        private Button clear;
        private Button backspace;
        private Button percent;
        private Button root;
        private Button square;
        private Button reciprocal;
    }
}
