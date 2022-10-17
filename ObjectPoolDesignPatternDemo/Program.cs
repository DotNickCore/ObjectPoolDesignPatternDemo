using ObjectPoolDesignPatternDemo;

// See https://aka.ms/new-console-template for more information
Factory fa = new Factory();
Student myStu = fa.GetStudent();
Console.WriteLine("First object");
Student myStu1 = fa.GetStudent();
Console.WriteLine("Second object");
Student myStu2 = fa.GetStudent();
Console.WriteLine("Third object");
Console.Read();