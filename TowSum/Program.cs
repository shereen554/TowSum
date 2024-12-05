namespace TowSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array = ");
            int size =int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enetr index Number {i+1} =");
                arr[i] =int.Parse(Console.ReadLine());
            }
            Console.Write("Enetr the target = ");
            int target=int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length-1; j++)
                {
                    if (arr[i] + arr[j] == target && i != j) 
                    {
                        Console.WriteLine($"[{i},{j}]");
                    }
                }
            }
        }
    }
}
