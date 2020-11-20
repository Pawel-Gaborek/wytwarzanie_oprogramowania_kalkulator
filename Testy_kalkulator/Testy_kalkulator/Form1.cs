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
            buttonDecVal_Click(null, null);
            buttonHexVal_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.InitCalc.BackColor = System.Drawing.Color.Green;

            try
            {
                var calc = new Calc();

                if (calc.calcValue != "0")
                {
                    throw new Exception("");
                }

                if (calc.calcType != Calc.CalcType.i64)
                {
                    throw new Exception("");
                }

                if (calc.calcSystem != Calc.CalcSystem.Dec)
                {
                    throw new Exception("");
                }
            }
            catch (Exception)
            {
                this.InitCalc.BackColor = System.Drawing.Color.Red;
            }
        }

        private void buttonDecVal_Click(object sender, EventArgs e)
        {
            this.buttonDecVal.BackColor = System.Drawing.Color.Green;

            try
            {
                var calc = new Calc();
                calc.calcSystem = Calc.CalcSystem.Dec;
                calc.calcType = Calc.CalcType.i64;
                //test pozytywny
                calc.calcValue = "0123456789";
            }
            catch(Exception)
            {
                this.buttonDecVal.BackColor = System.Drawing.Color.Red;
            }
            try
            {
                var calc = new Calc();
                calc.calcSystem = Calc.CalcSystem.Dec;
                calc.calcType = Calc.CalcType.i64;
                //test negatywny
                calc.calcValue = "0ABCDEF";
                if(calc.calcValue != "0")
                {
                    throw new Exception("");
                }
            }
            catch
            {
                this.buttonDecVal.BackColor = System.Drawing.Color.Red;
            }
        }

        private void buttonHexVal_Click(object sender, EventArgs e)
        {
            this.buttonHexVal.BackColor = System.Drawing.Color.Green;
            try
            {
                var calc = new Calc();
                calc.calcSystem = Calc.CalcSystem.Hex;
                calc.calcType = Calc.CalcType.i64;
                //test pozytywny
                calc.calcValue = "0123456789ABCDEF";
            }
            catch(Exception)
            {
                this.buttonHexVal.BackColor = System.Drawing.Color.Red;
            }
        }
    }
}
