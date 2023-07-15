namespace Task56
{
    public class Program 
    {
        static void Main(string[] args)
        {
            var matrix = GetMatrix();
            matrix.PrintMatrix();
            
            var rows = matrix.SumRows();
            Console.WriteLine("\nСумма каждой строки");
            rows.PrintArray();
            Console.WriteLine();
            var index = rows.FindMin();
            Console.WriteLine($"Строка под номером: {index + 1} имеет наименьшую сумму");
        }

        static int[,] GetMatrix() 
        {
            var matrix = new int[6, 4];
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

    static public class ArrayExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Возвращает индекс наименьшего элемента массива.</returns>
        public static int FindMin(this int[] array) 
        {
            int index = -1;
            int minValue = int.MaxValue;
            for(int i = 0; i < array.Length; i++)
            {
                if(minValue > array[i])
                {
                    index = i;
                    minValue = array[i];
                }
            }
            return index;
        }

        public static void PrintArray(this int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
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