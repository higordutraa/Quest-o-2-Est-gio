using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que digite uma string
        Console.WriteLine("Digite uma string:");

        // Captura a entrada do usuário
        string texto = "Eu irei passar nessa vaga de estágio!";

        // Chama a função para contar a ocorrência de 'a' ou 'A'
        int quantidade = ContarOcorrenciasDeA(texto);

        // Verifica se a letra 'a' ou 'A' existe na string
        if (quantidade > 0)
        {
            Console.WriteLine($"A letra 'a' ou 'A' aparece {quantidade} vezes na string.");
        }
        else
        {
            Console.WriteLine("A letra 'a' ou 'A' não aparece na string.");
        }
    }

    static int ContarOcorrenciasDeA(string texto)
    {
        // Inicializa a contagem
        int contador = 0;

        // Itera por cada caractere da string
        foreach (char c in texto)
        {
            // Verifica se o caractere é 'a' ou 'A'
            if (c == 'a' || c == 'A')
            {
                contador++;
            }
        }

        return contador;
    }
}
