using System;


	class Program
	{
		public static void Main(string[] args)
		{
			Random rand = new Random();
			int[,] matriz = new int[3, 3];  
			
			for (int i = 0; i < 3; i++)
      	  {
            for (int j = 0; j < 3; j++)
            {
                matriz[i, j] = rand.Next(1, 101);  // Gera um número entre 1 e 100
            }
      	  }
			
			 Console.WriteLine("Matriz 3x3:");
      		for (int i = 0; i < 3; i++)
      	  {
          	  for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + " ");
         	 }
            Console.WriteLine();
      	  }
      		int maiorValor = matriz[0, 0]; // Assume o primeiro elemento como maior

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matriz[i, j] > maiorValor)
                    {
                        maiorValor = matriz[i, j]; // Atualiza o maior valor encontrado
                    }
                }
            }

            Console.WriteLine("\nO maior valor da matriz é: " + maiorValor);
      		
      		
      		
      		Console.ReadKey();
			
		}
	}	

