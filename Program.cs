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
int number = 10;
Console.WriteLine(number);

float float_number = 10.5f;
Console.WriteLine(float_number);

double double_number = 10.5;
Console.WriteLine(double_number);

bool is_true = true;
Console.WriteLine(is_true);

string name = "John";
Console.WriteLine(name);

char character = 'A';
Console.WriteLine(character);

//avearge marks
Console.WriteLine("AVERAGE MARKS");

Console.Write("Enter number of subjects : ");
int subjects = Convert.ToInt32(Console.ReadLine());
int sum_mark = 0;
for(int i = 1;i <= subjects;i++){
    Console.Write("Enter mark: ");
    sum_mark += Convert.ToInt32(Console.ReadLine());
}
int average = sum_mark / subjects;
Console.WriteLine($"Average : {average}");
//Temperature convert 
double ConverterTemp(int temp,char fromUnit,char toUnit){
    if (fromUnit == 'C' && toUnit == 'F')
    {
        return (temp * 9 / 5) + 32;
    }
    else if (fromUnit == 'F' && toUnit == 'C')
    {
        return (temp - 32) * 5 / 9;
    }
    return 0;
}
double Temperature_to_Fahren = ConverterTemp(36,'C','F');
Console.WriteLine($"36 C = {Temperature_to_Fahren} F");

//Searching from list
List<int> numbers = new List<int>();

while (true){
    Console.Write("Enter number to list: ");
    int value = Convert.ToInt32(Console.ReadLine());
    numbers.Add(5);
    Console.Write("Enter 'E' for exit: ");
    char character = Convert.ToChar(Console.ReadLine());
    if (character == 'E'){
        Console.WriteLine("Thanks");
        break;
    }
}
