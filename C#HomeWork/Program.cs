Console.Write("Введите первое число: ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int Number2 = Convert.ToInt32(Console.ReadLine());

if (Number1 > Number2)
{
    Console.WriteLine($"{Number1} > {Number2}");
} else {
    Console.WriteLine($"{Number1} < {Number2}");
}

Console.Write("Введите первое число: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int Num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int Num3 = Convert.ToInt32(Console.ReadLine());

if (Num1 > Num2 && Num1 > Num3)
{
    Console.WriteLine(Num1);
} else if (Num2 > Num1 && Num2 > Num3) {
    Console.WriteLine(Num2);
} else {
    Console.WriteLine(Num3);
}

Console.WriteLine("Введите первое число: ");
int N1 = Convert.ToInt32(Console.ReadLine()); 

if (N1 % 2 == 0) {
    Console.WriteLine("Yes");
} else {
    Console.WriteLine("No");
}

Console.WriteLine("Введите первое число: ");
int Nu1 = Convert.ToInt32(Console.ReadLine()); 
int current = 0;
 while (Nu1 > current)
{   
    if (current + 2 > Nu1 )
    {
        break;
    } else {
        current += 2; 
    Console.WriteLine(current);
    }
}
