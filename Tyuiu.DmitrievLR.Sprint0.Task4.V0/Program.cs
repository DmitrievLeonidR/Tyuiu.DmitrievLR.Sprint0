using Tyuiu.DmitrievLR.Sprint0.Task4.V0.Lib;
namespace Tyuiu.DmitrievLR.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {

            //Addiction
            Console.WriteLine(DataService.Addiction(1, 5));
            //Substraction
            Console.WriteLine(DataService.Substraction(5,1));
            //Multiplication
            Console.WriteLine(DataService.Multiplication(10, 10));
            //Division
            Console.WriteLine(DataService.Division(10, 5));
            Console.ReadKey();
        }
    }
}