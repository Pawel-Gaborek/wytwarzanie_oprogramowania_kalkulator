using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kalkulator;

namespace Testy_kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.BackColor = System.Drawing.Color.Green;

            try
            {
                var calc = new Calc();

                if (calc.calcValue != "0")
                {
                    throw new Exception("");
                    //this.button1.BackColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception)
            {
                this.button1.BackColor = System.Drawing.Color.Red;
            }
        }
    }
}
