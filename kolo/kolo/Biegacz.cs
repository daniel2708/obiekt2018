using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolo
{
    class Biegacz:Sportowiec
    {
        private int rekord;

        public Biegacz(string imie,char klub,int rekord)
        {

            this.imie = imie;
            this.klub = klub;
            this.rekord = rekord;
        }
        override public string Zawody()
        {
            return "sddaD";
        }
        public override string ToString()
        {
            return String.Format("Imie: {0}, Klub: {1}, Rekord: {2}", imie, klub, rekord);
        }
    
    }
}
