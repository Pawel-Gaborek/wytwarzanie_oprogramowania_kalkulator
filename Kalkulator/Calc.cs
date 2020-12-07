using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    public class Calc
    {
        private string _calcValue;
        public Calc()
        {
            this.calcType = CalcType.i64;
            this.calcSystem = CalcSystem.Dec;
            this.calcValue = "0";
        }
        public string calcValue
        {
            get
            {
                return _calcValue;
            }
            set
            {
                long testValue01;
                for (int i = 0; i < value.Length; i++)
                {
                    if (this.calcSystem == CalcSystem.Hex)
                    {
                        testValue01 = Char.ConvertToUtf32(value, i);
                        if ((testValue01 < 48) | (57 < testValue01 & testValue01 < 65) | (70 < testValue01 & testValue01 < 97) | (102 < testValue01))
                        {
                            value = value.Remove(i, 1);
                            i = 0;
                        }
                    }
                    else if (this.calcSystem == CalcSystem.Dec)
                    {
                        testValue01 = Char.ConvertToUtf32(value, i);
                        if (testValue01 < 48 | testValue01 > 57)
                        {
                            value = value.Remove(i, 1);
                            i = 0;
                        }
                    }
                    else if (this.calcSystem == CalcSystem.Oct)
                    {
                        testValue01 = Char.ConvertToUtf32(value, i);
                        if (testValue01 < 48 | testValue01 > 55)
                        {
                            value = value.Remove(i, 1);
                            i = 0;
                        }
                    }
                    else if (this.calcSystem == CalcSystem.Bin)
                    {
                        testValue01 = Char.ConvertToUtf32(value, i);
                        if (testValue01 < 48 | testValue01 > 49)
                        {
                            value = value.Remove(i, 1);
                            i = 0;
                        }
                    }
                }
                _calcValue = value;
            }
        }

        public CalcType calcType { get; set; }
        public enum CalcType
        {
            i64,
            i32,
            i16,
            i8 
        }

        public CalcSystem calcSystem { get; set; }
        public enum CalcSystem
        {
            Hex,
            Dec,
            Oct,
            Bin
        }
    }
}
