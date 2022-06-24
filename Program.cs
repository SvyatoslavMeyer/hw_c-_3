// Задача 19: Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.

string number = "12321";
Palindrome(number);
string number1 = "223465";
Palindrome(number1);
Console.WriteLine();
Console.WriteLine();
void Palindrome(string CurrentNumber)
{
    Console.WriteLine("_________________ ");
    Console.WriteLine("Задача 19");
    if (CurrentNumber[0] == CurrentNumber[4] && CurrentNumber[1] == CurrentNumber[3])
    {
        Console.WriteLine($"Число {CurrentNumber} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {CurrentNumber} не является палиндромом");
    }
}


// Задача 21: Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

Random rand = new Random();
int x1 = rand.Next(0,10);
int y1 = rand.Next(0,10);
int z1 = rand.Next(0,10);

int x2 = rand.Next(0,10);
int y2 = rand.Next(0,10);
int z2 = rand.Next(0,10);

Console.WriteLine("_________________ ");
Console.WriteLine("Задача 21");
Console.WriteLine(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)));


// Задача 23: Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу кубов чисел от 1 до N. 
Console.WriteLine("_________________ ");
Console.WriteLine("Задача 23");
int N = rand.Next(0,10);
int counter = 1;
while(counter <= N)
{
    Console.WriteLine($"{counter} -> {Math.Pow(counter, 3)}");
    counter++;
}