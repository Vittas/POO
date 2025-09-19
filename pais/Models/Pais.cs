using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace pais.Models
{
    internal class Pais
    {
      
        public string Nome { set; get; }
        public string Nome_Capital { set; get; }
        public double Dimensao { set; get;}

        public Pais() { }

        public bool Iguais( Pais Pais_2) { 
            if(this.Nome == Pais_2.Nome && this.Dimensao == Pais_2.Dimensao && this.Nome_Capital == Pais_2.Nome_Capital)
            {
                return true;
            } else { return false; }
        }
    }
}
