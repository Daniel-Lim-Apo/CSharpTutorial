try
{
    int[] myNumbers = { 10, 20, 30, 40, 50 };

    // Uncomment each line to try differents results
    // Console.WriteLine(myNumbers[4]);
    // Console.WriteLine(myNumbers[5]);
    // Console.WriteLine(myNumbers[4]/10);
    // Console.WriteLine(myNumbers[4]/0);
}
catch (IndexOutOfRangeException e)
{
    Console.WriteLine("Original message: " + e.Message);
    Console.WriteLine("You got an error, ambitious youngster. We do not have so many items in this array.");
}
catch (Exception e)
{
    Console.WriteLine("Original message: " + e.Message);
    Console.WriteLine("You got an error!");
}

    Console.WriteLine("No error!");
