using Tyuiu.SyrtsovaSA.Sprint3.Task3.V11.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint3.Task3.V11; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнила: Сырцова С.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #3                                                            *"); 
        Console.WriteLine("* Тема: Оператор цикла foreach                                         *"); 
        Console.WriteLine("* Задание #3                                                           *"); 
        Console.WriteLine("* Вариант #11                                                          *"); 
        Console.WriteLine("* Выполнила: Сырцова Софья Алексеевна | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ: Используя цикл foreach заменить буквы q на цифру 7 в строке:*"); 
        Console.WriteLine("* sqwreq vqwqq q                                                       *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");
        string value = "sqwreq vqwqq q";
        char replaceable = 'q';
        char replacement = '7';
        Console.WriteLine($"Исходная строка = {value}");
        Console.WriteLine($"Искомый символ = {replaceable}");
        Console.WriteLine($"Символ для замены = {replacement}");
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine($"Ответ = {ds.ReplaceCharOnNum(value, replaceable, replacement)}"); 
    } 
} 
