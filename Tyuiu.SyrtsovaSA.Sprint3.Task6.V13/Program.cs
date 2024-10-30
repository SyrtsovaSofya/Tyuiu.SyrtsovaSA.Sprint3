using Tyuiu.SyrtsovaSA.Sprint3.Task6.V13.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint3.Task6.V13; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        var ds = new DataService();
        Console.Title = "Спринт #3 | Выполнила: Сырцова С.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #3                                                            *"); 
        Console.WriteLine("* Тема: Обработка целочисленной информации                             *"); 
        Console.WriteLine("* Задание #6                                                           *"); 
        Console.WriteLine("* Вариант #13                                                          *"); 
        Console.WriteLine("* Выполнила: Сырцова Софья Алексеевна | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ: Напишите программу, которая ищет среди целых чисел,         *"); 
        Console.WriteLine("* принадлежащих числовому отрезку [8, 17] сумму всех делителей больше 8*"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");
        int startValue = 8;
        int stopValue = 17;
        Console.WriteLine("Старт отрезка = " + startValue);
        Console.WriteLine("Конец отрезка = " + stopValue);
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************");
        Console.WriteLine($"Сумма делителей больше 8 = {ds.GetSumTheDivisors(startValue, stopValue)}");
    } 
} 
