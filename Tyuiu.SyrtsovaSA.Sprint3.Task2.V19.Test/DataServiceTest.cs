using Tyuiu.SyrtsovaSA.Sprint3.Task2.V19.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint3.Task2.V19.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        DataService ds = new DataService();
        int startValue = 1;
        int stopValue = 10;
        double res = ds.GetSumSeries(startValue, stopValue);
        Assert.AreEqual(-0.289, res);
    } 
} 
