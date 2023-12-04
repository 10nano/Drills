// Program, który znajdzie maksymalną liczbę spośród trzech podanych liczb.

Console.WriteLine("Podaj 3 liczby csłokowite do porównania:");
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int number3 = int.Parse(Console.ReadLine());
int maxOfThree;

if (number1 > number2 && number1 > number3)
{
    maxOfThree = number1;
}
else if (number2 > number3)
{
    maxOfThree = number2;
}
else
{
    maxOfThree = number3;
}

Console.WriteLine($"Maksimum z powyższych liczb wynosi: {maxOfThree}");