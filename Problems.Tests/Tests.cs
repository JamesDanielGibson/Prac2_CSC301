using NUnit.Framework;
using Problems;
namespace Problems.Tests
{
    public class Tests
    {
      
        [Test]
        public static void Test1()
        {
            //Arrange
            Program p = new Program();
            
            string exp = Program.Prefix("hello");
            Assert.That( exp, Is.EqualTo("5,1:hello"));
        }
        [Test]
        public static void Test2()
        {
            Program p = new Program();
            
            string exp = Program.Prefix("");
            Assert.That( exp, Is.EqualTo("0,0:"));
        }
        [Test]
        public static void Test3()
        {
            Program p = new Program();
            
            string exp = Program.Prefix("what    ...  did you say?? ");
            Assert.That( exp, Is.EqualTo("27,5:what    ...  did you say?? "));
        }
    }
}