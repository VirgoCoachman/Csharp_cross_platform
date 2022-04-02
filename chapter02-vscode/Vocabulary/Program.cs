// #error version

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

dynamic something = "Virgo";
Console.WriteLine(something.GetType());
something = 12;
Console.WriteLine(something.GetType());
something = new []{3, 5, 7};

Console.WriteLine($"Length is {something.GetType()} ");
