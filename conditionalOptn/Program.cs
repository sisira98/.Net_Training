// See https://aka.ms/new-console-template for more information

//if else

Console.WriteLine("Enter no.of apples :");
int numOfApples = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter no.of oranges :");
int numOfOranges = Convert.ToInt32(Console.ReadLine()); 

if(numOfApples > numOfOranges)
{
    Console.WriteLine("There are more apples than oranges");
}
else if (numOfApples < numOfOranges)
{
    Console.WriteLine("There are more oranges than apples");
}
else if (numOfApples ==numOfOranges)
{
    Console.WriteLine("apples and oranges are equal count");
}
else
{
    Console.WriteLine("invalid input");
}

//switch

Console.WriteLine("Enter your mark (0-100) :");
int mark = Convert.ToInt32(Console.ReadLine());

switch(mark)
{
    case int n when (n < 50):
        Console.WriteLine("you are failed");
        break;
    case int n when (n >=50 && n <= 100):
        Console.WriteLine("you are passed");
        break;
     default:
        Console.WriteLine("invalid input");
        break;

}

//ternary -<condition> ? true action : false action
var message = numOfApples > numOfOranges ? "we have more apples" : "we have more oranges";
Console.WriteLine(message);