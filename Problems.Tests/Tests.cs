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

            exp = Program.Prefix("");
            Assert.That( exp, Is.EqualTo("0,0:"));

            exp = Program.Prefix("what    ...  did you say?? ");
            Assert.That( exp, Is.EqualTo("27,5:what    ...  did you say?? "));

            exp = Program.Prefix("hello there. general kenobi");
            Assert.That( exp, Is.EqualTo("27,4:hello there. general kenobi"));

            exp = Program.Prefix("... ?");
            Assert.That( exp, Is.EqualTo("5,2:... ?"));

            exp = Program.Prefix(" ");
            Assert.That( exp, Is.EqualTo("1,0: "));
            
        }
        
    }
}