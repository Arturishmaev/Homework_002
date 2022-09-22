// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


System.Console.WriteLine("Введите Ваше трехзначное число :");
int num = Convert.ToInt32(Console.ReadLine());
string threeDigitNumber = Convert.ToString(num);
if (threeDigitNumber.Length > 2)
{
     Console.WriteLine("вторая цифра :  " + threeDigitNumber[1]);
}




//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

System.Console.WriteLine("Введите Ваше число : ");
int num1 = Convert.ToInt32(Console.ReadLine());
string number = Convert.ToString(num1);
if(number.Length > 2)
{
    System.Console.WriteLine("Третья (слева) цифра числа :" + number[2]);
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

System.Console.WriteLine("Введите число : ");
int day = Convert.ToInt32(Console.ReadLine());
if(day == 1)
{
    System.Console.WriteLine("Понедельник");
}
else if (day == 2)
{
    System.Console.WriteLine("Вторник");
}
else if (day == 3)
{
    System.Console.WriteLine("Среда");
}
else if (day == 4)
{
    System.Console.WriteLine("Четверг");
}
else if (day == 5)
{
    System.Console.WriteLine("Пятница");
}
else if (day == 6)
{
    System.Console.WriteLine("Суббота - выходной день!");
}
else if (day == 7)
{
    System.Console.WriteLine("Воскресенье - выходной день!");
}
else
{
    System.Console.WriteLine("EROR");
}