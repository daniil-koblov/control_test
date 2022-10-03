// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длинна которых меньше либо равна 3.
Console.Clear();

void FillArray(string[] arrFull, int a)
{
    int count = 0;
    for (int i = 0; i < arrFull.Length; i++)
    {
        if(arrFull[i].Length <= a)
        {
            count++;
        }
    }
    string[] newArrFull = new string[count];
    for(int j = 0; j < newArrFull.Length; j++)
    {
        for(int g = 0; g < arrFull.Length; g++)
        {
            if(arrFull[g].Length <= a)
            {
                newArrFull[j] = arrFull[g];
                j++;
            }
        }
    }
    for (int k = 0; k < newArrFull.Length; k++)
    {
        Console.Write($"{newArrFull[k]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Программа ищет строки, кол-во символов в которых меньше введенного числа.");
Console.WriteLine();
Console.WriteLine("Введите число, на которое будет ориентироваться программа.");
int count = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Введите первую строку.");
var array1 = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("Введите вторую строку.");
var array2 = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("Введите третью строку.");
var array3 = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("Введите четвертую строку.");
var array4 = Console.ReadLine();
Console.WriteLine();

string[] fullArray = { $"{array1}", $"{array2}", $"{array3}", $"{array4}" };
Console.WriteLine($"Вывод строк, в которых кол-во символов рано {count}.");
FillArray(fullArray, count);