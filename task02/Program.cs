//Даны два числа. Показать большее и меньшее число
Console.WriteLine("Введите первое число");
double number01 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число");
double number02 = Convert.ToDouble(Console.ReadLine());
if (number01>number02)
{
    Console.WriteLine("Большее число " + number01);
    Console.WriteLine("Меньшее число " + number02);
}
else
{
    Console.WriteLine("Большее число " + number02);
    Console.WriteLine("Меньшее число " + number01);
}    