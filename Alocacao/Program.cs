using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;

namespace Alocacao
{
    internal class Program
    {
        class Moto {
            public int id;
            public string Nome;    
            public string Cor;
        
        }

        struct Carro{
            public int id;
            public string Cor;
            public string Nome;

        };

        static void Main(string[] args)
        {
            
            Carro carro1 = new Carro();
            Carro carro2 = new Carro();

            Moto moto1 = new Moto();
            Moto moto2 = new Moto();

            carro1.id = 1;
            carro1.Cor = "Azul";
            carro1.Nome = "Gol";
            
            carro1.id = 2;
            carro2.Cor = "Azul";
            carro2.Nome = "Gol";

            moto1.id = 3;
            moto2.Nome = "cg";
            moto1.Cor = "red";
            moto2.id = 4;
            moto2.Nome = "cg";
            moto2.Cor = "red";

            bool teste = carro1.Equals(carro2);

            bool testeMoto = moto1 == moto2;


        }
    }
}
