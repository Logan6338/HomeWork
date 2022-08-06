Console.WriteLine("Напишите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine("Первое число больше второго");
}
else
if (numberA < numberB)
{
    Console.WriteLine("Первое число меньше второго");
}
else
{
    Console.WriteLine("Обы числа равны");
}