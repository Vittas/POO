namespace Porta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Models.Porta p1 = new Models.Porta();
            Models.Porta p2 = new Models.Porta();
            Models.Porta p3 = new Models.Porta();

            Models.Porta[] portas = new Models.Porta[] { p1, p2, p3 };

            portas[0].Pintar("Branco");

            Console.WriteLine(portas[0].Cor);
        }
    }
}
