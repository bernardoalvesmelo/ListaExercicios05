namespace ListaExercicios05.Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal[] pesos = { 1, 3 };
            decimal[] notas = { 6, 10 };
            Aluno aluno = new Aluno(notas, pesos);
            Console.WriteLine("A média harmônica do aluno é " + Math.Round(aluno.CalcularMediaPonderada(), 2));
            Console.ReadLine();
        }
    }

    public class Aluno
    {
        private decimal[] notas, pesos;
        public Aluno(decimal[] notas, decimal[] pesos)
        {
            this.notas = notas;
            this.pesos = pesos;
        }

        public decimal CalcularMediaPonderada()
        {
            return ((notas[0] * pesos[0]) + (notas[1] * pesos[1])) / (pesos[0] + pesos[1]);
        }
    }
}
