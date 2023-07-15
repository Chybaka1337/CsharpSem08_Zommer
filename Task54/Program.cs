namespace Task54
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = GetMatrix();
            matrix.PrintMatrix();
            Console.WriteLine("Sorted");
            matrix.SortRows();
            matrix.PrintMatrix();
        }

        static int[,] GetMatrix() 
        {
            var matrix = new int[4, 4];
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

    static public class MatrixExtension
    {
        public static int[,] SortRows(this int[,] matrix) 
        {
            for(int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
            {
                for(int i = 0; i < matrix.GetLength(1) - 1; i++)
                {
                    for(int j = 0; j < matrix.GetLength(1) - 1; j++)
                    {
                        if(matrix[rowIndex, j] < matrix[rowIndex, j + 1])
                        {
                            int buff = matrix[rowIndex, j];
                            matrix[rowIndex, j] = matrix[rowIndex, j + 1];
                            matrix[rowIndex, j + 1] = buff;
                        }
                    }
                }
            }
            return matrix;
        }

        public static void PrintMatrix(this int[,] matrix) 
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

        public static int[] SumRows(this int[,] matrix)
        {
            var rows = new int[matrix.GetLength(0)];
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    rows[i] += matrix[i, j];
                }
            } 
            return rows;
        }
    }
}