namespace Practice02.Task22;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int trys = 7, step = 0;
        Random rnd = new Random();
        int secretNumber = rnd.Next(1, 100), playerNumber;
        Console.WriteLine(secretNumber);
        Console.WriteLine($"Отгадайте число от 1 до 100. У Вас есть {trys-step} попыток");
        do
        {
            step++;
            playerNumber = int.Parse(Console.ReadLine());
            if (secretNumber == playerNumber)
            {
                Console.WriteLine("Верно!");
            }
            else
            {
                if (secretNumber > playerNumber)
                {
                    Console.WriteLine($"Это слишком маленькое число. У Вас осталось {trys-step} попыток");
                }
                else
                {
                    Console.WriteLine($"Это слишком большое число. У Вас осталось {trys-step} попыток");
                }
            }
            
        } while (secretNumber != playerNumber && step < trys);

        if (secretNumber != playerNumber)
        {
            Console.WriteLine($"Вы проиграли. Было загадано число {secretNumber}");
        }
    }
}