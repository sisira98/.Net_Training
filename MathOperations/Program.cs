// See https://aka.ms/new-console-template for more information
int num1= 11;
int num2 = 12;

Console.WriteLine($"Addition:{num1+num2}");
Console.WriteLine($"sub : {num1 - num2}");
Console.WriteLine($"multiplication :  {num1 *num2}");
Console.WriteLine($"division: {num1 /num2}");
Console.WriteLine($"modulus:{num1 % num2}");


num1 = num1 + 4;

Console.WriteLine($"new value for num1 : {num1}");
Console.WriteLine($"Addition:{num1 + num2}");
Console.WriteLine($"sub : {num1 - num2}");
Console.WriteLine($" multiplication : {num1 * num2}");
Console.WriteLine($"division:{num1 / num2}");
Console.WriteLine($"modulus :{num1 % num2}");


//compund assignment (+=, -=, *=, /=, %=)

num1 += 5;
Console.WriteLine($"new value for num1 after += : {num1}");
num1 -= 5;
Console.WriteLine($"new value for num1 after -= : {num1}");
num1 *= 5;
Console.WriteLine($"new value for num1 after *= : {num1}");
num1 /= 5;
Console.WriteLine($"new value for num1 after /= : {num1}");
num1 %= 5;
Console.WriteLine($"new value for num1 after %= : {num1}");
