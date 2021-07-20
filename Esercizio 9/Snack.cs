using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_9
{
    class Snack
    {
        public int Codice { get; set; }
        public string Nome { get; set; }
       
        public decimal Prezzo { get; set; }

        public Snack(int codice, string nome, decimal prezzo)  //costruttore
        {
            this.Codice = Codice;
            this.Nome = nome;
            this.Prezzo = prezzo;
         
        }
    }
}

