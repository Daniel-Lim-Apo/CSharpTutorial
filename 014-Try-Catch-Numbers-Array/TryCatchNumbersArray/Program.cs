int myIndex = 3;
int myOtherIndex = 5;

try
{
    int[] myNumbers = { 10, 20, 30, 40, 50 };
    Console.WriteLine(myNumbers[myIndex]);
    Console.WriteLine(myNumbers[myOtherIndex]);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
