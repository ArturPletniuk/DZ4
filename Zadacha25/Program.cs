// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
double Degree(int number_x, int number_y)
{
    if (number_y > 0)
    {
        int counter = 0;
        int Composition = 1;
        while (counter != number_y)
        {
            Composition *= number_x;
            counter += 1;
        }
        return Composition;
    }
    else
    {
        return 1.1;   
    }  
}
Console.WriteLine("Введите число A:");
int number_a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int number_b = Convert.ToInt32(Console.ReadLine());
double Degree_number = Degree(number_a,number_b);
if (Degree_number == 1.1) Console.WriteLine("Число В не является натуральным.");
else
{
    Console.WriteLine($"Число {number_a} в степени {number_b} = {Degree_number}");
}
Console.Write("Выход.");
Console.ReadLine();
