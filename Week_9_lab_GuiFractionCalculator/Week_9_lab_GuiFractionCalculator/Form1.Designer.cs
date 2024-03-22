namespace Week_9_lab_GuiFractionCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textFrac1Numerator = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.radioBtnAdd = new System.Windows.Forms.RadioButton();
            this.radioBtnSubtract = new System.Windows.Forms.RadioButton();
            this.radioBtnMultiply = new System.Windows.Forms.RadioButton();
            this.radioBtnDivide = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textFrac1Denominator = new System.Windows.Forms.TextBox();
            this.textFrac2Denominator = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textFrac2Numerator = new System.Windows.Forms.TextBox();
            this.txtResultDenominator = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtResultNumerator = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.simplifyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textFrac1Numerator
            // 
            this.textFrac1Numerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFrac1Numerator.Location = new System.Drawing.Point(34, 160);
            this.textFrac1Numerator.Name = "textFrac1Numerator";
            this.textFrac1Numerator.Size = new System.Drawing.Size(106, 39);
            this.textFrac1Numerator.TabIndex = 0;
            this.textFrac1Numerator.TextChanged += new System.EventHandler(this.textFrac1Numerator_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "First";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "/";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(70, 314);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(900, 49);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Perform Operation";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // radioBtnAdd
            // 
            this.radioBtnAdd.AutoSize = true;
            this.radioBtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnAdd.Location = new System.Drawing.Point(316, 79);
            this.radioBtnAdd.Name = "radioBtnAdd";
            this.radioBtnAdd.Size = new System.Drawing.Size(56, 36);
            this.radioBtnAdd.TabIndex = 2;
            this.radioBtnAdd.TabStop = true;
            this.radioBtnAdd.Text = "+";
            this.radioBtnAdd.UseVisualStyleBackColor = true;
            this.radioBtnAdd.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioBtnSubtract
            // 
            this.radioBtnSubtract.AutoSize = true;
            this.radioBtnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnSubtract.Location = new System.Drawing.Point(316, 130);
            this.radioBtnSubtract.Name = "radioBtnSubtract";
            this.radioBtnSubtract.Size = new System.Drawing.Size(49, 36);
            this.radioBtnSubtract.TabIndex = 3;
            this.radioBtnSubtract.TabStop = true;
            this.radioBtnSubtract.Text = "-";
            this.radioBtnSubtract.UseVisualStyleBackColor = true;
            this.radioBtnSubtract.CheckedChanged += new System.EventHandler(this.radioBtnSubtract_CheckedChanged);
            // 
            // radioBtnMultiply
            // 
            this.radioBtnMultiply.AutoSize = true;
            this.radioBtnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnMultiply.Location = new System.Drawing.Point(316, 187);
            this.radioBtnMultiply.Name = "radioBtnMultiply";
            this.radioBtnMultiply.Size = new System.Drawing.Size(51, 36);
            this.radioBtnMultiply.TabIndex = 4;
            this.radioBtnMultiply.TabStop = true;
            this.radioBtnMultiply.Text = "*";
            this.radioBtnMultiply.UseVisualStyleBackColor = true;
            this.radioBtnMultiply.CheckedChanged += new System.EventHandler(this.radioBtnMultiply_CheckedChanged);
            // 
            // radioBtnDivide
            // 
            this.radioBtnDivide.AutoSize = true;
            this.radioBtnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnDivide.Location = new System.Drawing.Point(316, 245);
            this.radioBtnDivide.Name = "radioBtnDivide";
            this.radioBtnDivide.Size = new System.Drawing.Size(48, 36);
            this.radioBtnDivide.TabIndex = 5;
            this.radioBtnDivide.TabStop = true;
            this.radioBtnDivide.Text = "/";
            this.radioBtnDivide.UseVisualStyleBackColor = true;
            this.radioBtnDivide.CheckedChanged += new System.EventHandler(this.radioBtnDivide_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(391, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Second";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(668, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(715, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "Result";
            // 
            // textFrac1Denominator
            // 
            this.textFrac1Denominator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFrac1Denominator.Location = new System.Drawing.Point(188, 160);
            this.textFrac1Denominator.Name = "textFrac1Denominator";
            this.textFrac1Denominator.Size = new System.Drawing.Size(106, 39);
            this.textFrac1Denominator.TabIndex = 1;
            this.textFrac1Denominator.TextChanged += new System.EventHandler(this.textFrac1Denominator_TextChanged);
            // 
            // textFrac2Denominator
            // 
            this.textFrac2Denominator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFrac2Denominator.Location = new System.Drawing.Point(551, 160);
            this.textFrac2Denominator.Name = "textFrac2Denominator";
            this.textFrac2Denominator.Size = new System.Drawing.Size(106, 39);
            this.textFrac2Denominator.TabIndex = 7;
            this.textFrac2Denominator.TextChanged += new System.EventHandler(this.textFrac2Denominator_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(518, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 32);
            this.label8.TabIndex = 20;
            this.label8.Text = "/";
            // 
            // textFrac2Numerator
            // 
            this.textFrac2Numerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFrac2Numerator.Location = new System.Drawing.Point(397, 160);
            this.textFrac2Numerator.Name = "textFrac2Numerator";
            this.textFrac2Numerator.Size = new System.Drawing.Size(106, 39);
            this.textFrac2Numerator.TabIndex = 6;
            this.textFrac2Numerator.TextChanged += new System.EventHandler(this.textFrac2Numerator_TextChanged);
            // 
            // txtResultDenominator
            // 
            this.txtResultDenominator.Enabled = false;
            this.txtResultDenominator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultDenominator.Location = new System.Drawing.Point(868, 160);
            this.txtResultDenominator.Name = "txtResultDenominator";
            this.txtResultDenominator.Size = new System.Drawing.Size(127, 39);
            this.txtResultDenominator.TabIndex = 24;
            this.txtResultDenominator.TextChanged += new System.EventHandler(this.txtResultDenominator_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(840, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 32);
            this.label9.TabIndex = 23;
            this.label9.Text = "/";
            // 
            // txtResultNumerator
            // 
            this.txtResultNumerator.Enabled = false;
            this.txtResultNumerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultNumerator.Location = new System.Drawing.Point(710, 160);
            this.txtResultNumerator.Name = "txtResultNumerator";
            this.txtResultNumerator.Size = new System.Drawing.Size(122, 39);
            this.txtResultNumerator.TabIndex = 22;
            this.txtResultNumerator.TextChanged += new System.EventHandler(this.txtResultNumerator_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(72, 404);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(898, 44);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // simplifyButton
            // 
            this.simplifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simplifyButton.Location = new System.Drawing.Point(70, 495);
            this.simplifyButton.Name = "simplifyButton";
            this.simplifyButton.Size = new System.Drawing.Size(900, 49);
            this.simplifyButton.TabIndex = 10;
            this.simplifyButton.Text = "Simplify Result";
            this.simplifyButton.UseVisualStyleBackColor = true;
            this.simplifyButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 571);
            this.Controls.Add(this.simplifyButton);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtResultDenominator);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtResultNumerator);
            this.Controls.Add(this.textFrac2Denominator);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textFrac2Numerator);
            this.Controls.Add(this.textFrac1Denominator);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioBtnDivide);
            this.Controls.Add(this.radioBtnMultiply);
            this.Controls.Add(this.radioBtnSubtract);
            this.Controls.Add(this.radioBtnAdd);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textFrac1Numerator);
            this.Name = "Form1";
            this.Text = "Fraction Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFrac1Numerator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RadioButton radioBtnAdd;
        private System.Windows.Forms.RadioButton radioBtnSubtract;
        private System.Windows.Forms.RadioButton radioBtnMultiply;
        private System.Windows.Forms.RadioButton radioBtnDivide;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textFrac1Denominator;
        private System.Windows.Forms.TextBox textFrac2Denominator;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textFrac2Numerator;
        private System.Windows.Forms.TextBox txtResultDenominator;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtResultNumerator;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button simplifyButton;
    }
}

