using System;
using System.Linq.Expressions;
namespace WiproDay5
{
    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the Age");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0)
                {
                    throw new AgeExce("Age is not valid");
                }
            }
            catch (AgeExce e)
            {
                Console.WriteLine(e.Message);

            }
        }
    }
}
