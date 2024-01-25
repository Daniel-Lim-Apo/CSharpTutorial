// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

PrintDelegate PrintConsole = (string text) => 
{
    Console.WriteLine(text);
};


PrintDelegate PrintToFile = (string text) =>
{
    File.AppendAllText("./logs.txt", text); 
};

PrintConsole("Hello from delegate");
PrintConsole("Hello from delegate to file");

void ConnectToDatabase(PrintDelegate log)
{
    //Do the insertion
    log("Inserting a new record to the database\n");

    //Insertion done
    log("The record was inserted\n");

}

ConnectToDatabase(PrintToFile);

delegate void PrintDelegate(string text);