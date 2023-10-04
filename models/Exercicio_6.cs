namespace lista5;
public class Exercicio6
{
    public static void exercicio()
    {
        int nAlunos = 10;
        double[] medias = new double[nAlunos];
        int contAlunosAprov = 0;

        for (int i = 0; i < nAlunos; i++)
        {
            Console.WriteLine($"Aluno {i + 1}:");
            double somaNotas = 0;

            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Digite a nota {j + 1}: ");
                double nota = Convert.ToDouble(Console.ReadLine());
                somaNotas += nota;
            }
            medias[i] = somaNotas / 4;

            Console.WriteLine($"Média do Aluno {i + 1}: {medias[i]:0.00}\n");
            if (medias[i] >= 7.0)
            {
                contAlunosAprov++;
            }
        }
        Console.WriteLine($"Número de alunos aprovados: {contAlunosAprov}");
        Console.ReadLine();
    }

}