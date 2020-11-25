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
        private long testValue01;
        private long testValue02;
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
            buttonDzielenie_Click(null, null);
            buttonDodawanie_Click(null, null);
            buttonOdejmowanie_Click(null, null);
            buttonModulo_Click(null, null);
            buttonZmianaZnaku_Click(null, null);
            buttonCyfryASCII_Click(null, null);
            buttonCyfryASCIIbin_Click(null, null);
            buttonCyfryASCIIoct_Click(null, null);
            buttonCyfryASCIIhex_Click(null, null);
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
            this.buttonMnozenie.BackColor = System.Drawing.Color.Green;
            try
            {

                var calc_01 = new Calc();
                var calc_02 = new Calc();
                calc_01.calcSystem = Calc.CalcSystem.Dec;
                calc_02.calcSystem = Calc.CalcSystem.Dec;
                calc_01.calcType = Calc.CalcType.i8;
                calc_02.calcType = Calc.CalcType.i8;
                
                //scenariusz pozytywny
                calc_01.calcValue = "10";
                calc_02.calcValue = "10";
                test_value_01 = 100;

                //scenariusz negatywny
                //calc_01.calcValue = "125";
                //calc_02.calcValue = "125";
                //test_value_01 = 15625;

                if (calc_01.calcSystem == calc_02.calcSystem)
                {
                    if (calc_01.calcType == calc_02.calcType)
                    {
                       
                        testValue01 = System.Convert.ToInt64(calc_01.calcValue);
                        testValue02 = System.Convert.ToInt64(calc_02.calcValue);
                        test_value = testValue01*testValue02;
                        if (test_value_01 == test_value)
                        {
                            if (test_value >= 128 | test_value <= -129)
                            {
                                throw new Exception("");
                            }
                        }
                        else
                        {
                            throw new Exception("");
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.buttonMnozenie.BackColor = System.Drawing.Color.Red;
            }
        }

        private void buttonDzielenie_Click(object sender, EventArgs e)
        {
            this.buttonDzielenie.BackColor = System.Drawing.Color.Green;
            try
            {

                var calc_01 = new Calc();
                var calc_02 = new Calc();
                calc_01.calcSystem = Calc.CalcSystem.Dec;
                calc_02.calcSystem = Calc.CalcSystem.Dec;
                calc_01.calcType = Calc.CalcType.i8;
                calc_02.calcType = Calc.CalcType.i8;

                //scenariusz pozytywny
                calc_01.calcValue = "250";
                calc_02.calcValue = "10";
                test_value_01 = 25;

                if (calc_01.calcSystem == calc_02.calcSystem)
                {
                    if (calc_01.calcType == calc_02.calcType)
                    {
                        testValue01 = System.Convert.ToInt64(calc_01.calcValue);
                        testValue02 = System.Convert.ToInt64(calc_02.calcValue);
                        if (testValue01 > testValue02)
                        {
                            test_value = testValue01 / testValue02;
                            if (test_value_01 != test_value)
                            {
                                throw new Exception("");
                            }
                        }
                        else
                        {
                            throw new Exception("");
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.buttonDzielenie.BackColor = System.Drawing.Color.Red;
            }
        }

        private void buttonDodawanie_Click(object sender, EventArgs e)
        {
            this.buttonDodawanie.BackColor = System.Drawing.Color.Green;
            try
            {

                var calc_01 = new Calc();
                var calc_02 = new Calc();
                calc_01.calcSystem = Calc.CalcSystem.Dec;
                calc_02.calcSystem = Calc.CalcSystem.Dec;
                calc_01.calcType = Calc.CalcType.i8;
                calc_02.calcType = Calc.CalcType.i8;

                //scenariusz pozytywny
                calc_01.calcValue = "30";
                calc_02.calcValue = "30";
                test_value_01 = 60;
                //scenariusz negatywny
                //calc_01.calcValue = "120";
                //calc_02.calcValue = "120";
                //test_value_01 = 240;

                if (calc_01.calcSystem == calc_02.calcSystem)
                {
                    if (calc_01.calcType == calc_02.calcType)
                    {
                        testValue01 = System.Convert.ToInt64(calc_01.calcValue);
                        testValue02 = System.Convert.ToInt64(calc_02.calcValue);
                        test_value = testValue01 + testValue02;
                        if (test_value_01 == test_value)
                        {
                            if (test_value >= 128 | test_value <= -129)
                            {
                                throw new Exception("");
                            }
                        }
                        else
                        {
                            throw new Exception("");
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.buttonDodawanie.BackColor = System.Drawing.Color.Red;
            }
        }

        private void buttonOdejmowanie_Click(object sender, EventArgs e)
        {
            this.buttonOdejmowanie.BackColor = System.Drawing.Color.Green;
            try
            {
                var calc_01 = new Calc();
                var calc_02 = new Calc();
                calc_01.calcSystem = Calc.CalcSystem.Dec;
                calc_02.calcSystem = Calc.CalcSystem.Dec;
                calc_01.calcType = Calc.CalcType.i8;
                calc_02.calcType = Calc.CalcType.i8;

                //scenariusz pozytywny
                calc_01.calcValue = "125";
                calc_02.calcValue = "125";
                test_value_01 = 0;
                //scenariusz negatywny
                //calc_01.calcValue = "125";
                //calc_02.calcValue = "-80";
                //test_value_01 = 45;

                if (calc_01.calcSystem == calc_02.calcSystem)
                {
                    if (calc_01.calcType == calc_02.calcType)
                    {
                        testValue01 = System.Convert.ToInt64(calc_01.calcValue);
                        testValue02 = System.Convert.ToInt64(calc_02.calcValue);
                        test_value = testValue01 - testValue02;
                        if (test_value_01 == test_value)
                        {
                            if (test_value >= 128 | test_value <= -129)
                            {
                                throw new Exception("");
                            }
                        }
                        else
                        {
                            throw new Exception("");
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.buttonOdejmowanie.BackColor = System.Drawing.Color.Red;
            }
        }

        private void buttonModulo_Click(object sender, EventArgs e)
        {
            this.buttonModulo.BackColor = System.Drawing.Color.Green;
            try
            {
                var calc_01 = new Calc();
                var calc_02 = new Calc();
                calc_01.calcSystem = Calc.CalcSystem.Dec;
                calc_02.calcSystem = Calc.CalcSystem.Dec;
                calc_01.calcType = Calc.CalcType.i8;
                calc_02.calcType = Calc.CalcType.i8;

                //scenariusz pozytywny
                calc_01.calcValue = "11";
                calc_02.calcValue = "3";
                test_value_01 = 2;
                

                if (calc_01.calcSystem == calc_02.calcSystem)
                {
                    if (calc_01.calcType == calc_02.calcType)
                    {
                        testValue01 = System.Convert.ToInt64(calc_01.calcValue);
                        testValue02 = System.Convert.ToInt64(calc_02.calcValue);
                        test_value = testValue01 % testValue02;
                        if (test_value_01 == test_value)
                        {
                            if (test_value >= 128 | test_value <= -129)
                            {
                                throw new Exception("");
                            }
                        }
                        else
                        {
                            throw new Exception("");
                        }
                    }
                }
            }
            catch (Exception)
            {
                this.buttonModulo.BackColor = System.Drawing.Color.Red;
            }
        }

        private void buttonZmianaZnaku_Click(object sender, EventArgs e)
        {
            this.buttonZmianaZnaku.BackColor = System.Drawing.Color.Green;
            try
            {
                var calc_01 = new Calc();
                calc_01.calcSystem = Calc.CalcSystem.Dec;
                calc_01.calcType = Calc.CalcType.i8;

                //scenariusz pozytywny
                calc_01.calcValue = "11";
   
                test_value_01 = -11;
                test_value = System.Convert.ToInt64(calc_01.calcValue)*-1;
                
                if (test_value != test_value_01)
                {
                    throw new Exception("");
                }
            }
            catch(Exception)
            {
                this.buttonZmianaZnaku.BackColor = System.Drawing.Color.Red;
            }
        }

        private void buttonCyfryASCII_Click(object sender, EventArgs e)
        {
            this.buttonCyfryASCIIdzies.BackColor = System.Drawing.Color.Green;
            try
            {
                var calc = new Calc();
                calc.calcSystem = Calc.CalcSystem.Dec;
                calc.calcType = Calc.CalcType.i8;
                calc.calcValue = "3";
                //scenariusz pozytywny

                //scenariusz negatywny
                //calc.calcValue = "q";
                if (calc.calcSystem == Calc.CalcSystem.Dec)
                {
                    testValue01 = Char.ConvertToUtf32(calc.calcValue, 0);
                    if (testValue01 > 57 | testValue01 < 48)
                    {
                        throw new Exception("");
                    }
                }
            }
            catch(Exception)
            {
                this.buttonCyfryASCIIdzies.BackColor = System.Drawing.Color.Red;
            }
        }

        private void buttonCyfryASCIIbin_Click(object sender, EventArgs e)
        {
            this.buttonCyfryASCIIbin.BackColor = System.Drawing.Color.Green;
            try
            {
                var calc = new Calc();
                calc.calcSystem = Calc.CalcSystem.Bin;
                calc.calcType = Calc.CalcType.i8;
                calc.calcValue = "1";
                //scenariusz pozytywny

                //scenariusz negatywny
                //calc.calcValue = "2";
                
                if (calc.calcSystem == Calc.CalcSystem.Bin)
                {
                    testValue01 = Char.ConvertToUtf32(calc.calcValue, 0);
                    Console.WriteLine(testValue01);
                    if (testValue01 > 49 | testValue01 < 48)
                    {
                        throw new Exception("");
                    }
                }
            }
            catch(Exception)
            {
                this.buttonCyfryASCIIbin.BackColor = System.Drawing.Color.Red;
            }
        }

        private void buttonCyfryASCIIoct_Click(object sender, EventArgs e)
        {
            this.buttonCyfryASCIIoct.BackColor = System.Drawing.Color.Green;
            try
            {
                var calc = new Calc();
                calc.calcSystem = Calc.CalcSystem.Oct;
                calc.calcType = Calc.CalcType.i8;
                calc.calcValue = "4";
                //scenariusz pozytywny

                //scenariusz negatywny
                //calc.calcValue = "8";

                if (calc.calcSystem == Calc.CalcSystem.Oct)
                {
                    testValue01 = Char.ConvertToUtf32(calc.calcValue, 0);
                    Console.WriteLine(testValue01);
                    if (testValue01 > 55 | testValue01 < 48)
                    {
                        throw new Exception("");
                    }
                }
            }
            catch (Exception)
            {
                this.buttonCyfryASCIIoct.BackColor = System.Drawing.Color.Red;
            }
        }

        private void buttonCyfryASCIIhex_Click(object sender, EventArgs e)
        {
            this.buttonCyfryASCIIhex.BackColor = System.Drawing.Color.Green;
            try
            {
                var calc = new Calc();
                calc.calcSystem = Calc.CalcSystem.Hex;
                calc.calcType = Calc.CalcType.i8;

                //scenariusz pozytywny
                //calc.calcValue = "b";
                //calc.calcValue = "A";

                //scenariusz negatywny
                //calc.calcValue = "q";
                //calc.calcValue = "K";
                if (calc.calcSystem == Calc.CalcSystem.Hex)
                {
                    testValue01 = Char.ConvertToUtf32(calc.calcValue, 0);
                    Console.WriteLine(testValue01);
                    if (testValue01 < 48)
                        throw new Exception("");

                    else if (57 < testValue01 & testValue01 > 65)
                    {
                        throw new Exception("");
                    }
                    else if (70 < testValue01 & testValue01 > 97)
                    {
                        throw new Exception("");
                    }
                    else if (102 < testValue01)
                    {
                        throw new Exception("");
                    }
                }
            }
            catch (Exception)
            {
                this.buttonCyfryASCIIhex.BackColor = System.Drawing.Color.Red;
            }
        }
    }
}
