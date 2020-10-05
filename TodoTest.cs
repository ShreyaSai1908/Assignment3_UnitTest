using System;
using System.Collections.Generic;
using System.Text;
using Assignment3.Model;
using Xunit;

namespace Assignment3_UnitTest
{
    public class TodoTest
    {
        [Fact]
        public void Todo_ObjectTest()
        {
            //Arrange
            //Test for take in todoId(int) and a description(String)
            string description = "";

            //Act
            Todo result = new Todo(description);

            //Assert
            Assert.NotNull(result);

        }
    }
}
