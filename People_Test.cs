using System;
using System.Collections.Generic;
using System.Text;
using Assignment3.Model;
using Assignment3.Data;
using Xunit;

namespace Assignment3_UnitTest
{
    public class People_Test
    {
        [Fact]
        public void PeopleTest_TestCase_8a()
        {
            //test to check personArray is not NULL & empty.

            //Arrange
            Person[] expectedPersonArray;
            int expectedPersonArraySize = 0;
            int actualPersonArraySize = 0;


            //Act
            People people = new People();
            expectedPersonArray = people.FindAll();
            actualPersonArraySize = people.Size();

            //Assert
            Assert.NotNull(expectedPersonArray);
            Assert.Equal(expectedPersonArraySize, actualPersonArraySize);

        }

        [Fact]
        public void PeopleTest_TestCase_8b()
        {
            //testing the Size() method of People class: 
            //test to check that personArray size increases when a Person is added to the array.

            //Arrange
            int expectedPersonArraySize = 0;
            int actualPersonArraySize = 0;

            //Act
            People people = new People();
            actualPersonArraySize = people.Size();

            //Assert
            Assert.Equal(expectedPersonArraySize, actualPersonArraySize); //here the expected personArray size is 0

            //Act
            Person person = new Person("Shreya", "Sai");
            people.addPersonToPeopleArray(person);
            expectedPersonArraySize++;
            actualPersonArraySize = people.Size();

            //Assert
            Assert.Equal(expectedPersonArraySize, actualPersonArraySize); //here the expected personArray size is 1

        }

        [Fact]
        public void PeopleTest_TestCase_8c()
        {
            //testing the FindAll() method of People class: 
            //test to check that a NOT NULL personArray object is being returned by FindAll().

            //Arrange
            Person[] expectedPersonArray;

            //Act
            People people = new People();
            expectedPersonArray = people.FindAll();

            //Assert
            Assert.NotNull(expectedPersonArray); //should be not null
        }

        [Fact]
        public void PeopleTest_TestCase_8d()
        {
            //testing the FindById() method of People class: 
            //test to check whether this method retruns the same person that was created here.

            //Arrange
            int expectedPersonID;
            int actualPersonID;
            String fname = "TestFname";
            String lname = "TestLname";
            
            //Act
            People people = new People();
            Person expectedPerson=people.addNewPerson(fname,lname);
            expectedPersonID = expectedPerson.PersonId;

            Person actualPerson = people.FindById(expectedPersonID);
            actualPersonID = actualPerson.PersonId;

            //Assert
            Assert.Equal(expectedPersonID, actualPersonID); //should be not null
        }

        [Fact]
        public void PeopleTest_TestCase_8f()
        {
            //testing the Clear() method of People class: 
            //test to check whether this method retruns an NULL personArray.

            //Arrange
            int expectedPersonArraySize = 0;
            int actualPersonArraySize = 0;


            //Act
            People people = new People();
            people.Clear();
            actualPersonArraySize = people.Size();

            //Assert
            Assert.Equal(expectedPersonArraySize, actualPersonArraySize); //array size should be 0
        }

        [Fact]
        public void People_TestCase_11a()
        {
            //Arrange
            int expectedMatchCount = 0;
            Person[] allLeftPersons;
            People people = new People();

            Person p1 = new Person(1, "1-fname", "1-lname");
            Person p2 = new Person(2, "2-fname", "2-lname");
            Person p3 = new Person(3, "3-fname", "3-lname");

            //Act
            people.addPersonToPeopleArray(p1);
            people.addPersonToPeopleArray(p2);
            people.addPersonToPeopleArray(p3);

            people.removePersonFromPersonArray(p2);
            allLeftPersons = people.FindAll();
            expectedMatchCount = 2;

            //Assert
            Assert.Equal(expectedMatchCount, allLeftPersons.Length);
        }

    }
}
