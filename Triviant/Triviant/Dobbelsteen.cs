using System;
using System.Collections.Generic;
using System.Text;

namespace Triviant
{
    class Dobbelsteen
    {
        private int ogen;
        public int Dobbel()
        {
            Random random = new Random();
            ogen = random.Next(6)+1;
            return ogen;
        }


    }
}
