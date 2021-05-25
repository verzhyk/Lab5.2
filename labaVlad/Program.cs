using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaVlad
{
    class Program
    {

        public static FloatPower Init(float first, float second)
        {
            return new FloatPower(first, second);
        }

        public static void Read()
        {
            Console.Write("Enter first value: ");
            float.TryParse(Console.ReadLine(), out float first);
            Console.Write("Enter second value: ");
            float.TryParse(Console.ReadLine(), out float second);

            Display(Init(first, second));
        }

        public static void Display(FloatPower floatPower)
        {
            if (floatPower != null)
            {
                Console.WriteLine(floatPower.Power());
                floatPower--;
                Console.WriteLine(floatPower.Power());
                floatPower++;
                Console.WriteLine(floatPower.Power());
            }
            else
            {
                Console.WriteLine("Введены неверные значения!");
            }
        }

        static void Main(string[] args)
        {
            Read();
        }
    }
}
