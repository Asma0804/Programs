using System;


using System.Collections.Generic;





namespace Stack


{


    class Program


    {


        static void Main(string[] args)


        {


            //LIFO(last in first out)


            Stack<string> names = new Stack<string>();


            names.Push("Ashu");


            names.Push("Asma");


            names.Push("quadrant");


            names.Push("Resource");





            foreach (string name in names)


            {


                Console.WriteLine(name);


            }





            Console.WriteLine("Peek element: " + names.Peek());


            Console.WriteLine("Pop: " + names.Pop());


            Console.WriteLine("After Pop, Peek element: " + names.Peek());





        }


    }


}
