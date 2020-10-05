using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Triviant
{
    class Vragen
    {
        private string text;
        private string[,] antwoorden;
        private int punten;
        private int antw;

        public void setTekst(string[] tekst, int index)
        {
            this.text = tekst[index];           
        }

        public string getTekst()
        {
            return this.text;
        }

        public void setAntwoorden(string[,] tekst)
        {
            this.antwoorden = tekst;
        }

        public string[,] getAntwoorden()
        {
            return this.antwoorden;
        }

        public int setJuisteAntwoord(int Antw)
        {

            try
            {
                int invoer = Convert.ToInt32(Console.ReadLine());

                this.antw = Antw;
                if (this.antw == invoer - 1)
                {
                    return punten = 1;
                }
                else if (invoer == 99)
                {
                    return punten = 99;

                }
                else if (invoer > 4)
                {
                    Console.WriteLine("\n" + "Dit was geen correcte invoer");
                    return -1;
                }
                else
                {
                    return punten = 0;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\n" + "Dit was geen correcte invoer");
                return -1;
            }
            

        }

            public int getJuisteAntwoord()
            {
                return this.punten;
            }
     }
}
