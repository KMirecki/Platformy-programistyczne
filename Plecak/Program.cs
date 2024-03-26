namespace Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter seed: ");
            int seed = int.Parse(Console.ReadLine());
            Plecak plecak = new Plecak(n, seed);
            Console.WriteLine("\nEnter capacity: ");
            int capacity = int.Parse(Console.ReadLine());
            Console.WriteLine(plecak.Solve(capacity).ToString());
        }
    }
}
