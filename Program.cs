namespace Assignment_5._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                foreach (var arg in args)
                {
                    if (int.TryParse(arg, out int num))
                    {
                        RecurseNaturalNumbers(num);
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                RecurseNaturalNumbers(10);
                Console.WriteLine();
            }
        }

        static void RecurseNaturalNumbers(int n)
        {
            if (n > 1)
                RecurseNaturalNumbers(n - 1);
            Console.Write(n + " ");
        }
    }
}
