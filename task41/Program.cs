// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел
// больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int[] FillArray(int length)
{
int[] array = new int[length];
for (int i = 0; i < length; i++)
{
    System.Console.WriteLine($"Введите число №{i+1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine()); 
}
System.Console.WriteLine(string.Join(", ", array));
return array;
}

void CountPositiveNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    System.Console.WriteLine(count);
}

System.Console.Write("Сколько чисел хотите ввести: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(m);
CountPositiveNum(array);