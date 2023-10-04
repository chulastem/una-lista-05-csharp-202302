namespace lista5;
public class Exercicio4
{
    public static void exercicio()
    {
        string[] caracteres = new string[10];
        string vogais = "AEIOUaeiou";
        int contadorConsoantes = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Digite um caractere: ");
            caracteres[i] = Console.ReadLine() ?? "";
            if (!vogais.Contains(caracteres[i]))
            {
                contadorConsoantes++;
            }
        }
        Console.WriteLine("Consoantes digitadas:");
        for (int i = 0; i < 10; i++)
        {
            if (!vogais.Contains(caracteres[i]))
            {
                Console.WriteLine(caracteres[i]);
            }
        }
        Console.WriteLine("Total de consoantes: " + contadorConsoantes);
        Console.ReadLine();
    }

}