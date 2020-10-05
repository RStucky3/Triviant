using System;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices.ComTypes;

namespace Triviant
{
    class Program
    {
        static int Score = 0;
        static int index = 0;
        static void Main(string[] args)
        {

            Console.WriteLine("Hello welkom bij Triviant!");
            Console.WriteLine("Hier word uw kennis getest.");
            Console.WriteLine("U krijgt vragen te zien en daarbij 4 antwoorden, kiest daarbij het beste antwoord.");
            Console.WriteLine("Klik op enter om te beginnen!");
            Console.ReadLine();


            int[] vraagantwoorden = { 1, 1, 3, 1, 2 };

            do
            { 

            Vragen vraag = new Vragen();
            vraag.setTekst(new string[] { "Wat is de naam van het tweede deel uit The Matrix trilogie?",
                                           "Welke actrice speelde Monica Gellar in de serie Friends?",
                                           "Voor welke inlichtingendienst was James Bond een werkzaam?",
                                           "Welk bedrijf maakte als eerst een volledige 3d-animatiefilm?",
                                           "Uit welk materiaal bestaat een Oscar Award voor 92.5 %?" }, index);

            Vragen antwoorden1 = new Vragen();
            antwoorden1.setAntwoorden(new string[,] { { "The Matrix Revolutions", "The Matrix Reloaded", "The Matrix", "The Real Matrix" }, 
                                                        { "Jennifer Aniston", "Courteney Cox", "Lisa Kudrow", "David Schwimmer" }, 
                                                        { "CIA", "AIVD", "FBI", "MI6" }, 
                                                        { "Disney", "Pixar", "Apple", "Dreamworks" },
                                                        { "Plastic", "Lood", "Tin", "Ijzer" } });


                Console.WriteLine(vraag.getTekst());


                int teller = 0;
                string[,] antwoord = antwoorden1.getAntwoorden();
                for (int i = 0; i <= 3; i++)
                {
                    teller++;

                    Console.WriteLine(teller + ". " + antwoord[index, i]);
                }



                Console.WriteLine("");
                Console.WriteLine("Type uw keuze: 1,2,3 of 4");


                Vragen antwoorden = new Vragen();

                int punten = antwoorden.setJuisteAntwoord(vraagantwoorden[index]);


                    Console.WriteLine("");
                    switch (punten)
                    {
                        case 1:
                            Console.WriteLine("Goed gedaan");
                            Score++;
                            break;
                        case 0:
                            Console.WriteLine("Dat is helaas niet goed. Het antwoord is " + antwoord[index,vraagantwoorden[index]]);
                            break;
                        case -1:
                            index--;
                            break;
                        case 99:
                            index = 99;
                            break;
                    }

                Console.WriteLine("Je hebt " + Score + " punt(en).");
                Console.WriteLine("Klik op enter om door te gaan");
                Console.ReadLine();
                Console.Clear();

                index++;

            } while (index <= vraagantwoorden.Length-1);

            Console.WriteLine("Gefeliciteerd, u heeft de quiz uitgespeelt.");
            Console.WriteLine("En daarbij een score behaalt van " + Score + " punt(en).");
            Console.WriteLine("Goed gedaan!");
            Console.ReadLine();

        } } }


