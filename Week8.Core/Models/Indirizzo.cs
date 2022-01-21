using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8.Core.Models
{
    public class Indirizzo
    {
        public int IndirizzoID { get; set; }
        public string Tipologia { get; set; }
        public string Via { get; set; }
        public string Città { get; set; }
        public string CAP { get; set; }
        public string Provincia { get; set; }
        public string Nazione { get; set; }

        //Fk verso Contatto
        public int ContattoID { get; set; }

        //Navigation property
        public Contatto Contatto { get; set; }

        //override del ToString
        public override string ToString()
        {
            return $"{IndirizzoID} - {Tipologia} - {Via} - {Città} - {CAP} - {Provincia} - {Nazione} ";

        }


    }
}
