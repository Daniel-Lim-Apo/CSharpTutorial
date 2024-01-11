# Create a new solution

dotnet new sln -n MySolution

# Create the projects:

dotnet new console -n MyCalc
dotnet new classlib -n SuperLogger
dotnet new classlib -n SuperCalcMachine

# Add the projects to the solution:

dotnet sln MySolution.sln add .\MyCalc\MyCalc.csproj
dotnet sln MySolution.sln add .\SuperLogger\SuperLogger.csproj
dotnet sln MySolution.sln add .\SuperCalcMachine\SuperCalcMachine.csproj

# Add reference in the main project to the two class library projects

dotnet add .\MyCalc\MyCalc.csproj reference .\SuperLogger\SuperLogger.csproj
dotnet add .\MyCalc\MyCalc.csproj reference .\SuperCalcMachine\SuperCalcMachine.csproj

# compile and run the project

dotnet build
dotnet run --project .\MyCalc\MyCalc.csproj
