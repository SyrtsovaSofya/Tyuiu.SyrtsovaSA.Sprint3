using tyuiu.cources.programming.interfaces.Sprint3; 
 
namespace Tyuiu.SyrtsovaSA.Sprint3.Task0.V26.Lib;

public class DataService : ISprint3Task0V26
{
    public double GetMultiplySeries(int startValue, int stopValue)
    {
        double multiplySeries = 1;
        for (int i = startValue; i <= stopValue; i++)
        {
            multiplySeries *= Math.Pow(2, i) / (i + 1) * Math.Cos(1.8);
        }
        return Math.Round(multiplySeries, 3);
    }
} 
