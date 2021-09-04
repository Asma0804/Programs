using System;
namespace enums
{
    class Program
    {
        enum level
        {
            low = 5,
            medium = 6, high = 7
        }
        static void Main(string[] args)
        {
            int obj = (int)level.medium;
            Console.WriteLine(obj);


        }


    }
}
