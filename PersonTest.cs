using Assignment3.Model;
using System;
using Xunit;

namespace Assignment3_UnitTest
{
    public class PersonTest
    {
        [Fact]
        public void personNameTest1()
        {
            //test for null - should fail
            //Arrange   
            string firstName = null;
            string lastName = null;
            
            //Act
            Person result = new Person(firstName, lastName);

            //Assert
            Assert.NotNull(result);     // to test that if the object is null or not


        }

        [Fact]
        public void personNameTest2()
        {
            //test for white space - should fail
            //Arrange   
            string firstName = " ";
            string lastName = " ";

            //Act
            Person result = new Person(firstName, lastName);

            //Assert
            Assert.NotNull(result);    // to test that if the object is empty or not

        }

        [Fact]
        public void personNameTest3()
        {
            //test for proper name - should pass
            //Arrange   
            string firstName = "ProperFirstName";
            string lastName = "ProperLastName";

            //Act
            Person result = new Person(firstName, lastName);

            //Assert
            Assert.NotNull(result);   // to test that if the object is created or not

        }

    }
}
