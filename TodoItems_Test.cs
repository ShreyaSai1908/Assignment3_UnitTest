using System;
using System.Collections.Generic;
using System.Text;
using Assignment3.Model;
using Assignment3.Data;
using Xunit;


namespace Assignment3_UnitTest
{
    public class TodoItems_Test
    {
        [Fact]
        public void TodoItems_TestCase_9a()
        {
            //test to check TodoArray is not NULL & empty.

            //Arrange
            Todo[] expectedTodoArray;
            int expectedTodoArraySize = 0;
            int actualTodoArraySize = 0;


            //Act
            TodoItems todoItems = new TodoItems();
            expectedTodoArray = todoItems.FindAll();
            actualTodoArraySize = todoItems.Size();

            //Assert
            Assert.NotNull(expectedTodoArray);
            Assert.Equal(expectedTodoArraySize, actualTodoArraySize);
        }

        [Fact]
        public void TodoItems_TestCase_9b()
        {
            //testing the Size() method of TodoItems class: 
            //test to check that todoArray size increases when a TodoItems is added to the array.

            //Arrange
            int expectedTodoArraySize = 0;
            int actualTodoArraySize = 0;

            //Act
            TodoItems todoItems = new TodoItems();
            actualTodoArraySize = todoItems.Size();

            //Assert
            Assert.Equal(expectedTodoArraySize, actualTodoArraySize); //here the expected todoArray size is 0

            //Act
            Todo todo = new Todo(1, "First Todo");
            todoItems.addToDoToTodoItemsArray(todo);
            expectedTodoArraySize++;
            actualTodoArraySize = todoItems.Size();

            //Assert
            Assert.Equal(expectedTodoArraySize, actualTodoArraySize); //here the expected todoArray size is 1

        }


        [Fact]
        public void TodoItems_TestCase_9c()
        {
            //testing the FindAll() method of TodoItems class: 
            //test to check that a NOT NULL todoArray object is being returned by FindAll().

            //Arrange
            Todo[] expectedTodoArray;

            //Act
            TodoItems todoItems = new TodoItems();
            expectedTodoArray = todoItems.FindAll();

            //Assert
            Assert.NotNull(expectedTodoArray); //should be not null
        }

        [Fact]
        public void TodoItems_TestCase_9d()
        {
            //testing the FindById() method of TodoItems class: 
            //test to check whether this method retruns the same todo that was created here.

            //Arrange
            int expectedTodoID;
            int actualTodoID;
            String desc = "TestDesc";

            //Act
            TodoItems todoItems = new TodoItems();
            Todo expectedTodo = todoItems.addNewTodo(desc);
            expectedTodoID = expectedTodo.TodoId;

            Todo actualTodo = todoItems.FindById(expectedTodoID);
            actualTodoID = actualTodo.TodoId;

            //Assert
            Assert.Equal(expectedTodoID, actualTodoID); //should be not null
        }

        [Fact]
        public void TodoItems_TestCase_9f()
        {
            //testing the Clear() method of TodoItems class: 
            //test to check whether this method retruns an NULL todoArray.

            //Arrange
            int expectedTodoArraySize = 0;
            int actualTodoArraySize = 0;


            //Act
            TodoItems todoItems = new TodoItems();
            todoItems.Clear();
            actualTodoArraySize = todoItems.Size();

            //Assert
            Assert.Equal(expectedTodoArraySize, actualTodoArraySize); //array size should be 0
        }

        [Fact]
        public void TodoItems_TestCase_10a()
        {
            //Arrange
            Todo[] allDoneToDo;
            TodoItems todoItems = new TodoItems();

            Todo todo1 = new Todo(1, "First Todo - Done");
            Todo todo2 = new Todo(2, "Second Todo - Ongoing");
            Todo todo3 = new Todo(3, "Third Todo - Done");

            //Act
            todo1.Done = true;
            todo2.Done = false;
            todo3.Done = true;

            todoItems.addToDoToTodoItemsArray(todo1);
            todoItems.addToDoToTodoItemsArray(todo2);
            todoItems.addToDoToTodoItemsArray(todo3);

            allDoneToDo = todoItems.FindByDoneStatus(true);

            //Assert
            foreach (Todo td in allDoneToDo)
            {
                Assert.Contains("Done", td.Description);
            }

        }

