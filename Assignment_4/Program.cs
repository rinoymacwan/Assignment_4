using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dict = new List<string>() { "boat", "house", "cat", "river", "cupboard" };

            //1
            Console.WriteLine("Plurals.");
            foreach (var x in dict)
            {
                Console.WriteLine(x + "s");
            }

            //2

            dict[1] = "home";
            Console.WriteLine(dict[1]);



            //3
            Console.WriteLine("adding word.");
            dict.Add("monitor");
            Console.WriteLine("Length: " + dict.Count);

            //4
            Console.WriteLine("Entries with length 7.");
            foreach (var x in dict)
            {
                if (x.Length == 7)
                {
                    Console.WriteLine(x);
                }
            }


            //5

            Console.WriteLine("Word at 3rd position: " + dict[2]);

            //6
            dict.Sort();
            Console.WriteLine("Ascending order.");
            dict.ForEach(Console.WriteLine);


            //7

            dict.Reverse();
            Console.WriteLine("Descending order.");
            dict.ForEach(Console.WriteLine);


            Console.ReadKey();
        }
    }
}
