using tyuiu.cources.programming.interfaces.Sprint3; 
 
namespace Tyuiu.SyrtsovaSA.Sprint3.Task5.V12.Lib;

public class DataService : ISprint3Task5V12
{
    public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
    {
        double y = 0;
        for(int i = startValue1; i <= stopValue1; i++)
            for (int j = startValue2; j <= stopValue2; j++)
                y += Math.Cos(j) + x / 2;
        return Math.Round(y,3);
    }
} 
