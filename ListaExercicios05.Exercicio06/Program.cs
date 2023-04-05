namespace ListaExercicios05.Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculadorTemperatura calculadorTemperatura = new CalculadorTemperatura(-12);
            Console.WriteLine("A temperatura em graus Fahrenheit é: " + Math.Round(calculadorTemperatura.CalcularTemperaturaFahrenheit()) + " °F.");
            Console.ReadLine();
        }
    }

    public class CalculadorTemperatura
    {
        private decimal grausCelsius;
        public CalculadorTemperatura(decimal grausCelsius)
        {
            this.grausCelsius = grausCelsius;
        }

        public decimal CalcularTemperaturaFahrenheit()
        {
            return this.grausCelsius * 1.8M + 32;
        }
    }

}