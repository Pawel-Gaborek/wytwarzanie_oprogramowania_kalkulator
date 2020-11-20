using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    public class Calc
    {
        public Calc()
        {
            this.calcValue = "0";
            this.calcType = CalcType.i64;
            this.calcSystem = CalcSystem.Dec;
        }
        public string calcValue { get; set; }

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
