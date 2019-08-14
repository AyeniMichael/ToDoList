using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using ToDoList.Models;

namespace ToDoList.Tests
{
    [TestClass]
    public class ItemTest : IDisposable
    {
        public void Dispose()
        {
            Item.ClearAll();
        }

        [TestMethod]
        public void ItemConstructor_CreateInstancesOfItems_Item()
        {
            Item newItem = new Item("item");
            Assert.AreEqual(typeof(Item), newItem.GetType());
        }

        [TestMethod]
        public void GetDescription_ReturnDescription_String()
        {
            //Arrange
            string description = "Eat Dinner";
            Item newItem = new Item(description);

            //Act
            string result = newItem.Description;

            //Assert
            Assert.AreEqual(description, result);
        }

        [TestMethod]
        public void GetAll_ReturnsEmptyList_ItemsList()
        {
            //Arrange
            List<Item> newList = new List<Item> {};

            //Act
            List<Item> result = Item.GetAll();

            //Assert
            CollectionAssert.AreEqual(newList, result);

        }
    }
}