using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[10, 10];
        Random rand = new Random(); // Para preencher a matriz com valores aleatórios
        int somaTotal = 0;

        // Preenchendo a matriz com valores aleatórios de 1 a 100 e imprimindo
        Console.WriteLine("Matriz 10x10:");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                matriz[i, j] = rand.Next(1, 101);
                somaTotal += matriz[i, j];
                Console.Write(matriz[i, j].ToString().PadLeft(4));
            }
            Console.WriteLine();
        }

        // Exibindo a soma total da matriz
        Console.WriteLine("\nSoma total dos elementos da matriz: " + somaTotal);
        Console.ReadKey();
    }
}
