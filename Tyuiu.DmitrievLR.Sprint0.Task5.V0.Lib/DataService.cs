

namespace Tyuiu.DmitrievLR.Sprint0.Task5.V0.Lib
{
    public class DataService 
    {
        public static int Addiction(int a, int b)
        {
            return a + b;
        }

        public static int Substraction(int a, int b)
        {
            return a - b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static double Division(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine(" Переменная b = {0}, на ноль делить нельзя", b);
                return -1;
            }
            else
            {
                return a / b;
            }

        }

    }
}
