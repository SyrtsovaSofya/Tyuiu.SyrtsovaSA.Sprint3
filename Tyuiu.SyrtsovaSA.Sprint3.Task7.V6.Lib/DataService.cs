using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SyrtsovaSA.Sprint3.Task7.V6.Lib;

public class DataService : ISprint3Task7V6
{
    public double[] GetMassFunction(int startValue, int stopValue)
    {
        double[] valueArray = new double[stopValue - startValue + 1];
        double y;
        int count = 0;
        for (int i = startValue; i <= stopValue; i++)
        {
            if(i == 0)
                y = 0;
            else
                y = Math.Round(3 * Math.Cos(i) / (4 * i - 0.5) + Math.Sin(i) - 5 * i - 2, 2);
            valueArray[count++] = y;
        }
        return valueArray;
    }
}
