using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porta.Models
{
    internal class Porta
    {
        public bool Aberta { get; private set; }
        public string Cor { get; private set; }
        public double DimensaoX {get; private set;}
        public double DimensaoY { get; private set; }
        public double DimensaoZ { get; private set; }

        public Porta() { 
            this.Aberta = false;
            this.Cor = "Marrom";
            this.DimensaoX = 100;
            this.DimensaoY = 210;
            this.DimensaoZ = 4.1;
        }

        public Porta(bool aberta)
        {
            this.Aberta = aberta;
            this.Cor = "Marrom";
            this.DimensaoX = 100;
            this.DimensaoY = 210;
            this.DimensaoZ = 4.1;
        }

        public void Abrir()
        {
            this.Aberta = true;
        }
        public void Fechar() { 
            this.Aberta = false;
        }

        public bool EstaAberta()
        {
            return this.Aberta;
        }

        public void Pintar(string Cor) { 
            this.Cor = Cor;
        }
            
    }
}
