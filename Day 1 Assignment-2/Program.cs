// See https://aka.ms/new-console-template for more information
double a = 0.0;
double b = 0.0;
double c = 0.0;

Console.Write(" Enter Value for a :");
a = Convert.ToDouble(Console.ReadLine());

Console.Write(" Enter Value for b :");
b = Convert.ToDouble(Console.ReadLine());

Console.Write(" Enter Value for c :");
c = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Result of the equation (((a + b) / c) * a) = {((a + b) / c) * a}");

