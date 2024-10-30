using Tyuiu.SyrtsovaSA.Sprint3.Task6.V13.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint3.Task6.V13.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        var ds = new DataService();
        int startValue = 8;
        int stopValue = 17;
        int res = ds.GetSumTheDivisors(startValue, stopValue);
        Assert.AreEqual(117, res);
    } 
} 
