using System;

namespace Triviant
{
    class Program
    {
        static int Score = 0;
        static string Vraag = "Wat is de naam van het tweede deel uit The Matrix trilogie?";
        static string[] Antwoorden = { "The Matrix Reloaded", "The Matrix Revolutions", "The Matrix", "The Real Matrix" };
        static int JuisteAntwoord = 0;



        static void Main(string[] args)
        {
            Console.WriteLine("Hello welkom bij Triviant!");
            Console.WriteLine("Hier word uw kennis getest.");
            Console.WriteLine("U krijgt vragen te zien en daarbij 4 antwoorden, kiest daarbij het beste antwoord.");
            Console.WriteLine("Klik op enter om te beginnen!");
            Console.ReadLine();
            showVraag(1);
            showAntwoorden();

            try { 
            int Antwoord = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");
                switch (checkAntwoord(Antwoord))
                {
                    case 1:
                        Console.WriteLine("Goed gedaan");
                        Score++;
                        break;
                    case 0:
                        Console.WriteLine("Dat is helaas niet goed. Het antwoord is " + Antwoorden[JuisteAntwoord]);
                        break;
                    case 99:
                        Console.WriteLine("Dit is geen gelde invoer.");
                        break;
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Je hebt " + Score + " punt(en).");
            Console.ReadLine();
        }



        static void showVraag(int Nr)
        {
            Console.WriteLine("Vraag "+ Nr + ":");
            Console.WriteLine(Vraag);
            Console.WriteLine("");
           
        }



        static void showAntwoorden()
        {
            int teller = 0;
            foreach (string antwoord in Antwoorden)
            {
                teller++;
                Console.WriteLine((teller) + ". " + antwoord);        
            }
            Console.WriteLine("");
            Console.WriteLine("Type uw keuze: 1,2,3 of 4");
        }



        static int checkAntwoord(int Antw)
        {
            if (Antw == JuisteAntwoord + 1) 
            {
                return 1;
            }
            else if(Antw > 4)
            {
                return 99;
            }
            else
            {
                return 0;
            }
        }
    }
}

