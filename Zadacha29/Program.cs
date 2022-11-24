// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] array = new int[8];
void FillArray(int[]method_array)
{
    for(int i = 1;i < method_array.Length;i++)
    {
        method_array[i] = new Random().Next(0,101); // Я выбрал диапазон чисел от 0 до 100
    }
}
void PrintArray(int[] method_array)
{
    Console.Write("[");
    for(int i = 0;i < method_array.Length - 1;i++)
    {
        Console.Write($"{method_array[i]}, ");
    }
    Console.Write($"{method_array[7]}");
    Console.Write("]");
}
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Выход.");
Console.ReadLine();