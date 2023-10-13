using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MethodA();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение перехвачено в Main: {ex.Message}");
            }
        }

        static void MethodA()
        {
            try
            {
                MethodB();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение перехвачено в MethodA: {ex.Message}");
                throw;
            }
        }

        static void MethodB()
        {
            throw new InvalidOperationException("Произошла ошибка в MethodB.");
        }
    }
}
