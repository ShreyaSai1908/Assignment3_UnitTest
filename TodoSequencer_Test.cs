using System;
using System.Collections.Generic;
using System.Text;
using Assignment3.Data;
using Xunit;

namespace Assignment3_UnitTest
{
    public class TodoSequencer_Test
    {
        [Fact]
        public void TodoIDTest1()
        {
            // This method test that Todo ID at the begining is not incremented and should be 0
            //Arrange
            int expectedTodoIdValue = 0;
            int actualTodoIDValue = 0;

            //Act
            TodoSequencer.reset();
            actualTodoIDValue = TodoSequencer.todoId;

            //Assert
            Assert.Equal(expectedTodoIdValue, actualTodoIDValue);
        }

        [Fact]
        public void TodoIDTest2()
        {
            // This method test that Todo ID is getting incremented by nextToDoId().
            //Arrange
            int expectedTodoIdValue = 0;
            int actualTodoIDValue = 0;

            //Act
            TodoSequencer.reset();
            TodoSequencer.nextToDoId();
            actualTodoIDValue = TodoSequencer.todoId;
            expectedTodoIdValue++;

            //Assert
            Assert.Equal(expectedTodoIdValue, actualTodoIDValue);
        }

        [Fact]
        public void TodoIDTest3()
        {
            // This method test that Todo ID is getting reset to 0 by reset().

            //Arrange
            int expectedTodoIdValue = 0;
            int actualTodoIDValue = 0;

            //Act
            TodoSequencer.nextToDoId(); //sets a non zero toDoId value
            TodoSequencer.reset();
            actualTodoIDValue = TodoSequencer.todoId;

            //Assert
            Assert.Equal(expectedTodoIdValue, actualTodoIDValue);
        }
    }
    
}
