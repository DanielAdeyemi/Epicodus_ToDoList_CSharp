using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Tests
{
    [TestClass]
    public class ItemTests : IDisposable
    {
        public void Dispose()
        {
            Item.ClearAll();
        }

        [TestMethod]
        public void ItemConstractor_CreateInstanceOfItem_Item()
        {
            Item newItem = new Item("test");
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

        [TestMethod]
        public void SetDescription_SetDescription_String()
        {
            string description = "Walk the dog";
            Item newItem = new Item(description);
            string updatedDescription = "Do the dishes";
            newItem.Description = updatedDescription;
            string result = newItem.Description;
            Assert.AreEqual(updatedDescription, result);
        }

       [TestMethod]
        public void GetAll_ReturnsEmptyList_ItemList()
        {
            List<Item> newList = new List<Item> {}; // Arrange
            List<Item> result = Item.GetAll(); // Act
            CollectionAssert.AreEqual(newList, result); // Assert
        }

        [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
  string description01 = "Walk the dog"; //Arrange
      string description02 = "Wash the dishes";
      Item newItem1 = new Item(description01);
      Item newItem2 = new Item(description02);
      List<Item> newList = new List<Item> { newItem1, newItem2 };
      List<Item> result = Item.GetAll(); //Act
      CollectionAssert.AreEqual(newList, result); //Assert
    }
    }
}
