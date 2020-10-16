using System;
using System.Linq.Expressions;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices.ComTypes;

namespace Triviant
{
    class Program
    {
        static int Score = 0;
        static int tel = 0;
        static void Main(string[] args)
        {
            Dobbelsteen dobbelsteen = new Dobbelsteen();

            Console.WriteLine("Hello welkom bij Triviant!");
            Console.WriteLine("Hier word uw kennis getest.");
            Console.WriteLine("U krijgt vragen te zien en daarbij 4 antwoorden, kiest daarbij het beste antwoord.");
            Console.WriteLine("");
            Console.WriteLine("Klik op enter om de dobbelsteen te rollen!");
            Console.ReadLine();
            Console.WriteLine("U heeft " + dobbelsteen.Dobbel() + " gegooid");
            Console.WriteLine("Klik op enter om te beginnen!");
            Console.ReadLine();
            Console.Clear();



            do
            { 

            Vraag vraag = new Vraag();
            vraag.setTekst(new string[] { "Wat is de naam van het tweede deel uit The Matrix trilogie?",
                                           "Welke actrice speelde Monica Gellar in de serie Friends?",
                                           "Voor welke inlichtingendienst was James Bond een werkzaam?",
                                           "Welk bedrijf maakte als eerst een volledige 3d-animatiefilm?",
                                           "Uit welk materiaal bestaat een Oscar Award voor 92.5 %?" }, tel);

            vraag.setJuisteAntwoord(new int[] { 2, 2, 4, 2, 3 }, tel);
           
            vraag.setAntwoorden(new string[,] { { "The Matrix Revolutions", "The Matrix Reloaded", "The Matrix", "The Real Matrix" }, 
                                                        { "Jennifer Aniston", "Courteney Cox", "Lisa Kudrow", "David Schwimmer" }, 
                                                        { "CIA", "AIVD", "FBI", "MI6" }, 
                                                        { "Disney", "Pixar", "Apple", "Dreamworks" },
                                                        { "Plastic", "Lood", "Tin", "Ijzer" } }, tel);










                Console.WriteLine(vraag.getTekst());


                int teller = 0;
                string[] antwoord = vraag.getAntwoorden();
                for (int i = 0; i <= 3; i++)
                {
                    teller++;

                    Console.WriteLine(teller + ". " + antwoord[i]);
                }



                Console.WriteLine("");
                Console.WriteLine("Type uw keuze: 1,2,3 of 4");

   

                int controleinvoer = vraag.setGegevenAntwoord();
                if ( controleinvoer == -1) {

                    tel--;
                    Console.ReadLine();
                    Console.Clear();

                }
                else {

                    int punten = vraag.checkJuisteAntwoord();
                    Console.WriteLine("");
                    switch (punten)
                    {
                        case 1:
                            Console.WriteLine("Goed gedaan");
                            Score++;
                            break;
                        case 0:
                            Console.WriteLine("Dat is helaas niet goed. Het antwoord is " + vraag.getJuisteAntwoord(tel));
                            break;
                       case 99:
                            tel = 99;
                            break;
                    }

                    Console.WriteLine("Je hebt " + Score + " punt(en).");
                    Console.WriteLine("Klik op enter om door te gaan");
                    Console.ReadLine();
                    Console.Clear();
                }
                
                tel++;

            } while (tel < 4);

            Console.WriteLine("Gefeliciteerd, u heeft de quiz uitgespeelt.");
            Console.WriteLine("En daarbij een score behaalt van " + Score + " punt(en).");
            Console.WriteLine("Goed gedaan!");
            Console.ReadLine();

        } } }


