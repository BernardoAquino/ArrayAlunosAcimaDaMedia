using System;

namespace ArrayAlunosAcimaDaMedia
{
    class ArrayAlunosAcimaDaMedia
    {
        static void Main(string[] args)
        {
            int n;
            double[] nota;
            string[] nome;
            double media = 0;

            Console.WriteLine("Digite a quantidade alunos:");
            n = int.Parse(Console.ReadLine());
            nota = new double[n];
            nome = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o nome do {0}º aluno: ", (i + 1));
                nome[i] = Console.ReadLine();

                Console.WriteLine("Digite a nota do {0}º aluno: ", (i + 1));
                nota[i] = int.Parse(Console.ReadLine());

                media += nota[i];
            }

            media /= n;

            for(int i = 0; i < n; i++)
            {
                if(nota[i] > media)
                {
                    Console.WriteLine("Aluno {0} -- nota {1}", nome[i], nota[i]);
                }
            }
        }
    }
}
