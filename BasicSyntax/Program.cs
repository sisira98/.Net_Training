// See https://aka.ms/new-console-template for more information

//first program

//data types(string,int,double,float,char,boolean

string fullName = string.Empty;
int age = 0;
double salary = 0.0;
char gender = char.MinValue;
bool working = false;

Console.Write("Please enter your name: ");

fullName = Console.ReadLine();


Console.Write("Please enter your age: ");

age = Convert.ToInt32(Console.ReadLine());


Console.Write("Please enter your salary:");
salary = Convert.ToDouble(Console.ReadLine());


Console.Write("Please enter your gender: ");

gender = Convert.ToChar(Console.ReadLine());

Console.Write("Please enter if working");

working= Convert.ToBoolean(Console.ReadLine());



Console.WriteLine("Entered name : " + fullName);
Console.WriteLine($"Entered age : {age}");
Console.WriteLine($"Entered salary :{salary}");
Console.WriteLine($"Entered gender: {gender}");
Console.WriteLine($"Enter working or not: {working}");



//comment

//multiple commenting
/**
 * 
 * */


