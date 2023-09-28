namespace lista5;
public class Exercicio1
{
    public static void exercicio()
    {
        int[] numeros = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o {i+1}º número: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nNúmeros digitados:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }

        Console.ReadLine();
    }

}