using System;
using System.Collections.Generic;
using System.Text;
using Assignment3.Data;
using Xunit;

namespace Assignment3_UnitTest
{
    public class PersonSequencerTest
    {
        [Fact]
        public void PersonIDTest2()
        {
            //Arrange
            int expectedPersonIdValue=0;  //this variable is used to set what should be the expected outcome of the test
            int actualPersonIDValue=0;     //this variable is used to contain the value that is actually getting calculated by the method

            //Act
            actualPersonIDValue = PersonSequencer.nextPersonId();
            expectedPersonIdValue++;

            //Assert
            Assert.Equal(expectedPersonIdValue, actualPersonIDValue);
        }

        [Fact]
        public void PersonIDTest3()
        {
            //Arrange
            int expectedPersonIDValue = 0;
            int actualPersonIDValue = 0;

            //Act
            PersonSequencer.reset(); // reset the personid value to 0
            actualPersonIDValue = PersonSequencer.nextPersonId();  // again increment by 1

            expectedPersonIDValue++;   // expected value set to 1

            //Assert
            Assert.Equal(expectedPersonIDValue, actualPersonIDValue);
        }
    }
}
