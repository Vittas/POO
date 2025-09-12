using System;

namespace gta.Models
{
    internal class Carro
    {
        private int id;
        private string nome;
        private string cor;
        private int saude;
        private double aceleracao;
        private double velocidade;
            
        public int Id { get; set; }
        public string Nome {
            get 
            { 
                return this.nome;
            };
            set
            {
                if (ValidateString(value, 50))
                {
                    this.nome = value;
                }
                else
                {
                    Console.WriteLine("Limite de caractéres excedido!");
                }
            }
        }
        public string Cor { get; set; }

        public int Saude { get; set; }

        public double Aceleracao { get; set; }

        public double Velocidade { get; private set; }

        private int Dano { get; set; }

        public Carro()
        {
            Id = 0;
            Nome = "";
            Cor = "";
            Saude = 0;
        }

        private bool ValidateString(string stringRecebida, int tamanhoLimite)
        {
            if (stringRecebida.Length <= tamanhoLimite)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
        public void Acelerar()
        {
            this.Velocidade++;
        }

        public void Frear()
        {
            if (velocidade > 0)
            {
                this.Velocidade--;
            }
        }

    }
}
