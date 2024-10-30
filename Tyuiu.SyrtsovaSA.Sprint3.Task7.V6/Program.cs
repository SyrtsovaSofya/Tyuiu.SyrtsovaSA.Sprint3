using Tyuiu.SyrtsovaSA.Sprint3.Task7.V6.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint3.Task7.V6; 
 
class Program 
{ 
    static void Main(string[] args) 
    {
        var ds = new DataService();
        Console.Title = "Спринт #3 | Выполнила: Сырцова С.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #3                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #7                                                           *"); 
        Console.WriteLine("* Вариант #6                                                           *"); 
        Console.WriteLine("* Выполнила: Сырцова Софья Алексеевна | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Написать программу, которая выводит таблицу значений функции,        *");
        Console.WriteLine("* (произвести табулирование) f(x) на заданном диапазоне [-5;5] с шагом *");
        Console.WriteLine("* 1. Произвести проверку деления на ноль. При делении на ноль вернуть  *");
        Console.WriteLine("* значение 0. Значения округлить до двух знаков после запятой.         *");
        Console.WriteLine("* Значения занести в массив!                                           *");
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");
        int startValue = -5;
        int stopValue = 5;
        Console.WriteLine(" Старт шага = " + startValue);
        Console.WriteLine(" Конец шага = " + stopValue);
        double[] valueArray = ds.GetMassFunction(startValue, stopValue);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("+----------+----------+");
        Console.WriteLine("|    X     |    F(x)  |");
        Console.WriteLine("+----------+----------+");
        for (int i = 0; i <= valueArray.Length - 1; i++)
        {
            Console.WriteLine("|{0,5:d}     |  {1, 5:f2}   |", startValue, valueArray[i]);
            startValue++;
        }
        Console.WriteLine("+----------+----------+");
        Console.ReadKey();
    } 
} 
