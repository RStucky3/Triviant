using System;
using System.Collections.Generic;
using System.Text;

namespace Triviant
{
    class Dobbelsteen
    {
        private int ogen;
        public string Categorie;
        public string Dobbel()
        {
            Random random = new Random();
            ogen = random.Next(6)+1;

            if (ogen == 1)
            {
                Categorie = "";
                return Categorie;
            }
            else if (ogen == 2)
            {
                Categorie = "";
                return Categorie;
            }
            else if (ogen == 3)
            {
                Categorie = "";
                return Categorie;
            }
            else if (ogen == 4)
            {
                Categorie = "";
                return Categorie;
            }
            else if (ogen == 5)
            {
                Categorie = "";
                return Categorie;
            }
            else
            {
                Categorie = "";
                return Categorie;
            }
        }


    }
}
