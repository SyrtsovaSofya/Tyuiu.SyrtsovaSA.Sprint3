using Tyuiu.SyrtsovaSA.Sprint3.Task5.V12.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint3.Task5.V12; 
 
class Program 
{ 
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнила: Сырцова С.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #3                                                            *"); 
        Console.WriteLine("* Тема: Вложенные циклы                                                *"); 
        Console.WriteLine("* Задание #5                                                           *"); 
        Console.WriteLine("* Вариант #12                                                          *"); 
        Console.WriteLine("* Выполнила: Сырцова Софья Алексеевна | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("*                                                                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");
        int x = 5;
        int startvalue1 = 1;
        int stopvalue1 = 3;
        int startvalue2 = 1;
        int stopvalue2 = 10;
        Console.WriteLine("Переменная Х = " + x);
        Console.WriteLine("Старт шага первой суммы ряда = " + startvalue1);
        Console.WriteLine("Конец шага первой суммы ряда = " + stopvalue1); 
        Console.WriteLine("Старт шага второй суммы ряда = " + startvalue2);
        Console.WriteLine("Конец  шага второй суммы ряда = " + stopvalue2);
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************");
        Console.WriteLine($"Сумма ряда = {ds.GetSumSumSeries(x, startvalue1, stopvalue1, startvalue2, stopvalue2)}");
    } 
} 
