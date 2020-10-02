using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Triviant
{
    class Vragen
    {
        private string text;
        private string[] antwoorden;
        private int juisteAntwoord;

        public void setTekst(string tekst)
        {
            this.text = tekst;
        }

        public string getTekst()
        {
            return this.text;
        }

        public void setAntwoorden(string[] tekst)
        {
            this.antwoorden = tekst;
        }

        public string[] getAntwoorden()
        {
            return this.antwoorden;
        }

        public void setJuisteAntwoord(int tekst)
        {
            this.juisteAntwoord = tekst;
        }

        public int getJuisteAntwoord(int index)
        {
            return this.juisteAntwoord;
        }
    }
}
