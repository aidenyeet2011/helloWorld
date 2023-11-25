// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

Console.WriteLine("Hello, World!");
int l, r;
try {
    Console.Write ("please enter top number");
    l = int.Parse(Console.ReadLine());
    Console.Write ("please enter bottom number");
    r = int.Parse (Console.ReadLine());
    
    Console.Write("please enter Expressions");
    string prompt = Console.ReadLine();
     
    if (prompt == "+")
    {
        var sum = l + r;
        Console.WriteLine($"{sum}");
    }
    else if ()
    
}
catch (FormatException err){
    Console.WriteLine("Could not parse number");
}
