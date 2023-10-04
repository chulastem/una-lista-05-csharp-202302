namespace lista5;
public class Exercicio2
{
    public static void exercicio()
    {
        double[] n = new double[10];
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Digite o {i + 1}º número: ");
            n[i] = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("Numeros na ordem inversa: ");
        for (int i = 0; i <= 9; i++)
        {
            Console.WriteLine(n[i]);
        }
    Console.ReadLine();
    }
}

