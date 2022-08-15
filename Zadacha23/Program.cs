// Напишите программу, которая принимает на вход число (N) и выдаёт
// таблицу кубов чисел от 1 до N.

void kyb (int number)
{
    int index = 1;
    while (index < number)
    {
        Console.Write($"{index*index*index}, ");
        index++;
    }
    Console.Write($"{index*index*index} " );
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
kyb(num);
