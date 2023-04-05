namespace ListaExercicios05.Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal[] notas = { 7, 8, 9 };
            Aluno aluno = new Aluno(notas);
            Console.WriteLine("A média harmônica do aluno é " + Math.Round(aluno.CalcularMediaHarmonica(), 2));
            Console.ReadLine();
        }
    }

    public class Aluno
    {
        private decimal[] notas;
        public Aluno(decimal[] notas)
        {
            this.notas = notas;
        }

        public decimal CalcularMediaHarmonica()
        {
            decimal inversoElementos = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                inversoElementos += 1 / notas[i];
            }

            return this.notas.Length / inversoElementos;
        }
    }

}