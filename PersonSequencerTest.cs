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
            int expectedPersonIdValue = 0;
            int actualPersonIDValue = 0;

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
            PersonSequencer.reset();
            actualPersonIDValue = PersonSequencer.PersonId;
            
            //Assert
            Assert.Equal(expectedPersonIDValue, actualPersonIDValue);
        }
    }
}
