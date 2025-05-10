namespace Practice02.Task13;

class Program
{
    static int[,] createMatrix(int rows, int cols)
    {
        int[,] matrix = new int[rows, cols];
        Random random = new Random();
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = random.Next(10);
            }
            
        }
        return matrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
               Console.Write(matrix[row, col]+" ");
            }
            Console.WriteLine();
            
        }
    }
    static void Main(string[] args)
    {
        
        int[,] matrix = createMatrix(8, 6);
        PrintMatrix(matrix);
    }
}