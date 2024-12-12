using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class lab5
    {
        static void Main(string[] args)
        {
            List<string> stringList = new List<string>
            {
                "dog bark", "tiger roar" , "lion roar" ,"zebra"
            };


            Console.WriteLine("Displying the content");
            var display = from animal in stringList
                          select animal;
            foreach (var obj in display)
            {
                Console.WriteLine(obj);

            }



            //filter the string containg the same string
            Console.WriteLine("Filter the string containg the same string");

            var display1 = from animal in stringList
                           where animal.Contains("roar") // Filter strings that start with 'A'
                           select animal;
            foreach (var obj in display1)
            {
                Console.WriteLine(obj);

            }


        }
    }
}
