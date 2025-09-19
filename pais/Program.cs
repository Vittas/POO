using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace pais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Models.Pais pais1 = new Models.Pais();
            Models.Pais pais2 = new Models.Pais();

            pais1.Nome = "Brasil";
            pais1.Nome_Capital = "Brasil";
            pais1.Dimensao = 1;

            pais2.Nome = "Brasil";
            pais2.Nome_Capital = "Brasil";
            pais2.Dimensao = 1;

            pais1.Iguais(pais2);
        }
    }
}
