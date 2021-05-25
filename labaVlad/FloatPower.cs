using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaVlad
{
    public class FloatPower
    {
        private float first;

        public float First
        {
            get { return first; }
            set { first = value; }
        }

        private float second;

        public float Second
        {
            get { return second; }
            set { second = value; }
        }


        public FloatPower(float first, float second)
        {
            First = first;
            Second = second;
        }

        public double Power()
        {
            try
            {
                if (Second == 0 || First == 0)
                {
                    throw new BadException("Error. Second or First == 0!");
                }
                return Math.Pow(First, Second);
            }
            catch (BadException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
            
        }

        public static FloatPower operator ++(FloatPower floatPower)
        {
            return new FloatPower(floatPower.first, floatPower.second + 1);
        }

        public static FloatPower operator --(FloatPower floatPower)
        {
            return new FloatPower(floatPower.first, floatPower.second - 1);
        }

    }
}
