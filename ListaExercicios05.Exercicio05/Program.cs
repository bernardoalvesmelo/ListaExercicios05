namespace ListaExercicios05.Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esfera esfera = new Esfera(10);
            Console.WriteLine("O volume é aproximadamente " + Math.Round(esfera.CalcularVolume(), 2) + " m³.");
            Console.ReadLine();
        }
    }

    public class Esfera
    {
        private double raio;
        public Esfera(double raio)
        {
            this.raio = raio;
        }

        public double CalcularVolume()
        {
            return 4 * Math.PI * Math.Pow(this.raio, 3) / 3;
        }
    }

}