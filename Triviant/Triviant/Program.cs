using System;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices.ComTypes;

namespace Triviant
{
    class Program
    {
        static int Score = 0;
        static string[] Vraag = { "Wat is de naam van het tweede deel uit The Matrix trilogie?", "Welke actrice speelde Monica Gellar in de serie Friends?", "Voor welke inlichtingendienst was James Bond een werkzaam?", "Welk bedrijf maakte als eerst een volledige 3d-animatiefilm?" };
        static string[,] Antwoorden = { {"The Matrix Reloaded", "The Matrix Revolutions", "The Matrix", "The Real Matrix"}, { "Jennifer Aniston", "Courteney Cox", "Lisa Kudrow", "David Schwimmer" }, { "CIA", "AIVD", "FBI", "MI6" }, { "Disney", "Pixar", "Apple", "Dreamworks" } } ;
        static int[] JuisteAntwoord = { 0, 1, 3, 1 };
        static int index = 0;       

        static void Main(string[] args)
        {
            Console.WriteLine("Hello welkom bij Triviant!");
            Console.WriteLine("Hier word uw kennis getest.");
            Console.WriteLine("U krijgt vragen te zien en daarbij 4 antwoorden, kiest daarbij het beste antwoord.");
            Console.WriteLine("Klik op enter om te beginnen!");
            Console.ReadLine();

            do
            {
                showVraag(index + 1);
                showAntwoorden();


                try
                {
                    int Antwoord = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("");
                    switch (checkAntwoord(Antwoord))
                    {
                        case 1:
                            Console.WriteLine("Goed gedaan");
                            Score++;
                            break;
                        case 0:
                            Console.WriteLine("Dat is helaas niet goed. Het antwoord is " + Antwoorden[index, JuisteAntwoord[index]]);
                            break;
                        case 99:
                            Console.WriteLine("Dit is geen gelde invoer.");
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                index++;
                Console.WriteLine("Je hebt " + Score + " punt(en).");
                Console.WriteLine("Klik op enter om door te gaan");

                Console.ReadLine();
            } while (index < 4);
            Console.WriteLine("Gefeliciteerd, u heeft de quiz uitgespeelt.");
            Console.WriteLine("En daarbij een score behaalt van " + Score + " punt(en).");
            Console.WriteLine("Goed gedaan!");
            Console.ReadLine();

        }



        static void showVraag(int Nr)
        {
            Console.WriteLine("Vraag "+ Nr + ":");
            Console.WriteLine(Vraag[index]);
            Console.WriteLine("");
           
        }



        static void showAntwoorden()
        {
            int teller = 0;

            for (int i = 0; i <= 3; i++)
            {
                teller++;
                string antwoord = Antwoorden[index,i]; 
                Console.WriteLine(teller + ". " + antwoord);
            }

            Console.WriteLine("");
            Console.WriteLine("Type uw keuze: 1,2,3 of 4");

        }



        static int checkAntwoord(int Antw)
        {
            if (Antw == JuisteAntwoord[index] + 1) 
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

