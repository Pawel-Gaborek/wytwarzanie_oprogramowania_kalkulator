
namespace Testy_kalkulator
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
            this.InitCalc = new System.Windows.Forms.Button();
            this.buttonDecVal = new System.Windows.Forms.Button();
            this.buttonHexVal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InitCalc
            // 
            this.InitCalc.Location = new System.Drawing.Point(12, 12);
            this.InitCalc.Name = "InitCalc";
            this.InitCalc.Size = new System.Drawing.Size(200, 80);
            this.InitCalc.TabIndex = 0;
            this.InitCalc.Text = "InitCalc";
            this.InitCalc.UseVisualStyleBackColor = true;
            this.InitCalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDecVal
            // 
            this.buttonDecVal.Location = new System.Drawing.Point(12, 184);
            this.buttonDecVal.Name = "buttonDecVal";
            this.buttonDecVal.Size = new System.Drawing.Size(200, 80);
            this.buttonDecVal.TabIndex = 1;
            this.buttonDecVal.Text = "buttonDecVal";
            this.buttonDecVal.UseVisualStyleBackColor = true;
            this.buttonDecVal.Click += new System.EventHandler(this.buttonDecVal_Click);
            // 
            // buttonHexVal
            // 
            this.buttonHexVal.Location = new System.Drawing.Point(12, 98);
            this.buttonHexVal.Name = "buttonHexVal";
            this.buttonHexVal.Size = new System.Drawing.Size(200, 80);
            this.buttonHexVal.TabIndex = 2;
            this.buttonHexVal.Text = "buttonHexVal";
            this.buttonHexVal.UseVisualStyleBackColor = true;
            this.buttonHexVal.Click += new System.EventHandler(this.buttonHexVal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHexVal);
            this.Controls.Add(this.buttonDecVal);
            this.Controls.Add(this.InitCalc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InitCalc;
        private System.Windows.Forms.Button buttonDecVal;
        private System.Windows.Forms.Button buttonHexVal;
    }
}

