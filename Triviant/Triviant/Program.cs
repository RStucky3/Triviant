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
        static string[] categorieën = {"Film & TV", "Eten & Drinken", "Geschiedenis", "Muziek", "Nederland", "Sport" };
        static bool[] categorieGehad = { false, false, false, false, false, false };
        static int rondes = 0;
        static void Main(string[] args)
        {
            Dobbelsteen dobbelsteen = new Dobbelsteen();

            Console.WriteLine("Hello welkom bij Triviant!");
            Console.WriteLine("Hier word uw kennis getest.");
            Console.WriteLine("U krijgt vragen te zien en daarbij 4 antwoorden, kiest daarbij het beste antwoord.");
            Console.WriteLine("");
            Console.WriteLine("Er zijn 6 categorieën:");
            int num = 0;
            for (int i = 0; i <= 5; i++)
            {
                num++;

                Console.WriteLine(num + ". " + categorieën[i]);
            }
            Console.WriteLine("\n" + "Klik op een knop om de dobbelsteen te rollen!");
            Console.ReadKey();
            int categorienum = dobbelsteen.Dobbel();
            categorieGehad[categorienum-1] = true;
            Console.WriteLine("\nU heeft " + categorienum + " gegooid!");
            Console.WriteLine("\n"+ "De categorie wordt " + categorieën[categorienum-1] + ".");
            Console.WriteLine("\n" + "Klik op een knop om te beginnen!");
            Console.ReadKey();
            Console.Clear();


            do
            {


                do
                {
                    Vraag vraag = new Vraag();
                    if (categorienum == 1) //film & tv
                    {

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
                    }
                    else if (categorienum == 2) //eten & drinken
                    {
                        vraag.setTekst(new string[] { "Hoe heet een gevulde dubbelgevouwen pizza?",
                                                  "Wat voor vitamines zitten er in de schil van een sinaasappel?",
                                                  "Welke kleur heeft 30% van de M&M’s in een normale zak M&M’s?",
                                                  "Wat is het hoofdingrediënt van bier?",
                                                  "Van welk bedrijf is de bekende frisdrank Fanta" }, tel);

                        vraag.setJuisteAntwoord(new int[] { 3, 3, 1, 4, 2 }, tel);

                        vraag.setAntwoorden(new string[,] { { "Pizza Salami", "Pizza Sensatia", "Pizza Calzone", "Pizza Double" },
                                                        { "Vitamine A", "Vitamine B", "Vitamine C", "Vitamine D" },
                                                        { "Bruin", "Geel", "Rood", "Groen" },
                                                        { "Alcohol", "Bloem", "Gist", "Water" },
                                                        { "Fanta", "Coca Cola", "7UP", "Mars" } }, tel);
                    }
                    else if (categorienum == 3) //geschiedenis
                    {
                        vraag.setTekst(new string[] { "Wanneer eindigde de eerste wereldoorlog?",
                                                  "Hoe heette de vader van Anne Frank?",
                                                  "Bij welke kunstenaar ging Gerrit (ook wel Gerard genoemd) Dou in de leer?",
                                                  "Welk werelddeel werd ooit Nieuw-Holland genoemd?",
                                                  "In welk jaar overleed prins Bernhard?" }, tel);

                        vraag.setJuisteAntwoord(new int[] { 1, 1, 3, 4, 4 }, tel);

                        vraag.setAntwoorden(new string[,] { { "1918", "1919", "1920", "1930" },
                                                        { "Otto", "Margot", "Koen", "David" },
                                                        { "Karel Appel", "Jan Steen", "Rembrandt van Rijn", "Theo Van Gogh" },
                                                        { "Amerika", "Azië", "Indië", "Australië" },
                                                        { "2001", "2002", "2003", "2004" } }, tel);
                    }
                    else if (categorienum == 4) //muziek
                    {
                        vraag.setTekst(new string[] { "Hoeveel snaren heeft een gitaar gewoonlijk?",
                                                  "In welk jaar overleed de zanger Michael Jackson?",
                                                  "Hoe gaat het liedje verder: Oh, Oh Den Haag, mooie stad……?",
                                                  "Hoeveel zwarte toetsen heeft een standaard piano?",
                                                  "In welke taal zong Marco Borsato voordat hij doorbrak met Nederlandstalige nummers?" }, tel);

                        vraag.setJuisteAntwoord(new int[] { 2, 1, 3, 2, 4 }, tel);

                        vraag.setAntwoorden(new string[,] { { "5", "6", "7", "8" },
                                                        { "2009", "2008", "2007", "2006" },
                                                        { "Achter de bioscoop", "Achter de huizen", "Achter de duinen", "Achter de koffie" },
                                                        { "34", "36", "38", "40" },
                                                        { "Frans", "Spaans", "Engels", "Italiaans" } }, tel);
                    }

                    else if (categorienum == 5) //nederland
                    {
                        vraag.setTekst(new string[] { "Hoe heet het grootste Nederlandse Waddeneiland?",
                                                  "Welke provincie in Nederland is het dunst bevolkt?",
                                                  "Wie is er neergeschoten in Delft?",
                                                  "Wat was de eerste Nederlandse televisieomroep?",
                                                  "Op welke datum is koningin Beatrix jarig?" }, tel);

                        vraag.setJuisteAntwoord(new int[] { 2, 1, 3, 3, 3 }, tel);

                        vraag.setAntwoorden(new string[,] { { "Ameland", "Texel", "Schiermonnikoog", "Vlieland" },
                                                        { "Drenthe", "Friesland", "Limburg", "Groningen" },
                                                        { "Vincent van Gogh", "Hugo de Groot", "Willem van Orange", "Rembrand van Rijn" },
                                                        { "NOB", "NKS", "NTC", "NOS" },
                                                        { "30-April", "31-April", "31-Januari", "30-Januari" } }, tel);
                    }
                    else //sport
                    {


                        vraag.setTekst(new string[] { "Welke voetbalclub heeft het grootste voetbalstadion van Nederland?",
                                                      "Hoe heet de vader van Max Verstappen",
                                                      "Welke trui mag de wereldkampioen wielrennen dragen?",
                                                      "Uit hoeveel veldspelers bestaat een waterpoloteam?",
                                                      "Op de laatste zaterdag van welke maand worden de TT Assen gehouden?" }, tel);

                        vraag.setJuisteAntwoord(new int[] { 1, 1, 4, 1, 1 }, tel);

                        vraag.setAntwoorden(new string[,] { { "Ajax", "ADO", "Feyenoord", "PSV" },
                                                        { "Jos Verstappen", "Remco Verstappen", "Anthony Verstappen", "Ben Verstappen" },
                                                        { "Winnerstrui", "Geletrui", "Rozetrui", "Regenboogtrui" },
                                                        { "6", "10", "7", "3" },
                                                        { "Juni", "Juli", "Augustus", "September" } }, tel);

                    }









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
                    if (controleinvoer == -1) {

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

                    if (tel < 5)
                    {
                        tel++;
                    }
                    

                } while (tel < 5);

                if (rondes < categorieën.Length-1)
                {
                    int nogTeGaan = 0;
                    for(int i = 0; i<categorieGehad.Length; i++)
                    {
                        if (categorieGehad[i] == false)
                        {
                            nogTeGaan++;
                        }
                    }
                    Console.WriteLine("\n" + "Dit was de categorie " + categorieën[categorienum-1] + ".");
                    Console.WriteLine("\nEr zijn nog " + nogTeGaan + " categorieën over.");
                    Console.WriteLine("Dit zijn:");
                    for(int i = 0; i<categorieën.Length; i++)
                    {
                        if (categorieGehad[i] == false)
                        {
                            Console.WriteLine(i+1 + ". " + categorieën[i]);
                        }
                    }
                    Console.WriteLine("\n" + "Klik op een knop om de dobbelsteen opnieuw te rollen!");
                    Console.WriteLine("");
                    Console.ReadKey();


                    bool herhaal = true;

                    while (herhaal == true)
                    {
                        categorienum = dobbelsteen.Dobbel();
                        if (categorieGehad[categorienum - 1] == false)
                        {
                            categorieGehad[categorienum - 1] = true;
                            herhaal = false;
                        }
                        else
                        {
                            
                            herhaal = true;                     
                        }
                    }
                    Console.WriteLine("U heeft " + categorienum + " gegooid!");
                    Console.WriteLine("\n" + "De categorie wordt " + categorieën[categorienum - 1] + ".");
                    Console.WriteLine("\n" + "Klik op een knop om te beginnen!");
                    Console.ReadKey();
                    Console.Clear();
                                     
                }
                rondes++;
                tel = 0;
            }
            while (rondes<categorieën.Length);

            Console.WriteLine("Gefeliciteerd, u heeft de quiz uitgespeelt.");
            Console.WriteLine("En daarbij een score behaalt van " + Score + " punt(en).");
            Console.WriteLine("Goed gedaan!");
            Console.ReadLine();

        } } }


