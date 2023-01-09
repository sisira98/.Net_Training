// See https://aka.ms/new-console-template for more information
//for (counter controlled)
for(int i=0; i<10; i++)
{
    Console.WriteLine($"inside loop {i}");
}



//while(condtion controlled)

int n = 10;
while (n<5)
{
    Console.WriteLine("enetr the value for n: ");
    n= Convert.ToInt32( Console.ReadLine() );
    Console.WriteLine($"inside while loop {n}");

}
Console.WriteLine();
Console.WriteLine(" while loop exited");

//do while(condition controlled post check)
int j = 10;
do
{
    Console.WriteLine("enetr the value for j: ");
    j = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"inside while loop {j}");
}while(j>5);
Console.WriteLine();
Console.WriteLine("do while loop exited");