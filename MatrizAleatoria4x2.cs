using System;

class Program
{
    public static void Main()
    {
        Random rand = new Random();
        int[,] matriz = new int[4, 2];  
        int soma = 0; 

        
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                matriz[i, j] = rand.Next(1, 11);  // Gera um número entre 1 e 10
            }
        }

       
        Console.WriteLine("Matriz 4x2:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Calculando a soma de todos os valores da matriz
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                soma += matriz[i, j];  // Adiciona o valor atual à soma
            }
        }

        Console.WriteLine("\nSoma de todos os elementos da matriz: " + soma);

        Console.ReadKey();
    }
}
