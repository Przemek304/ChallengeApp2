﻿namespace ChallengeApp.Tests
{
    public class Tests
    {
       

        [Test]
        public void Test1()
        {
            // arrange
            int age1 = 10;
            int age2 = 3;


            // act
            int result = age1 + age2;

            // assert

            Assert.Equals(13 , result);

        }
    }
}
