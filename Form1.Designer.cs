namespace Calculatorr1
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
            Display = new TextBox();
            btn7 = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn5 = new Button();
            btn2 = new Button();
            btn6 = new Button();
            btn3 = new Button();
            btnEquals = new Button();
            btnAddiction = new Button();
            btnSubtraction = new Button();
            btnMultiplication = new Button();
            btnDot = new Button();
            btn0 = new Button();
            btnClear = new Button();
            btnDivision = new Button();
            SuspendLayout();
            // 
            // Display
            // 
            Display.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Display.Location = new Point(25, 23);
            Display.Name = "Display";
            Display.Size = new Size(285, 43);
            Display.TabIndex = 0;
            Display.TextChanged += textBox1_TextChanged;
            // 
            // btn7
            // 
            btn7.Location = new Point(25, 103);
            btn7.Name = "btn7";
            btn7.Size = new Size(50, 49);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(25, 180);
            btn4.Name = "btn4";
            btn4.Size = new Size(50, 48);
            btn4.TabIndex = 2;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(25, 270);
            btn1.Name = "btn1";
            btn1.Size = new Size(50, 43);
            btn1.TabIndex = 3;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(101, 103);
            btn8.Name = "btn8";
            btn8.Size = new Size(49, 49);
            btn8.TabIndex = 4;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(184, 103);
            btn9.Name = "btn9";
            btn9.Size = new Size(49, 49);
            btn9.TabIndex = 5;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += button5_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(101, 180);
            btn5.Name = "btn5";
            btn5.Size = new Size(49, 48);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += button6_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(101, 270);
            btn2.Name = "btn2";
            btn2.Size = new Size(49, 43);
            btn2.TabIndex = 7;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(183, 180);
            btn6.Name = "btn6";
            btn6.Size = new Size(50, 48);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += button8_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(183, 270);
            btn3.Name = "btn3";
            btn3.Size = new Size(50, 43);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += button9_Click;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(24, 401);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(209, 31);
            btnEquals.TabIndex = 10;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnAddiction
            // 
            btnAddiction.Location = new Point(261, 103);
            btnAddiction.Name = "btnAddiction";
            btnAddiction.Size = new Size(49, 49);
            btnAddiction.TabIndex = 11;
            btnAddiction.Text = "+";
            btnAddiction.UseVisualStyleBackColor = true;
            btnAddiction.Click += btnAddiction_Click;
            // 
            // btnSubtraction
            // 
            btnSubtraction.Location = new Point(261, 180);
            btnSubtraction.Name = "btnSubtraction";
            btnSubtraction.Size = new Size(49, 48);
            btnSubtraction.TabIndex = 12;
            btnSubtraction.Text = "-";
            btnSubtraction.UseVisualStyleBackColor = true;
            btnSubtraction.Click += btnSubtraction_Click;
            // 
            // btnMultiplication
            // 
            btnMultiplication.Location = new Point(261, 270);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(49, 43);
            btnMultiplication.TabIndex = 13;
            btnMultiplication.Text = "*";
            btnMultiplication.UseVisualStyleBackColor = true;
            btnMultiplication.Click += btnMultiplication_Click;
            // 
            // btnDot
            // 
            btnDot.Location = new Point(29, 339);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(46, 44);
            btnDot.TabIndex = 14;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(101, 339);
            btn0.Name = "btn0";
            btn0.Size = new Size(49, 44);
            btn0.TabIndex = 15;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(183, 339);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(50, 44);
            btnClear.TabIndex = 16;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDivision
            // 
            btnDivision.Location = new Point(261, 339);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(49, 39);
            btnDivision.TabIndex = 17;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 447);
            Controls.Add(btnDivision);
            Controls.Add(btnClear);
            Controls.Add(btn0);
            Controls.Add(btnDot);
            Controls.Add(btnMultiplication);
            Controls.Add(btnSubtraction);
            Controls.Add(btnAddiction);
            Controls.Add(btnEquals);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(btn2);
            Controls.Add(btn5);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btn7);
            Controls.Add(Display);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Display;
        private Button btn7;
        private Button btn4;
        private Button btn1;
        private Button btn8;
        private Button btn9;
        private Button btn5;
        private Button btn2;
        private Button btn6;
        private Button btn3;
        private Button btnEquals;
        private Button btnAddiction;
        private Button btnSubtraction;
        private Button btnMultiplication;
        private Button btnDot;
        private Button btn0;
        private Button btnClear;
        private Button btnDivision;
    }
}