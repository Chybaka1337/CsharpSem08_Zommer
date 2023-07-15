namespace Task62
{
    public class Program 
    {
        static void Main(string[] args)
        {
            Print(GetMatrix());
        }

        static int[,] GetMatrix()
        {
            var matrix = new int[4, 4];
            
        }

        static int[,] FillVector(int[,] matrix, int row, int col, int length, int startNumber)
        {
            for()
        }

        static void Print(int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }

    
}