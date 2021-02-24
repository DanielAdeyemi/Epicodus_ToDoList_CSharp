using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;

namespace ToDoList.Tests
{
    [TestClass]
    public class ItemTests
    {
        [TestMethod]
        public void ItemConstractor_CreateInstanceOfItem_Item()
        {
            Item newItem = new Item();
            Assert.AreEqual(typeof(Item), newItem.GetType());
        }

        [TestMethod]
        public void GetDescription_ReturnsDescription_String()
        {
            string description = "Walk the dog."; //arrange
            Item newItem = new Item(description);
            string result = newItem.Description; //Act
            Assert.AreEqual(description, result); //assert
    }

    }
}
