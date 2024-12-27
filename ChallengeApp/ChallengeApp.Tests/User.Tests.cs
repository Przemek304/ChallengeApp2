namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Fact]
        public void WhenFourNumberAReAdded_ShouldReturnSum1()
        {

            //arrange
            var user = new User("Adam", "12345");
            user.AddGrade(5);
            user.AddGrade(-1);
            user.AddGrade(-7);
            user.AddGrade(6);
            // act 
            var result = user.Result;
            // assert

            Assert.Equal(3, result);

        }
    }
}
