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

//FizzBuzz

Console.Write("Enter an Value: ");
int value = Convert.ToInt32(Console.ReadLine());
for(int start = 0; start <= value; start++){
    if(start % 3 == 0 && start % 5 == 0){
        Console.WriteLine("FizzBuzz" + " " + start);
    }else if(start % 3 == 0){
        Console.WriteLine("Fizz" + " " + start);
    }else if(start % 5 == 0){
        Console.WriteLine("Buzz" + " " + start);
    }else{
        Console.WriteLine("We don't know" + " " + start);
    }
}

//Pyramid
Console.Write("Enter pyramid size: ");
int how_much = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= how_much;i++){
    for(int j = 1; j <= i;j++){
        Console.Write(" * ");
    }
    Console.WriteLine("");
}

//A function in C#
int getAmount(int price,int pieces){
    return price * pieces;

}
Console.Write("Enter price: ");
int rate = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter pieces: ");
int pieces = Convert.ToInt32(Console.ReadLine());
int price_amnt = getAmount(rate,pieces);

Console.WriteLine($"Total price : {price_amnt}");

//operation and Variable and Expression