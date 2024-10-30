using Tyuiu.SyrtsovaSA.Sprint3.Task7.V6.Lib;

namespace Tyuiu.SyrtsovaSA.Sprint3.Task7.V6.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidGetMassFunction()
    {
        var ds = new DataService();
        int startValue = -5;
        int stopValue = 5;
        int len = stopValue - startValue + 1;
        double[] valueWainArray = [23.92, 18.88, 13.10, 7.24, 1.8, 0, -5.7, -11.26, -17.12, -22.88, -27.92];
        double[] res = ds.GetMassFunction(startValue, stopValue);
        CollectionAssert.AreEqual(valueWainArray, res);
    }
}
