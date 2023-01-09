// See https://aka.ms/new-console-template for more information


Random rnd = new Random();
int x = rnd.Next(0, 100);


Console.Write("Guess the number (0-100)");
int guess = Convert.ToInt32(Console.ReadLine());


for (int i=4; i>=0;i--)
    {
    if(i==0 && guess != x)
    {
        Console.WriteLine("You lost");
        Console.WriteLine($"The number is : {x}");
        break;
    }
   else if (guess < x)
    {
        Console.WriteLine($"Guessed number is less than x, you have {i} chances left");
        Console.Write("Try another number : ");
        guess = Convert.ToInt32(Console.ReadLine());
    }
    else if (guess > x)
    {
        Console.WriteLine($"Guessed number  is greater than x, you have {i} chances left");
        Console.Write("Try another number : ");
        guess = Convert.ToInt32(Console.ReadLine());
    }
    else if (guess == x)
    {
        Console.WriteLine("You win");
        break;
    }
}


