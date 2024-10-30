using Tyuiu.SyrtsovaSA.Sprint3.Task5.V12.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint3.Task5.V12.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        DataService ds = new DataService();
        int x = 5;
        int startvalue1 = 1;
        int stopvalue1 = 3;
        int startvalue2 = 1;
        int stopvalue2 = 10;
        var res = ds.GetSumSumSeries(x, startvalue1, stopvalue1, startvalue2, stopvalue2);
        Assert.AreEqual(14.458, res);
   } 
} 
