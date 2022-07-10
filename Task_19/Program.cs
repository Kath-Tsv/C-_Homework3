// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine ("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine ());
Task19 (number);

void Task19(int value)
{
    if (9999<value && value<100000)
    {
        int first = value/10000;
        Console.WriteLine ($"first = {first}");
        int second = value%10000/1000;
        Console.WriteLine ($"second = {second}");
        int fourth = value%100/10;
        Console.WriteLine ($"fourth = {fourth}");
        int fith = value%10;
        Console.WriteLine ($"fith = {fith}");
        if (first == fith && second == fourth)
        {
            Console.WriteLine ($"Число {value} является палиндромом.");
        }
        else 
        {
            Console.WriteLine ($"Число {value} не является палиндромом.");
        }
    }
    else 
    {
        Console.WriteLine ($"Число {value} не является пятизначным.");
    }
}