

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Fact]
        public void WhenTwoIntsAreAdded_IntsShouldBeTheSame()
        {

            //arrange
            int number1 = 45;
            int number2 = 45;



            // act 

            // assert
            Assert.Equal(number1 , number2);



        }
        [Fact]
        public void WhenTwoFloatsAreAdded_FloatsShouldBeTheSame()
        {

            //arrange
            float number1 = 433.4f;
            float number2 = 433.4f;


            // act 

            // assert
            Assert.Equal(number1, number2);



        }
        [Fact]
        public void WhenTwoStringsAreAdded_ShouldReturnSum()
        {

            //arrange
            string var1 = "Przemek";
            string var2 = "Worończuk";



            // act 

            string result = var1 + var2;

            // assert
            Assert.Equal("PrzemekWorończuk", result);



        }

        //
        //  REFERENCYJNE
        //
        //

        [Fact]
        public void WhenGetTwoUsers_ShouldCheckTheirNames()
        {

            //arrange
            var user1 = GetUser1("Adam");

            var user2 = GetUser1("Adam");


            // act 

            // assert
            Assert.Equal(user1.Name, user2.Name);

        }

        private User GetUser1(string name)
        {
            return new User(name);
        }



       
    }
}
