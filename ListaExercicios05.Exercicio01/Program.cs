namespace ListaExercicios05.Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaixaRetangular caixaRetangular = new CaixaRetangular(10, 10, 10);
            Console.WriteLine("O volume é: " + caixaRetangular.CalcularVolume());
            Console.ReadLine();
        }
    }

    public class CaixaRetangular
    {
        private decimal altura, largura, comprimento;
        public CaixaRetangular(decimal altura, decimal largura, decimal comprimento)
        {
            this.altura = altura;
            this.largura = largura;
            this.comprimento = comprimento;
        }

        public decimal CalcularVolume()
        {
            return this.altura * this.largura * this.comprimento;
        }
    }

}