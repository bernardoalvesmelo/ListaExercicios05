namespace ListaExercicios05.Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo(10, 20, 1);
            Console.WriteLine("O veículo está consumindo " + veiculo.CalcularConsumo() + " L por Km.");
            Console.ReadLine();
        }
    }

    public class Veiculo
    {
        private double kmInicial, kmFinal, combustivel;
        public Veiculo(double kmInicial, double kmFinal, double combustivel)
        {
            this.kmInicial = kmInicial;
            this.kmFinal = kmFinal;
            this.combustivel = combustivel;
        }

        public double CalcularConsumo()
        {
            return combustivel / (kmFinal - kmInicial);
        }
    }

}