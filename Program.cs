// Напишите цикл, который принимает на вход число два числа (А и В) и вохводит числа в натуральную
// степень (В).

Console.WriteLine("Введите число А");
int A = Convert.ToInt32(Console.ReadLine( ));
Console.WriteLine("Введите число В");
int B = Convert.ToInt32(Console.ReadLine( ));

if (B >= 0)
{
    int result = 1;
    for (int y = 0; y < B; y ++)
    {
         result = result * A;
    }
    Console.WriteLine($"{A} в степени {B} присваиваем результат {result}");
}
else 
{
    Console.WriteLine($"{B} не натуральное число.");
}
 
