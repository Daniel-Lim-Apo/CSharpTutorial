class TestClass
{
    static void Main(string[] args)
    {
        // Display the number of command line arguments.
        Console.WriteLine(args.Length);

        // Display all the string arguments.
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine(args[i]);
        }

    }
}