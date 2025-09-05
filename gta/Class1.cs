using System;

namespace gta.Models
{
    internal class Carro
    {
        public int id;
        public string nome;
        public string cor;
        public int saude;
        public double aceleracao;
        public double velocidade;
        public int dano;
        public Carro()
        {
            id = 0;
            nome = "";
            cor = "";
            saude = 0;
        }

        public void Acelerar(){
            velocidade++;
        }
    }
}
