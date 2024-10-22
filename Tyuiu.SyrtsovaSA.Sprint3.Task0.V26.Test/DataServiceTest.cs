using Tyuiu.SyrtsovaSA.Sprint3.Task0.V26.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint3.Task0.V26.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   { 
        DataService ds = new DataService();
        int startValue = 1;
        int stopValue = 9;
        double res = ds.GetMultiplySeries(startValue, stopValue);
        Assert.AreEqual(-15.642, res);
   } 
} 
