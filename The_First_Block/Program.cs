// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длинна которых меньше либо равна 3.
Console.Clear();

int count = 0;
void FillArray(string[] arrFull)
{
    int count = 0;
    for (int i = 0; i < arrFull.Length; i++)
    {
        string arr1;
        arr1 = arrFull[i];
        if (arr1.Length <= 3)
        {
            count++;
        }
    }
    string[] newArrFull = new string[count];
    for (int j = 0; j < arrFull.Length; j++)
    {
        string arr2;
        arr2 = arrFull[j];
        if (arr2.Length <= 3)
        {
            newArrFull[j] = arrFull[j];
        }
    }
    for (int k = 0; k < newArrFull.Length; k++)
    {
        Console.Write($"{newArrFull[k]} ");
    }
    Console.WriteLine();
}

string array1 = Console.ReadLine();
count++;

string array2 = Console.ReadLine();
count++;

string array3 = Console.ReadLine();
count++;

string array4 = Console.ReadLine();
count++;

string[] fullArray = new string[count];
FillArray(fullArray);