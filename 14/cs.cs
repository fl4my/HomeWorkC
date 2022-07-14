Console.WriteLine("введите первое число:");
string? firstNumber = Console.ReadLine();
Console.WriteLine("введите второе число:");
string? secondNumber = Console.ReadLine();

if (firstNumber != null && secondNumber != null) {
int firstOutNumber = int.Parse(firstNumber);
int secondOutNumber = int.Parse(secondNumber);
int c = firstOutNumber % secondOutNumber;
string iext = "";

if (c == 0) {
iext = "да, второе число кратно первому";
Console.WriteLine(iext);
} else {
iext = "нет, второе число не кратно первому, остаток: " + c;
Console.WriteLine(iext);
}
}