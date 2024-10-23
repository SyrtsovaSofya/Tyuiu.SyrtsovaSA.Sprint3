using tyuiu.cources.programming.interfaces.Sprint3; 
 
namespace Tyuiu.SyrtsovaSA.Sprint3.Task2.V19.Lib;

public class DataService : ISprint3Task2V19
{
    public double GetSumSeries(int startValue, int stopValue)
    {
        double sumSeries = 0;
        do
        {
            sumSeries += Math.Cos(startValue) / 2;
            startValue++;
        }
        while (startValue <= stopValue);
        return Math.Round(sumSeries, 3);
    }
} 