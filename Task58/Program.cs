namespace Task58
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var matrix1 = GetMatrix(2, 3);
            matrix1.Print();
            var matrix2 = GetMatrix(3, 2);
            matrix2.Print();

            var res = matrix1.Multiply(matrix2);
            res.Print();
        }

        static int[,] GetMatrix(int row, int col)
        {
            var matrix = new int[row, col];
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = new Random().Next(-10, 10);
                }
            }
            return matrix;
        }
    }

    public static class MatrixExtension
    {
        public static int[,] Multiply(this int[,] source, int[,] matrix)
        {
            if(source.GetLength(1) != matrix.GetLength(0))
            {
                return null;
            }

            int[,] dest = new int[source.GetLength(0), matrix.GetLength(1)];
            
            for(int rowIndex = 0; rowIndex < dest.GetLength(0); rowIndex++)
            {
                for(int colIndex = 0; colIndex < dest.GetLength(1); colIndex++)
                {
                    for(int i = 0; i < source.GetLength(1); i++)
                    {
                        dest[rowIndex, colIndex] += source[rowIndex, i] * matrix[i, colIndex];
                    }
                }
            }
            return dest;
        }

        public static void Print(this int[,] source)
        {
            for(int i = 0; i < source.GetLength(0); i++)
            {
                for(int j = 0; j < source.GetLength(1); j++)
                {
                    Console.Write(source[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}