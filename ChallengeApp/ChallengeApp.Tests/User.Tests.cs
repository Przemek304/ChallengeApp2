namespace ChallengeApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void WhenFourNumberAReAdded_ShouldReturnSum1()
        {

            //arrange
            var user = new User("Adam" , "12345");
            user.AddGrade(5);
            user.AddGrade(-1);
            user.AddGrade(-7);
            user.AddGrade(6);
            // act 
            var result = user.Result;
            // assert

            Assert.Equal(3, result );

        }
        [Fact]
        public void WhenSixNumberAReAdded_ShouldReturnSum2()
        {

            //arrange
            var user = new User("Monika", "12345");
            user.AddGrade(5);
            user.AddGrade(6);
            user.AddGrade(-11);
            user.AddGrade(6);
            user.AddGrade(2);
            user.AddGrade(-1);

            // act 
            var result = user.Result;
            // assert

            Assert.Equal(7, result);

        }
        [Fact]
        public void WhenThreeNumberAReAdded_ShouldReturnSum3()
        {

            //arrange
            var user = new User("Michał", "12345");
            user.AddGrade(-2);
            user.AddGrade(6);
            user.AddGrade(-3);
            user.AddGrade(5);
            // act 
            var result = user.Result;
            // assert

            Assert.Equal(6, result);

        }
    }
}
