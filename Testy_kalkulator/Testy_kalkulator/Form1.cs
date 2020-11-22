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
        private long test_value;
        private long test_value_01;
        private long test_value_02;
        private long test_value_03;
        private long test_value_04;
        private long test_value_05;
        public Form1()
        {
            InitializeComponent();
            button1_Click(null, null);
            buttonDecVal_Click(null, null);
            buttonHexVal_Click_1(null, null);
            buttonOctVal_Click(null, null);
            buttonBinVal_Click(null, null);
            buttonBajt_Click(null, null);
            buttonWord_Click(null, null);
            buttonDword_Click(null, null);
            buttonQword_Click(null, null);
            buttonMnozenie_Click(null, null);
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
                //calc.calcValue = "0ABCDEF";
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


        private void buttonHexVal_Click_1(object sender, EventArgs e)
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
            catch (Exception)
            {
                this.buttonHexVal.BackColor = System.Drawing.Color.Red;
            }
            try
            {
                var calc = new Calc();
                calc.calcSystem = Calc.CalcSystem.Hex;
                calc.calcType = Calc.CalcType.i64;
                //test negatywny
                //calc.calcValue = "ABCDEK";
                if (calc.calcValue != "0")
                {
                    throw new Exception("");
                }
            }
            catch (Exception)
            {
                this.buttonHexVal.BackColor = System.Drawing.Color.Red;
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
                //test pozytywny
                calc.calcValue = "01234567";
            }
            catch (Exception)
            {
                this.buttonOctVal.BackColor = System.Drawing.Color.Red;
            }
            try
            {
                var calc = new Calc();
                calc.calcSystem = Calc.CalcSystem.Oct;
                calc.calcType = Calc.CalcType.i64;
                //test negatywny
                //calc.calcValue = "0ABCDEF";
                if (calc.calcValue != "0")
                {
                    throw new Exception("");
                }
            }
            catch (Exception)
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
                //test pozytywny
                calc.calcValue = "011110010101";
            }
            catch (Exception)
            {
                this.buttonBinVal.BackColor = System.Drawing.Color.Red;
            }
            try
            {
                var calc = new Calc();
                calc.calcSystem = Calc.CalcSystem.Bin;
                calc.calcType = Calc.CalcType.i64;
                //test negatywny
                //calc.calcValue = "11001234000";
                if (calc.calcValue != "0")
                {
                    throw new Exception("");
                }
            }
            catch (Exception)
            {
                this.buttonBinVal.BackColor = System.Drawing.Color.Red;
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
                calc.calcValue = "125";

                if (calc.calcSystem == Calc.CalcSystem.Bin)
                {

                }
                else if (calc.calcSystem == Calc.CalcSystem.Oct)
                {

                }
                else if (calc.calcSystem == Calc.CalcSystem.Dec)
                {
                    test_value = System.Convert.ToInt64(calc.calcValue);

                    if (test_value >= 128 | test_value <= -129)
                    {
                        throw new Exception("");
                    }
                }
                else if (calc.calcSystem == Calc.CalcSystem.Hex)
                {

                }
            }
            catch (Exception)
            {
                this.buttonBajt.BackColor = System.Drawing.Color.Red;
            }
            try
            {
                var calc = new Calc();
                calc.calcSystem = Calc.CalcSystem.Dec;
                calc.calcType = Calc.CalcType.i8;
                //scenariusz negatywny
                //calc.calcValue = "460";

                if (calc.calcSystem == Calc.CalcSystem.Bin)
                {

                }
                else if (calc.calcSystem == Calc.CalcSystem.Oct)
                {

                }
                else if (calc.calcSystem == Calc.CalcSystem.Dec)
                {
                    test_value = System.Convert.ToInt64(calc.calcValue);

                    if (test_value >= 128 | test_value <= -129)
                    {
                        throw new Exception("");
                    }
                }
                else if (calc.calcSystem == Calc.CalcSystem.Hex)
                {

                }
            }
            catch (Exception)
            {
                this.buttonBajt.BackColor = System.Drawing.Color.Red;
            }
        }

        private void buttonWord_Click(object sender, EventArgs e)
        {
            this.buttonWord.BackColor = System.Drawing.Color.Green;
            try
            {
                var calc = new Calc();
                calc.calcSystem = Calc.CalcSystem.Dec;
                calc.calcType = Calc.CalcType.i16;
                //scenariusz pozytywny
                calc.calcValue = "3456";

                if (calc.calcSystem == Calc.CalcSystem.Dec)
                {
                    test_value = System.Convert.ToInt64(calc.calcValue);

                    if (test_value >= 32767 | test_value <= -32768)
                    {
                        throw new Exception("");
                    }
                }
            }
            catch (Exception)
            {
                this.buttonWord.BackColor = System.Drawing.Color.Red;
            }
         
            try
            {
                var calc = new Calc();
                calc.calcSystem = Calc.CalcSystem.Dec;
                calc.calcType = Calc.CalcType.i16;
                //scenariusz negatywny
                //calc.calcValue = "75683767";

                if (calc.calcSystem == Calc.CalcSystem.Dec)
                {
                    test_value = System.Convert.ToInt64(calc.calcValue);

                    if (test_value >= 32767 | test_value <= -32768)
                    {
                        throw new Exception("");
                    }
                }
            }
            catch (Exception)
            {
                this.buttonWord.BackColor = System.Drawing.Color.Red;
            }
        }

        private void buttonDword_Click(object sender, EventArgs e)
        {
            this.buttonDword.BackColor = System.Drawing.Color.Green;
            try
            {
                var calc = new Calc();
                calc.calcSystem = Calc.CalcSystem.Dec;
                calc.calcType = Calc.CalcType.i32;
                //scenariusz pozytywny
                calc.calcValue = "756383";

                if (calc.calcSystem == Calc.CalcSystem.Dec)
                {
                    test_value = System.Convert.ToInt64(calc.calcValue);

                    if (test_value >= 2147483647 | test_value <= -2147483648)
                    {
                        throw new Exception("");
                    }
                }
            }
            catch (Exception)
            {
                this.buttonDword.BackColor = System.Drawing.Color.Red;
            }

            try
            {
                var calc = new Calc();
                calc.calcSystem = Calc.CalcSystem.Dec;
                calc.calcType = Calc.CalcType.i32;
                //scenariusz negatywny
                //calc.calcValue = "3147483647";

                if (calc.calcSystem == Calc.CalcSystem.Dec)
                {
                    test_value = System.Convert.ToInt64(calc.calcValue);

                    if (test_value >= 32767 | test_value <= -32768)
                    {
                        throw new Exception("");
                    }
                }
            }
            catch (Exception)
            {
                this.buttonDword.BackColor = System.Drawing.Color.Red;
            }
        }

        private void buttonQword_Click(object sender, EventArgs e)
        {
            this.buttonQword.BackColor = System.Drawing.Color.Green;
     
            try
            {
                var calc = new Calc();
                calc.calcSystem = Calc.CalcSystem.Dec;
                calc.calcType = Calc.CalcType.i64;
                //scenariusz pozytywny
                calc.calcValue = "31474836470";

                if (calc.calcSystem == Calc.CalcSystem.Dec)
                {
                    test_value = System.Convert.ToInt64(calc.calcValue);

                    if ((test_value > -2147483648) && (test_value < 2147483647))
                    {
                        throw new Exception("");
                    }
                }
            }
            catch (Exception)
            {
                this.buttonQword.BackColor = System.Drawing.Color.Red;
            }

            try
            {
                var calc = new Calc();
                calc.calcSystem = Calc.CalcSystem.Dec;
                calc.calcType = Calc.CalcType.i64;
                //scenariusz negatywny
                //calc.calcValue = "1147483647";

                if (calc.calcSystem == Calc.CalcSystem.Dec)
                {
                    //test_value = System.Convert.ToInt64(calc.calcValue);

                    if ((test_value > -2147483648) && (test_value < 2147483647))
                    {
                        throw new Exception("");
                    }
                }
            }
            catch (Exception)
            {
                this.buttonQword.BackColor = System.Drawing.Color.Red;
            }
        }

        private void buttonMnozenie_Click(object sender, EventArgs e)
        {

        }
    }
}
