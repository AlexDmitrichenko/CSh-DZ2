﻿//Задача 1 Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа Обязательна проверка на ввод чисел 
//больше/меньше 3-х знаков 456-> 5, 782-> 8, 918 -> 1
/*Console.WriteLine("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine()!);
if (num < 1000 && num > 99){
Console.WriteLine($"Вторая цифра равна {Convert.ToInt32((num/10)%10)}");
}
else Console.WriteLine("Вы ввели не верное число");*/
//Задача 2 Напишите программу, которая выводит третью цифру заданного числа
//или сообщает, что третьей цифры нет. Берем числа до 100000
//645-> 5, 78-> третьей цифры нет, 32679-> 6
/*Console.WriteLine("Введите любое число до 100 000: ");
int numb = int.Parse(Console.ReadLine()!);
if (numb < 100) Console.WriteLine("Третьей цифры нет");
if (numb < 1000 && numb > 99) {
Console.WriteLine($"Третья цифра равна {Convert.ToInt32(numb%10)}"); 
}
if (numb < 10000 && numb > 999) {
Console.WriteLine($"Третья цифра равна {Convert.ToInt32((numb/10)%10)}"); 
}
if (numb < 100000 && numb > 9999) {
Console.WriteLine($"Третья цифра равна {Convert.ToInt32((numb/100)%10)}"); 
}*/
//Задача 3 Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным. Обязательна проверка на ввод 
//числа <1 и >7, 6-> да, 7-> да, 1-> нет
/*Console.WriteLine("Введите цифру, обозначающую день недели: ");
int day = int.Parse(Console.ReadLine()!);
if (day < 1 || day > 7) Console.WriteLine("Вы ввели не верное число");
if (day == 1)
    Console.WriteLine("Цифра соответствует Понедельнику - это не выходной день");
if (day == 2)
    Console.WriteLine("Цифра соответствует Вторнику - это не выходной день");
if (day == 3)
    Console.WriteLine("Цифра соответствует Среде - это не выходной день");
if (day == 4)
    Console.WriteLine("Цифра соответствует Четвергу - это не выходной день");
if (day == 5)
    Console.WriteLine("Цифра соответствует Пятнице - это не выходной день");
if (day == 6)
    Console.WriteLine("Цифра соответствует Субботе - этот день выходной!");
if (day == 7)
    Console.WriteLine("Цифра соответствует Воскресенью - этот день выходной!");*/

