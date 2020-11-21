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
    public partial class Testy_kalkulator : Form
    {
        public Testy_kalkulator()
        {
            InitializeComponent();
            button1_Click(null, null);
            buttonDecVal_Click(null, null);
            buttonHexVal_Click(null, null);
            buttonOctVal_Click(null, null);
            buttonBinVal_Click(null, null);
            buttonBajt_Click(null, null);
            buttonWord_Click(null, null);
            buttonDword_Click(null, null);
            buttonQword_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.InitCalc.BackColor = System.Drawing.Color.Yellow;


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
            catch(Exception)
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
            try
            {
                var calc = new Calc();
                calc.calcSystem = Calc.CalcSystem.Hex;
                calc.calcType = Calc.CalcType.i64;
                //test negatywny
                calc.calcValue = "ABCDEK";
                if(calc.calcValue != "A")
                {
                    throw new Exception("");
                }
            }
            catch(Exception)
            {
                this.buttonHexVal.BackColor = System.Drawing.Color.Yellow;
            }
        }

        private void buttonOctVal_Click(object sender, EventArgs e)
        {
            this.buttonOctVal.BackColor = System.Drawing.Color.Green;
            try
            {
                var calc = new Calc();
                calc.calcSystem = Calc.CalcSystem.Oct;
                calc.calcType = Calc.CalcType.i64;
                //scenariusz pozytywny
                calc.calcValue = "01234567";
            }
            catch(Exception)
            {
                this.buttonOctVal.BackColor = System.Drawing.Color.Red;
            }
            try
            {
                var calc = new Calc();
                calc.calcSystem = Calc.CalcSystem.Oct;
                calc.calcType = Calc.CalcType.i64;
                //scenariusz negatywny
                calc.calcValue = "0ABCDEF";
                if (calc.calcValue != "3")
                {
                    throw new Exception("");
                }
            }
            catch(Exception)
            {
                this.buttonOctVal.BackColor = System.Drawing.Color.Red;
            }
        }

        private void buttonBinVal_Click(object sender, EventArgs e)
        {
            this.buttonBinVal.BackColor = System.Drawing.Color.Green;
            try
            {
                var calc = new Calc();
                calc.calcSystem = Calc.CalcSystem.Bin;
                calc.calcType = Calc.CalcType.i64;

            }
            catch(Exception)
            {

            }
            try
            {

            }
            catch(Exception)
            {

            }
        }

        private void buttonBajt_Click(object sender, EventArgs e)
        {
            this.buttonBajt.BackColor = System.Drawing.Color.Green;
            try
            {
                var calc = new Calc();
                calc.calcSystem = Calc.CalcSystem.Dec;
                calc.calcType = Calc.CalcType.i8;
                //scenariusz pozytywny
                calc.calcValue = "120";
                if ()
                {

                }
            }
            catch(Exception)
            {
                this.buttonBajt.BackColor = System.Drawing.Color.Red;
            }
            try
            {
                var calc = new Calc();
                calc.calcSystem = Calc.CalcSystem.Dec;
                calc.calcType = Calc.CalcType.i8;
                //scenariusz pozytywny
                calc.calcValue = "1342453";
            }
            catch (Exception)
            {
                this.buttonBajt.BackColor = System.Drawing.Color.Red;
            }
        }

        private void buttonWord_Click(object sender, EventArgs e)
        {
            this.buttonWord.BackColor = System.Drawing.Color.Green;
        }

        private void buttonDword_Click(object sender, EventArgs e)
        {
            this.buttonDword.BackColor = System.Drawing.Color.Green;
        }

        private void buttonQword_Click(object sender, EventArgs e)
        {
            this.buttonQword.BackColor = System.Drawing.Color.Green;
        }
    }
}
