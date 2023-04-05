namespace ListaExercicios05.Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro = new Cilindro(10, 2);
            Console.WriteLine("O volume é aproximadamente " + Math.Round(cilindro.CalcularVolume(), 2) + " m³.");
            Console.ReadLine();
        }
    }

    public class Cilindro
    {
        private double altura, raio;
        public Cilindro(double altura, double raio)
        {
            this.altura = altura;
            this.raio = raio;
        }

        public double CalcularVolume()
        {
            return Math.PI * Math.Pow(this.raio, 2) * this.altura;
        }
    }

}