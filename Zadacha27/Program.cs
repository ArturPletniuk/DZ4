//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int Sum_of_numbers(int number_x)
{
    if (number_x < 0) number_x *= -1;
    int sum_of_numbers = 0;
    while (number_x > 0)
    {
        int Cycle_Sum = number_x % 10;
        number_x = (number_x / 10);
        sum_of_numbers += Cycle_Sum;
    }
    return sum_of_numbers;
}
Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int Method_Call_Sum_of_numbers = Sum_of_numbers(number);
Console.WriteLine(Method_Call_Sum_of_numbers);
Console.Write("Exit.");
Console.ReadLine();

