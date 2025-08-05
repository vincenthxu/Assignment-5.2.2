namespace Assignment_5._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RecurseNaturalNumbers(10);
            Console.WriteLine();
        }

        static void RecurseNaturalNumbers(int n)
        {
            if (n > 1)
                RecurseNaturalNumbers(n - 1);
            Console.Write(n + " ");
        }
    }
}
