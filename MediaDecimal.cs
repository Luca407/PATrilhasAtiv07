using System;

class Program
{
    public static void Main()
    {
        // Criando a matriz de 2 linhas e 2 colunas com números decimais
        decimal[,] matriz = {
            { 5.4m, 7.8m },
            { 3.2m, 9.1m }
        };
        
        // Exibindo a matriz
        Console.WriteLine("Matriz:");
        for (int i = 0; i < matriz.GetLength(0); i++) // Percorrendo as linhas
        {
            for (int j = 0; j < matriz.GetLength(1); j++) // Percorrendo as colunas
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine(); // Nova linha após imprimir cada linha da matriz
        }

        // Cálculo da soma e média
        decimal soma = 0;
        int totalElementos = matriz.GetLength(0) * matriz.GetLength(1); // Número total de elementos da matriz
        
        // Somando os valores da matriz
        for (int i = 0; i < matriz.GetLength(0); i++) // Percorrendo as linhas
        {
            for (int j = 0; j < matriz.GetLength(1); j++) // Percorrendo as colunas
            {
                soma += matriz[i, j];
            }
        }

        // Calculando a média
        decimal media = soma / totalElementos;

        // Exibindo a média
        Console.WriteLine("\nA média dos valores da matriz é: " + media);

        Console.ReadKey();
    }
}
