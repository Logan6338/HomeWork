Console.WriteLine("Напишите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите третье число");
int numberD = Convert.ToInt32(Console.ReadLine());
int max = 0;

if ((numberA > numberB) && (numberA > numberD))
{
    Console.WriteLine(numberA);
}
else
if ((numberB > numberA) && (numberB > numberD))
{
    Console.WriteLine(numberB);
}
else
if ((numberD > numberA) && (numberD > numberB))
{
    Console.WriteLine(numberD);
}
