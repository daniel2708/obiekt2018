using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolo
{
    class Zawodnik
    {
        private int czas;
        public bool Medal()
        {
            if (czas % 2 == 0 ) return false;
            else return true;
        }
    }
}
