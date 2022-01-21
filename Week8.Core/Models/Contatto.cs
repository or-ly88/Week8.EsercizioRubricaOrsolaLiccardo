﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8.Core.Models
{
    public class Contatto
    {
        public int ContattoID { get; set; }
        public  string Nome { get; set; }
        public string Cognome { get; set; }

        //Collection di Indirizzo
        public ICollection<Indirizzo> Indirizzi { get; set; } = new List<Indirizzo>();

        //override del ToString
        public override string ToString()
        {
            return $"{ContattoID}- {Nome} - {Cognome}";

        }
    }
}
