namespace gta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Models.Carro carro1 = new Models.Carro();
            Models.Carro carro2 = new Models.Carro();

            carro1.Acelerar();
            carro1.Acelerar();

            carro2.Acelerar();
            carro2.Acelerar();
            carro2.Acelerar();

            carro1.Nome = "Monza";

            Console.WriteLine(carro1.Nome);
        }
    }
}
