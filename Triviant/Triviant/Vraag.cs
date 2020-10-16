using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Triviant
{
    class Vraag
    {
        private string text;
        private string[] antwoorden = new string[4];
        private int antw;
        private int juisteAntwoord;
        private int categorie;

        public int Categorie { get => categorie; set => categorie = value; }

        public void setTekst(string[] tekst, int index)
        {
            this.text = tekst[index];           
        }

        public string getTekst()
        {
            return this.text;
        }

        public void setAntwoorden(string[,] tekst, int tel)
        {
            for ( int i = 0; i < 4; i++)

            {
                this.antwoorden[i] = tekst[tel,i];
            }
           
        }

        public string[] getAntwoorden()
        {
            return this.antwoorden;
        }

        public void setJuisteAntwoord(int[] antwoorden, int index)
        {
            this.juisteAntwoord = antwoorden[index];
        }
        public int setGegevenAntwoord()
        {
            try
            {
                int Antw = Convert.ToInt32(Console.ReadLine());

              
                if (Antw > 4)
                {
                    Console.WriteLine("\n" + "Dit was geen correcte invoer");
                    return -1;
                }
                else
                {
                    this.antw = Antw;
                    return 0;
                }

            }
            catch (Exception)
            {
                Console.WriteLine("\n" + "Dit was geen correcte invoer");
                return -1;
            }
            

        }

            public int checkJuisteAntwoord()
            {
            if (this.antw == this.juisteAntwoord )
            {
                return punten = 1;
            }
            else if (this.juisteAntwoord == 99)
            {
                return punten = 99;
            }
  
            else
            {
                return punten = 0;
            }
        }

            public string getJuisteAntwoord(int index)
            {
                return this.antwoorden[this.juisteAntwoord-1];
            }
     }
}
