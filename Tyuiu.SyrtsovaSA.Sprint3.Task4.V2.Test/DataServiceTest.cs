using Tyuiu.SyrtsovaSA.Sprint3.Task4.V2.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint3.Task4.V2.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   { 
        DataService ds = new DataService();
        int startValue = -5;
        int stopValue = 5;
        double res = ds.Calculate(startValue, stopValue);
        Assert.AreEqual(0.104, res);
   } 
} 
