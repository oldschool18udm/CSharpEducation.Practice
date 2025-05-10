namespace Practice02.Task20;

class Program
{
    static int[][] createMatrix(int rows, int cols)
    {
        int[][] matrix = new int[rows][];
        for (int i = 0; i < rows; i++)
        {
            matrix[i] = new int[cols];
        }
        Random random = new Random();
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                matrix[row][col] = random.Next(1,100);
            }
            
        }
        return matrix;
    }

    static void PrintMatrix(int[][]matrix)
    {
        for (int row = 0; row < matrix.Length; row++)
        {
            for (int col = 0; col < matrix[0].Length; col++)
            {
                Console.Write(matrix[row][col]+"\t");
            }
            Console.WriteLine();
            
        }
    }
    
    static void Main(string[] args)
    {
        int[][] matrix = createMatrix(8, 6);
        PrintMatrix(matrix);
        for (int row = 0; row < matrix.Length;row++)
        {
            Console.WriteLine(matrix[row].Max()-matrix[row].Min());
        }
    }
}