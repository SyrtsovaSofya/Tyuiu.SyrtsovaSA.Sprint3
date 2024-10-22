using Tyuiu.SyrtsovaSA.Sprint3.Task1.V28.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint3.Task1.V28; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнила: Сырцова С.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #3                                                            *"); 
        Console.WriteLine("* Тема: Оператор цикла while                                           *"); 
        Console.WriteLine("* Задание #1                                                           *"); 
        Console.WriteLine("* Вариант #28                                                          *"); 
        Console.WriteLine("* Выполнила: Сырцова Софья Алексеевна | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ: Написать программу используя цикл while, которая вычисляет  *"); 
        Console.WriteLine("* сумму ряда по формуле, при a=0,5.                                    *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");
        double value = 0.5;
        int startValue = 1;
        int stopValue = 9;
        Console.WriteLine("Переменная а = " + value);
        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine($"Сумма ряда = {ds.GetSumSeries(value, startValue, stopValue)}");
    } 
} 
