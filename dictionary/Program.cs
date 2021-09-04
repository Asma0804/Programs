using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {





            //key(unique)-value(any) pairs


            Dictionary<string, string> names = new Dictionary<string, string>();


            names.Add("1", "Asma");


            names.Add("2", "Ashu");


            names.Add("3", "mohammed");


            names.Add("4", "Asma");








            foreach (KeyValuePair<string, string> kv in names)


            {


                Console.WriteLine(kv.Key + " " + kv.Value);


            }

        }
    }
}
    
