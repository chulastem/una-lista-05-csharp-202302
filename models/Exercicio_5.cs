namespace lista5;
public class Exercicio5
{
    public static void exercicio()
    {
        int[] n = new int[20];
        int[] nPar = new int[20];
        int[] nImpar = new int[20];
        int contPares = 0;
        int contImpares = 0;
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"Digite o {i + 1}º número: ");
            n[i] = Convert.ToInt32(Console.ReadLine());
            if (n[i] % 2 == 0)
            {
                nPar[contPares] = n[i];
                contPares++;
            }
            else
            {
                nImpar[contImpares] = n[i];
                contImpares++;
            }
        }
        Console.WriteLine("Número digitados:");
        for (int i = 0; i < 20; i++)
        {
            Console.Write(n[i] + " ");
        }
        Console.WriteLine("\nNúmeros pares digitados:");
        for (int i = 0; i < contPares; i++)
        {
            Console.Write(nPar[i] + " ");
        }
        Console.WriteLine("\nNúmeros impares digitados:");
        for (int i = 0; i < contImpares; i++)
        {
            Console.Write(nImpar[i] + " ");
        }
        Console.ReadLine();
    }

}