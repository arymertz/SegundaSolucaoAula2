namespace Exe01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //quero cadastrar 2 alunos e suas 2 notas
            //quero calcular a média destas notas
            //se a média 6 aprovado senão reprovado
            string aluno1 = "Michael";
            string aluno2 = "Andreia";

            double a1n1 = 8.0;
            double a1n2 = 8;
            double a2n1 = 4;
            double a2n2 = 4;

            double ma1 =( a1n1 + a1n2) /2;
            double ma2 =( a2n1 + a2n2) /2;

            if (ma1>6) { } else { }
            if (ma2>6) { } else { }

            Console.WriteLine($"Média aluno; {aluno1} - {ma1}  ");
            Console.WriteLine($"Média aluno; {aluno2} - {ma2}  ");
        }
    }
}