using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gta.Models
{
    internal class Arma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Dano { get; set; }
        public double Valor { get; set; }
        public int Saude { get; set; }
        public bool Bloqueado { get; set; }

        public Arma(double valor, int saude)
        {
            this.Bloqueado = true;
            this.Valor = valor;
            this.Saude = saude;
        }
    }
}
