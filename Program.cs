

using System;
using System.Reflection;

namespace chohotrt5
{
    internal class Program
    {
        private static object f;

        static void Main(string[] args)
        {
            string hazem = "";
            int frehat = 12;
            double hazoom = (25.23);
            float rami = 15.5f;
            bool khaled = true;
            char sameer = 's';
            const double juha = 3.14;
            Console.WriteLine(rami + hazem + frehat + khaled + sameer + juha);

            Console.WriteLine("**************************");

            string name = Console.ReadLine();// هون بعرف اللي بدي اياه والاقواس بتضل فاضيه 
            Console.WriteLine(name);// هون بطبع الاسم الوهمي عشان يعطيني اشي ثابت 

            Console.WriteLine("****************");
            string[] car = { "BMW", "Ford", "gclass" };
            Console.WriteLine(car[0] + car[1] + car[2]);

            Console.WriteLine("**************");


            string Ahmed  = Console.ReadLine();
            string Mohammed = Console.ReadLine();
            string Age= Console.ReadLine();
            Console.WriteLine(  Ahmed + " " +  Mohammed + " " + Age);

            Console.WriteLine("*******************");

            string[] first = new string[10];
            for (int x = 0; x < first.Length; x++)
            {
                Console.WriteLine("put in array");
                string zzz = Console.ReadLine();
                first[x] = zzz;


            }
            foreach (string w in first)
            {

                Console.WriteLine(w);
            }
            //....
            //...
        }

    }
}
