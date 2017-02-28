namespace FNVHasherDLLTestEXE
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
            this.label1 = new System.Windows.Forms.Label();
            this.textToEncode = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fnv24Hex = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fnv32Hex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fnv32HighBitHex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fnv64Hex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fnv64highbitHex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fnv24Decimal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fnv32Decimal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fnv32HighBitDecimal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fnv64Decimal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.fnv64highbitDecimal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.valueToConvert = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.convertedValue = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter text:";
            // 
            // textToEncode
            // 
            this.textToEncode.Location = new System.Drawing.Point(74, 12);
            this.textToEncode.Name = "textToEncode";
            this.textToEncode.Size = new System.Drawing.Size(496, 20);
            this.textToEncode.TabIndex = 1;
            this.textToEncode.Text = "Sim Picker";
            this.textToEncode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fnv24Hex);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.fnv32Hex);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.fnv32HighBitHex);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.fnv64Hex);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fnv64highbitHex);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 194);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hex";
            // 
            // fnv24Hex
            // 
            this.fnv24Hex.Location = new System.Drawing.Point(6, 146);
            this.fnv24Hex.Name = "fnv24Hex";
            this.fnv24Hex.ReadOnly = true;
            this.fnv24Hex.Size = new System.Drawing.Size(264, 20);
            this.fnv24Hex.TabIndex = 9;
            this.fnv24Hex.Click += new System.EventHandler(this.fnv24_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "FNV24 (click on text to copy)";
            // 
            // fnv32Hex
            // 
            this.fnv32Hex.Location = new System.Drawing.Point(276, 95);
            this.fnv32Hex.Name = "fnv32Hex";
            this.fnv32Hex.ReadOnly = true;
            this.fnv32Hex.Size = new System.Drawing.Size(264, 20);
            this.fnv32Hex.TabIndex = 7;
            this.fnv32Hex.Click += new System.EventHandler(this.fnv32Hex_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "FNV32 (click on text to copy)";
            // 
            // fnv32HighBitHex
            // 
            this.fnv32HighBitHex.Location = new System.Drawing.Point(6, 95);
            this.fnv32HighBitHex.Name = "fnv32HighBitHex";
            this.fnv32HighBitHex.ReadOnly = true;
            this.fnv32HighBitHex.Size = new System.Drawing.Size(264, 20);
            this.fnv32HighBitHex.TabIndex = 5;
            this.fnv32HighBitHex.Click += new System.EventHandler(this.fnv32HighBitHex_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "FNV32 High Bit (click on text to copy)";
            // 
            // fnv64Hex
            // 
            this.fnv64Hex.Location = new System.Drawing.Point(276, 42);
            this.fnv64Hex.Name = "fnv64Hex";
            this.fnv64Hex.ReadOnly = true;
            this.fnv64Hex.Size = new System.Drawing.Size(264, 20);
            this.fnv64Hex.TabIndex = 3;
            this.fnv64Hex.Click += new System.EventHandler(this.fnv64Hex_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "FNV64 (click on text to copy)";
            // 
            // fnv64highbitHex
            // 
            this.fnv64highbitHex.Location = new System.Drawing.Point(6, 42);
            this.fnv64highbitHex.Name = "fnv64highbitHex";
            this.fnv64highbitHex.ReadOnly = true;
            this.fnv64highbitHex.Size = new System.Drawing.Size(264, 20);
            this.fnv64highbitHex.TabIndex = 1;
            this.fnv64highbitHex.Click += new System.EventHandler(this.fnv64highbitHex_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "FNV64 High Bit (click on text to copy)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fnv24Decimal);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.fnv32Decimal);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.fnv32HighBitDecimal);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.fnv64Decimal);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.fnv64highbitDecimal);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(12, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 194);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decimal";
            // 
            // fnv24Decimal
            // 
            this.fnv24Decimal.Location = new System.Drawing.Point(6, 146);
            this.fnv24Decimal.Name = "fnv24Decimal";
            this.fnv24Decimal.ReadOnly = true;
            this.fnv24Decimal.Size = new System.Drawing.Size(264, 20);
            this.fnv24Decimal.TabIndex = 9;
            this.fnv24Decimal.Click += new System.EventHandler(this.fnv24Decimal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "FNV24 (click on text to copy)";
            // 
            // fnv32Decimal
            // 
            this.fnv32Decimal.Location = new System.Drawing.Point(276, 95);
            this.fnv32Decimal.Name = "fnv32Decimal";
            this.fnv32Decimal.ReadOnly = true;
            this.fnv32Decimal.Size = new System.Drawing.Size(264, 20);
            this.fnv32Decimal.TabIndex = 7;
            this.fnv32Decimal.Click += new System.EventHandler(this.fnv32Decimal_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "FNV32 (click on text to copy)";
            // 
            // fnv32HighBitDecimal
            // 
            this.fnv32HighBitDecimal.Location = new System.Drawing.Point(6, 95);
            this.fnv32HighBitDecimal.Name = "fnv32HighBitDecimal";
            this.fnv32HighBitDecimal.ReadOnly = true;
            this.fnv32HighBitDecimal.Size = new System.Drawing.Size(264, 20);
            this.fnv32HighBitDecimal.TabIndex = 5;
            this.fnv32HighBitDecimal.Click += new System.EventHandler(this.fnv32HighBitDecimal_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "FNV32 High Bit (click on text to copy)";
            // 
            // fnv64Decimal
            // 
            this.fnv64Decimal.Location = new System.Drawing.Point(276, 42);
            this.fnv64Decimal.Name = "fnv64Decimal";
            this.fnv64Decimal.ReadOnly = true;
            this.fnv64Decimal.Size = new System.Drawing.Size(264, 20);
            this.fnv64Decimal.TabIndex = 3;
            this.fnv64Decimal.Click += new System.EventHandler(this.fnv64Decimal_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(294, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "FNV64 (click on text to copy)";
            // 
            // fnv64highbitDecimal
            // 
            this.fnv64highbitDecimal.Location = new System.Drawing.Point(6, 42);
            this.fnv64highbitDecimal.Name = "fnv64highbitDecimal";
            this.fnv64highbitDecimal.ReadOnly = true;
            this.fnv64highbitDecimal.Size = new System.Drawing.Size(264, 20);
            this.fnv64highbitDecimal.TabIndex = 1;
            this.fnv64highbitDecimal.Click += new System.EventHandler(this.fnv64highbitDecimal_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "FNV64 High Bit (click on text to copy)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.convertedValue);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.valueToConvert);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(576, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 127);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Convert";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(204, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Enter number to convert to hex or decimal";
            // 
            // valueToConvert
            // 
            this.valueToConvert.Location = new System.Drawing.Point(9, 42);
            this.valueToConvert.Name = "valueToConvert";
            this.valueToConvert.Size = new System.Drawing.Size(201, 20);
            this.valueToConvert.TabIndex = 1;
            this.valueToConvert.TextChanged += new System.EventHandler(this.valueToConvert_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Result:";
            // 
            // convertedValue
            // 
            this.convertedValue.Location = new System.Drawing.Point(9, 94);
            this.convertedValue.Name = "convertedValue";
            this.convertedValue.ReadOnly = true;
            this.convertedValue.Size = new System.Drawing.Size(201, 20);
            this.convertedValue.TabIndex = 3;
            this.convertedValue.Click += new System.EventHandler(this.convertedValue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 466);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textToEncode);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "FNVCalculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textToEncode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fnv64highbitHex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fnv64Hex;
        private System.Windows.Forms.TextBox fnv32Hex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fnv32HighBitHex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fnv24Hex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox fnv24Decimal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fnv32Decimal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox fnv32HighBitDecimal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox fnv64Decimal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox fnv64highbitDecimal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox valueToConvert;
        private System.Windows.Forms.TextBox convertedValue;
    }
}

