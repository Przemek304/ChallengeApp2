namespace ChallengeApp.Tests
{
    public class Tests
    {
       

        [Test]
        public void Test1()
        {
            //arrange

            int number1 = 5;
            int number2 = 10;
            
            //act

            int result = number1 + number2;

            //assert

            Assert.(number1, number2);
            
        }
    }
}
