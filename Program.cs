// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, i just started to write in C#");
//Console.WriteLine("The current time is " + DateTime.Now);

//Console.Write("Please enter your name: ");
//string name = Console.ReadLine();
//Console.WriteLine("Hello, " + name);
Console.Write("Enter an integer: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0){
    Console.WriteLine("Even");
}else{
    Console.WriteLine("Odd");
}