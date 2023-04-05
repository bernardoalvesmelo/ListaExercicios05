namespace ListaExercicios05.Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LataDeOleo lataDeOleo = new LataDeOleo(10, 2);
            Console.WriteLine("O volume é aproximadamente " + Math.Round(lataDeOleo.CalcularVolume(), 2) + " m³.");
            Console.ReadLine();
        }
    }

    public class LataDeOleo
    {
        private double altura, raio;
        public LataDeOleo(double altura, double raio)
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