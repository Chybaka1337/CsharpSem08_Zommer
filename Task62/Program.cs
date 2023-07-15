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
            var matrix = new int[6, 5];
            int number = 1;
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[0, j] = number++;
            }

            for(int i = 1; i < matrix.GetLength(0); i++)
            {
                matrix[i, matrix.GetLength(1) - 1] = number++;
            }

            for(int j = matrix.GetLength(1) - 2; j >= 0; j--)
            {
                matrix[matrix.GetLength(0) - 1, j] = number++;
            }

            for(int i = matrix.GetLength(0) - 2; i > 0; i--)
            {
                matrix[i, 0] = number++;
            }

            int x = 1;
            int y = 1;
            while(number != matrix.GetLength(0) * matrix.GetLength(1))
            {
                //вправо
                while(matrix[x, y + 1] == 0) 
                {
                    matrix[x, y] = number++;
                    y++;
                }

                //вниз
                while(matrix[x + 1, y] == 0)
                {
                    matrix[x, y] = number++;
                    x++;
                }

                //влево
                while(matrix[x, y - 1] == 0) 
                {
                    matrix[x, y] = number++;
                    y--;
                }

                //вверх
                while(matrix[x - 1, y] == 0)
                {
                    matrix[x, y] = number++;
                    x--;
                }
            }

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i, j] == 0)
                    {
                        matrix[i, j] = number;
                    }
                }
            }
            return matrix;
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