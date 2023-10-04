namespace lista5;
public class Exercicio3
{
    public static void exercicio()
    {
        int cont = 0;
        double soma = 0;
        double[] nota = new double[4];
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"Digite a {i + 1}ª nota: ");
            nota[i] = Convert.ToDouble(Console.ReadLine());
        }
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"{i + 1}ª nota {nota[i]}");
            soma += nota[i];
            cont++;
        }
        Console.WriteLine($"Média dos número = {soma / cont}");
        Console.ReadLine();
    }

}