namespace ListaExercicios05.Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal salarioBase = 1000;
            decimal vendas = 2000;
            Console.WriteLine("Digite o percentual de comissao do vendedor");
            decimal comissao = Convert.ToDecimal(Console.ReadLine());
            Vendedor vendedor = new Vendedor(salarioBase, vendas, comissao);
            Console.WriteLine("O salário total do vendedor é R$" + Math.Round(vendedor.CalcularSalario(), 2));
            Console.ReadLine();
        }
    }

    public class Vendedor
    {
        private decimal salarioBase, vendas, comissao;
        public Vendedor(decimal salarioBase, decimal vendas, decimal comissao)
        {
            this.salarioBase = salarioBase;
            this.vendas = vendas;
            this.comissao = comissao;
        }

        public decimal CalcularSalario()
        {
            return this.salarioBase + (this.vendas * this.comissao / 100);
        }
    }

}