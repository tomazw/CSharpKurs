using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string sTmp = args[0];
            Console.WriteLine("Hello "+sTmp+"! Today is " + DateTime.Now);
            //Console.WriteLine(sTmp);
            Console.WriteLine("Koniec.");

            foreach (var item in args)
            {
                Console.WriteLine("Hello " + item); //+ sTmp + "! Today is " + DateTime.Now);
                //Console.WriteLine(sTmp);
                //Console.WriteLine("Koniec.");
            }
        }
    }
}
