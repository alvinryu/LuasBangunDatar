using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    
    class Intro
    {
        public string name = "alvin";

        public void greeting()
        {
            Console.WriteLine("Halo nama saya adalah "+ name);
        }
    }

    class Alvin : Intro
    {
        Intro introo = new Intro();
        
    }

    class Program : Alvin
    {
        public string address = "jakarta utara";
        //static void Main(string[] args)
        //{
        //    Program prog = new Program();
        //    prog.greeting();
        //    Console.WriteLine("Saya dari "+ prog.address);

        //    Console.ReadLine();
        //}
    }
}
