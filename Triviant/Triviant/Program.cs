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
            Vragen vraag1 = new Vragen();
            vraag1.setTekst("Wat is de naam van het tweede deel uit The Matrix trilogie?");
            vraag1.setAntwoorden(new string[] { "The Matrix Reloaded", "The Matrix Revolutions", "The Matrix", "The Real Matrix" });
            vraag1.setJuisteAntwoord(0);

            Vragen vraag2 = new Vragen();
            vraag2.setTekst("Welke actrice speelde Monica Gellar in de serie Friends?");
            vraag2.setAntwoorden(new string[] { "Jennifer Aniston", "Courteney Cox", "Lisa Kudrow", "David Schwimmer" });
            vraag2.setJuisteAntwoord(1);

            Vragen vraag3 = new Vragen();
            vraag3.setTekst("Voor welke inlichtingendienst was James Bond een werkzaam?");
            vraag3.setAntwoorden(new string[] { "CIA", "AIVD", "FBI", "MI6" });
            vraag3.setJuisteAntwoord(3);

            Vragen vraag4 = new Vragen();
            vraag4.setTekst("Welk bedrijf maakte als eerst een volledige 3d-animatiefilm?");
            vraag4.setAntwoorden(new string[] { "Disney", "Pixar", "Apple", "Dreamworks" });
            vraag4.setJuisteAntwoord(1);

            Vragen vraag5 = new Vragen();
            vraag5.setTekst("Uit welk materiaal bestaat een Oscar Award voor 92.5 %?");
            vraag5.setAntwoorden(new string[] { "Plastic", "Lood", "Tin", "Ijzer" });
            vraag5.setJuisteAntwoord(2);

            Console.WriteLine("Hello welkom bij Triviant!");
            Console.WriteLine("Hier word uw kennis getest.");
            Console.WriteLine("U krijgt vragen te zien en daarbij 4 antwoorden, kiest daarbij het beste antwoord.");
            Console.WriteLine("Klik op enter om te beginnen!");
            Console.ReadLine();

            Console.WriteLine(vraag1.getTekst());
            int teller = 0;
            string[] antwoord = (vraag1.getAntwoorden());
            for (int i = 0; i <= 3; i++)
            {
                teller++;
               
                Console.WriteLine(teller + ". " + antwoord[i]);
            }



            Console.WriteLine("");
            Console.WriteLine("Type uw keuze: 1,2,3 of 4");
            Console.ReadLine(); } } }


            /*




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
                            index=99;
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("\n" + "Dit was geen correcte invoer");
                }

                index++;
                Console.WriteLine("Je hebt " + Score + " punt(en).");
                Console.WriteLine("Klik op enter om door te gaan");

                Console.ReadLine();
            } while (index < 5);
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
            else if(Antw == 99)
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
*/
