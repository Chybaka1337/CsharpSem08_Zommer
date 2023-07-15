namespace Task60
{
    public class Program
    {
        static void Main(string[] args)
        {
            var matrix = GetMatrix();
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                for(int i = 0; i < matrix.GetLength(0); i++)
                {
                    for(int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($"{matrix[i, j, k]} ({i},{j},{k})\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        static int[ , , ] GetMatrix() 
        {
            var matrix = new int[2, 2, 2];
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    for(int k = 0; k < matrix.GetLength(2); k++)
                    {
                        matrix[i, j, k] = (i * 3 + k * 2 + j * 5 + new Random().Next(0, 1000) % 79) % 100 + 10\1;
                    }
                }
            }
            return matrix;
        }
    }


}