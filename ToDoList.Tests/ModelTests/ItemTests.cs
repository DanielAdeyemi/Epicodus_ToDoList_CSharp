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
  // Arrange
            
            List<Item> newList = new List<Item> {};

            // Act
            List<Item> result = Item.GetAll();

            // Assert
            CollectionAssert.AreEqual(newList, result);
        }
    }
}
