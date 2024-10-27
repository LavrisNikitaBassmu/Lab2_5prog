class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        if (N <= 0)
        {
            Console.WriteLine("Введите натуральное число больше 0.");
            return;
        }

        bool found = false;

        for (int x = 1; x * x * x <= N; x++)
        {
            for (int y = x; y * y * y <= N; y++)
            {
                for (int z = y; z * z * z <= N; z++)
                {
                    if (x * x * x + y * y * y + z * z * z == N)
                    {
                        Console.WriteLine($"Комбинация: x = {x}, y = {y}, z = {z}");
                        found = true;
                    }
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("No such combinations!");
        }
    }
}