        [Fact]
        public void TodoItems_TestCase_10b()
        {
            //Arrange
            int matchingPersonID = 0;
            Todo[] allMatchingToDo;
            TodoItems todoItems = new TodoItems();           

            Todo todo1 = new Todo(1, "First Todo");
            Todo todo2 = new Todo(2, "Second Todo");
            Todo todo3 = new Todo(3, "Third Todo");

            Person p1 = new Person(1,"TestPerson", "Lname1");
            Person p2 = new Person(2,"AnyPerson", "Lname2");
            Person p3 = new Person(3,"FailPerson", "Lname3");

            //Act
            todo1.Assignee = p1;
            todo2.Assignee = p2;
            todo3.Assignee = p1;

            todoItems.addToDoToTodoItemsArray(todo1);
            todoItems.addToDoToTodoItemsArray(todo2);
            todoItems.addToDoToTodoItemsArray(todo3);

            allMatchingToDo = todoItems.FindByAssignee(p1.PersonId);
            matchingPersonID = p1.PersonId;

            //Assert
            foreach (Todo td in allMatchingToDo)
            {
                Assert.Equal(matchingPersonID, td.Assignee.PersonId);                
            }
        }

        [Fact]
        public void TodoItems_TestCase_10c()
        {
            //Arrange
            int matchingPersonID = 0;
            Todo[] allMatchingToDo;
            TodoItems todoItems = new TodoItems();

            Todo todo1 = new Todo(1, "First Todo");
            Todo todo2 = new Todo(2, "Second Todo");
            Todo todo3 = new Todo(3, "Third Todo");

            Person p1 = new Person(1, "TestPerson", "Lname1");
            Person p2 = new Person(2, "AnyPerson", "Lname2");
            Person p3 = new Person(3, "FailPerson", "Lname3");

            //Act
            todo1.Assignee = p1;
            todo2.Assignee = p2;
            todo3.Assignee = p1;

            todoItems.addToDoToTodoItemsArray(todo1);
            todoItems.addToDoToTodoItemsArray(todo2);
            todoItems.addToDoToTodoItemsArray(todo3);

            allMatchingToDo = todoItems.FindByAssignee(p1);
            matchingPersonID = p1.PersonId;

            //Assert
            foreach (Todo td in allMatchingToDo)
            {
                Assert.Equal(matchingPersonID, td.Assignee.PersonId);
            }
        }

        [Fact]
        public void TodoItems_TestCase_10d()
        {
            //Arrange
            int expectedMatchCount = 0;
            Todo[] allMatchingToDo;
            TodoItems todoItems = new TodoItems();

            Todo todo1 = new Todo(1, "First Todo");
            Todo todo2 = new Todo(2, "Second Todo");
            Todo todo3 = new Todo(3, "Third Todo");

            Person p1 = new Person(1, "TestPerson", "Lname1");
            Person p2 = new Person(2, "AnyPerson", "Lname2");

            //Act
            todo1.Assignee = p1;
            todo2.Assignee = null;
            todo3.Assignee = null;

            todoItems.addToDoToTodoItemsArray(todo1);
            todoItems.addToDoToTodoItemsArray(todo2);
            todoItems.addToDoToTodoItemsArray(todo3);

            allMatchingToDo = todoItems.FindUnassignedTodoItems();
            expectedMatchCount = 2;

            //Assert
            Assert.Equal(expectedMatchCount, allMatchingToDo.Length);
        }

        [Fact]
        public void TodoItems_TestCase_11a()
        {
            //Arrange
            int expectedMatchCount = 0;
            Todo[] allLeftToDo;
            TodoItems todoItems = new TodoItems();

            Todo todo1 = new Todo(1, "First Todo");
            Todo todo2 = new Todo(2, "Second Todo");
            Todo todo3 = new Todo(3, "Third Todo");

            //Act
            todoItems.addToDoToTodoItemsArray(todo1);
            todoItems.addToDoToTodoItemsArray(todo2);
            todoItems.addToDoToTodoItemsArray(todo3);

            todoItems.removeTodoFromToDoArray(todo2);
            allLeftToDo = todoItems.FindAll();
            expectedMatchCount = 2;

            //Assert
            Assert.Equal(expectedMatchCount, allLeftToDo.Length);
        }
    }
}
