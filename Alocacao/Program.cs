using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;

namespace Alocacao
{
    internal class Program
    {

        class Carro{
            public string Cor;
            public string Nome;

        };

        static void Main(string[] args)
        {
            
            Carro carro1 = new Carro();
            Carro carro2 = new Carro();

            carro1.Cor = "Azul";
            carro1.Nome = "Gol";

            carro2.Cor = "Azul";
            carro2.Nome = "Gol";

            bool teste = carro1 == carro2;


        }
    }
}
