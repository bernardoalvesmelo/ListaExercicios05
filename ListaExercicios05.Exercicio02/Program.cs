namespace ListaExercicios05.Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculadorTemperatura calculadorTemperatura = new CalculadorTemperatura(10);
            Console.WriteLine("A temperatura em graus Celsius é: " +
                              Math.Round(calculadorTemperatura.CalcularTemperaturaCelsius()) + " °C.");

            Console.ReadLine();
        }
    }

    public class CalculadorTemperatura
    {
        private decimal grausFahrenheit;
        public CalculadorTemperatura(decimal grausFahrenheit)
        {
            this.grausFahrenheit = grausFahrenheit;
        }

        public decimal CalcularTemperaturaCelsius()
        {
            return (this.grausFahrenheit - 32) / 1.8M;
        }
    }

}