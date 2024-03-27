namespace randomNumbers
{
    partial class RandoNumberGenerator
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
            this.components = new System.ComponentModel.Container();
            this.GENERATE = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rangeBeginValue = new System.Windows.Forms.Label();
            this.rangeEndValue = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // GENERATE
            // 
            this.GENERATE.Location = new System.Drawing.Point(140, 45);
            this.GENERATE.Name = "GENERATE";
            this.GENERATE.Size = new System.Drawing.Size(75, 23);
            this.GENERATE.TabIndex = 0;
            this.GENERATE.Text = "GENERATE";
            this.GENERATE.UseVisualStyleBackColor = true;
            this.GENERATE.Click += new System.EventHandler(this.GENERATE_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(240, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // rangeBeginValue
            // 
            this.rangeBeginValue.AutoSize = true;
            this.rangeBeginValue.Location = new System.Drawing.Point(12, 23);
            this.rangeBeginValue.Name = "rangeBeginValue";
            this.rangeBeginValue.Size = new System.Drawing.Size(98, 13);
            this.rangeBeginValue.TabIndex = 3;
            this.rangeBeginValue.Text = "Range Begin value";
            // 
            // rangeEndValue
            // 
            this.rangeEndValue.AutoSize = true;
            this.rangeEndValue.Location = new System.Drawing.Point(237, 23);
            this.rangeEndValue.Name = "rangeEndValue";
            this.rangeEndValue.Size = new System.Drawing.Size(91, 13);
            this.rangeEndValue.TabIndex = 4;
            this.rangeEndValue.Text = "Range End Value";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(124, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(111, 82);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(126, 13);
            this.result.TabIndex = 6;
            this.result.Text = "Random number in range";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RandoNumberGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 148);
            this.Controls.Add(this.result);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.rangeEndValue);
            this.Controls.Add(this.rangeBeginValue);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GENERATE);
            this.Name = "RandoNumberGenerator";
            this.Text = "Random Number Generator";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GENERATE;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label rangeBeginValue;
        private System.Windows.Forms.Label rangeEndValue;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

