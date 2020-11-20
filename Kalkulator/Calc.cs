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
                if(this.calcSystem == CalcSystem.Hex)
                {

                }
                else if(this.calcSystem == CalcSystem.Dec)
                {

                }
                else if(this.calcSystem == CalcSystem.Oct)
                {

                }
                else if(this.calcSystem == CalcSystem.Bin)
                {

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
