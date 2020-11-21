
namespace Testy_kalkulator
{
    partial class Testy_kalkulator
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
            this.InitCalc = new System.Windows.Forms.Button();
            this.buttonDecVal = new System.Windows.Forms.Button();
            this.buttonHexVal = new System.Windows.Forms.Button();
            this.buttonOctVal = new System.Windows.Forms.Button();
            this.buttonBinVal = new System.Windows.Forms.Button();
            this.buttonBajt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonWord = new System.Windows.Forms.Button();
            this.buttonDword = new System.Windows.Forms.Button();
            this.buttonQword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InitCalc
            // 
            this.InitCalc.Location = new System.Drawing.Point(12, 12);
            this.InitCalc.Name = "InitCalc";
            this.InitCalc.Size = new System.Drawing.Size(150, 60);
            this.InitCalc.TabIndex = 0;
            this.InitCalc.Text = "InitCalc";
            this.InitCalc.UseVisualStyleBackColor = true;
            this.InitCalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDecVal
            // 
            this.buttonDecVal.Location = new System.Drawing.Point(168, 78);
            this.buttonDecVal.Name = "buttonDecVal";
            this.buttonDecVal.Size = new System.Drawing.Size(150, 60);
            this.buttonDecVal.TabIndex = 1;
            this.buttonDecVal.Text = "buttonDecVal";
            this.buttonDecVal.UseVisualStyleBackColor = true;
            this.buttonDecVal.Click += new System.EventHandler(this.buttonDecVal_Click);
            // 
            // buttonHexVal
            // 
            this.buttonHexVal.Location = new System.Drawing.Point(168, 12);
            this.buttonHexVal.Name = "buttonHexVal";
            this.buttonHexVal.Size = new System.Drawing.Size(150, 60);
            this.buttonHexVal.TabIndex = 2;
            this.buttonHexVal.Text = "buttonHexVal";
            this.buttonHexVal.UseVisualStyleBackColor = true;
            this.buttonHexVal.Click += new System.EventHandler(this.buttonHexVal_Click);
            // 
            // buttonOctVal
            // 
            this.buttonOctVal.Location = new System.Drawing.Point(168, 144);
            this.buttonOctVal.Name = "buttonOctVal";
            this.buttonOctVal.Size = new System.Drawing.Size(150, 60);
            this.buttonOctVal.TabIndex = 3;
            this.buttonOctVal.Text = "buttonOctVal";
            this.buttonOctVal.UseVisualStyleBackColor = true;
            this.buttonOctVal.Click += new System.EventHandler(this.buttonOctVal_Click);
            // 
            // buttonBinVal
            // 
            this.buttonBinVal.Location = new System.Drawing.Point(168, 210);
            this.buttonBinVal.Name = "buttonBinVal";
            this.buttonBinVal.Size = new System.Drawing.Size(150, 60);
            this.buttonBinVal.TabIndex = 4;
            this.buttonBinVal.Text = "buttonBinVal";
            this.buttonBinVal.UseVisualStyleBackColor = true;
            this.buttonBinVal.Click += new System.EventHandler(this.buttonBinVal_Click);
            // 
            // buttonBajt
            // 
            this.buttonBajt.Location = new System.Drawing.Point(324, 12);
            this.buttonBajt.Name = "buttonBajt";
            this.buttonBajt.Size = new System.Drawing.Size(150, 60);
            this.buttonBajt.TabIndex = 5;
            this.buttonBajt.Text = "buttonBajt";
            this.buttonBajt.UseVisualStyleBackColor = true;
            this.buttonBajt.Click += new System.EventHandler(this.buttonBajt_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 31);
            this.textBox1.TabIndex = 6;
            // 
            // buttonWord
            // 
            this.buttonWord.Location = new System.Drawing.Point(324, 78);
            this.buttonWord.Name = "buttonWord";
            this.buttonWord.Size = new System.Drawing.Size(150, 60);
            this.buttonWord.TabIndex = 7;
            this.buttonWord.Text = "buttonWord";
            this.buttonWord.UseVisualStyleBackColor = true;
            this.buttonWord.Click += new System.EventHandler(this.buttonWord_Click);
            // 
            // buttonDword
            // 
            this.buttonDword.Location = new System.Drawing.Point(324, 144);
            this.buttonDword.Name = "buttonDword";
            this.buttonDword.Size = new System.Drawing.Size(150, 60);
            this.buttonDword.TabIndex = 8;
            this.buttonDword.Text = "buttonDword";
            this.buttonDword.UseVisualStyleBackColor = true;
            this.buttonDword.Click += new System.EventHandler(this.buttonDword_Click);
            // 
            // buttonQword
            // 
            this.buttonQword.Location = new System.Drawing.Point(324, 210);
            this.buttonQword.Name = "buttonQword";
            this.buttonQword.Size = new System.Drawing.Size(150, 60);
            this.buttonQword.TabIndex = 9;
            this.buttonQword.Text = "buttonQword";
            this.buttonQword.UseVisualStyleBackColor = true;
            this.buttonQword.Click += new System.EventHandler(this.buttonQword_Click);
            // 
            // Testy_kalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 450);
            this.Controls.Add(this.buttonQword);
            this.Controls.Add(this.buttonDword);
            this.Controls.Add(this.buttonWord);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonBajt);
            this.Controls.Add(this.buttonBinVal);
            this.Controls.Add(this.buttonOctVal);
            this.Controls.Add(this.buttonHexVal);
            this.Controls.Add(this.buttonDecVal);
            this.Controls.Add(this.InitCalc);
            this.Name = "Testy_kalkulator";
            this.Text = "Testy_kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InitCalc;
        private System.Windows.Forms.Button buttonDecVal;
        private System.Windows.Forms.Button buttonHexVal;
        private System.Windows.Forms.Button buttonOctVal;
        private System.Windows.Forms.Button buttonBinVal;
        private System.Windows.Forms.Button buttonBajt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonWord;
        private System.Windows.Forms.Button buttonDword;
        private System.Windows.Forms.Button buttonQword;
    }
}

