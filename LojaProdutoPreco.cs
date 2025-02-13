using System;

class Program
{
    public static void Main()
    {
    	string [] Loja = { "Magazine Luiza", "Americanas", "Casas Bahia", "Ponto Frio", "Extra", "Carrefour", "Amazon", "Submarino" };
    	string [] Produto = { "Celular", "Notebook", "Televisão", "Geladeira" };
    	double[,] preco = new double[8, 4];
        Random rand = new Random(); // Para preencher a matriz com valores aleatórios
        
        
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 4; j++)
            {
            	preco[i,j] = rand.Next(50,201);
            }
            Console.WriteLine();
        }
        
        Console.WriteLine("Relações de produtos e lojas com preços até R$ 120,00:");
        
        for (int i = 0; i < 8; i++)
        {
        	for (int j = 0; j < 4; j++)
        	{
        		if (preco [i,j] <= 120)
        		{
        			Console.WriteLine(Loja[i] + " - " + Produto[j] + " - R$ " + preco[i,j].ToString("F2"));
        		}
        	}
        }
        Console.ReadKey();
    }
}
