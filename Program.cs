namespace lista5;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lista de Exercícios V: Arrays\n");
        Console.WriteLine("Selecione um exercício:\n ");
        Console.WriteLine("Exercício 1");
        Console.WriteLine("Exercício 2");
        Console.WriteLine("Exercício 3");
        Console.WriteLine("Exercício 4");
        Console.WriteLine("Exercício 5");
        Console.WriteLine("Exercício 6\n");
        int n = Convert.ToInt32(Console.ReadLine());

        switch (n)
        {
            case 1:
                Exercicio1.exercicio();
                break;
            case 2:
                Exercicio2.exercicio();
                break;
            case 3:
                Exercicio3.exercicio();
                break;
            case 4:
                Exercicio4.exercicio();
                break;
            case 5:
                Exercicio5.exercicio();
                break;
            case 6:
                Exercicio6.exercicio();
                break;
        }

    }
}

