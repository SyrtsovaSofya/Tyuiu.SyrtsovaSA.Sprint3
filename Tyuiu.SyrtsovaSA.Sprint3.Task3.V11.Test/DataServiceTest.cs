using Tyuiu.SyrtsovaSA.Sprint3.Task3.V11.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint3.Task3.V11.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   { 
        DataService ds = new DataService();
        string str = "qq i qq";
        char replacealble = 'q';
        char replacement = '7';
        string res = ds.ReplaceCharOnNum(str, replacealble, replacement);
        Assert.AreEqual("77 i 77", res);

   } 
} 
