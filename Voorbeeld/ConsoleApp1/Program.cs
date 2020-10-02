using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tutorial2 pTutor = new Tutorial2();
            pTutor.SetTutorial(1, ".Net");
            Console.WriteLine(pTutor.GetTutorial());
            Console.ReadKey();
        }
    }
}
