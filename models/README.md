# Lista de Exercícios V: Arrays

## UC - Estrutura de dados e análise de algoritmos -Pratica

**Pedro Antônio Esteves Silva - RA: 622122907**

Considerações Iniciais:
Esta lista de exercício deve:

- Ser realizada em equipes de até 06 alunos.
- Ser entregue no prazo proposto.
- Todos os integrantes devem enviar a lista na plataforma.
- Ter os algoritmos pedidos escritos em linguagem C#(csharp) ou Java.
- Ter todos os algoritmos devidamente identados.

1- Faça um Programa que leia um vetor de 5 números inteiros e mostre-os.

```csharp
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
```

2- Faça um Programa que leia um vetor de 10 números reais e mostre-os na ordem
inversa.

```csharp
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
```

3- Faça um Programa que leia 4 notas, mostre as notas e a média na tela.

```csharp
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
```

4- Faça um Programa que leia um vetor de 10 caracteres, e diga quantas consoantes
foram lidas. Imprima as consoantes.

```csharp
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
```

5- Faça um Programa que leia 20 números inteiros e armazene-os num vetor.
Armazene os números pares no vetor PAR e os números IMPARES no vetor ímpar.
Imprima os três vetores.

```csharp
namespace lista5;
public class Exercicio5
{
    public static void exercicio()
    {
        int[] numeros = new int[20];
        int[] npar = new int[20];
        int[] nimpar = new int[20];
        int pares = 0;
        int impares = 0;
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"Digite o {i + 1}º número: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
            if (numeros[i] % 2 == 0)
            {
                npar[pares] = numeros[i];
                pares++;
            }
            else
            {
                nimpar[impares] = numeros[i];
                impares++;
            }
        }
        Console.WriteLine("Número digitados:");
        for (int i = 0; i < 20; i++)
        {
            Console.Write(numeros[i] + " ");
        }
        Console.WriteLine("\nNúmeros pares digitados:");
        for (int i = 0; i < pares; i++)
        {
            Console.Write(npar[i] + " ");
        }
        Console.WriteLine("\nNúmeros impares digitados:");
        for (int i = 0; i < impares; i++)
        {
            Console.Write(nimpar[i] + " ");
        }

        Console.ReadLine();
    }

}
```

6- Faça um Programa que peça as quatro notas de 10 alunos, calcule e armazene num
vetor a média de cada aluno, imprima o número de alunos com média maior ou igual
a 7.0.

```csharp
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
```