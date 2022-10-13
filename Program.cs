// See https://aka.ms/new-console-template for more information
Console.WriteLine("-  - --> Welcome to CSVReader version 0.0.1 <-- -  -");

string filename = "/home/user/Projects/CSVReader/employees.csv";


using (StreamReader reader = new StreamReader(filename))
{
    string? line;

    while ((line = reader.ReadLine()) != null) {
        System.Console.WriteLine(line);
    }
}