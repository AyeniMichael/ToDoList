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
            //Item.ClearAll();
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
            foreach (Item thisItem in result)
            {
                Console.WriteLine("Output from empty list GetAll test: " + thisItem.Description);
            }
            //Assert
            CollectionAssert.AreEqual(newList, result);

        }

        [TestMethod]
        public void GetAll_ReturnsListOfRecentItems_ListOfItems()
        {
            //Arrange
            string description1 = "Wash the Plates";
            string description2 = "Walk the Dog";
            Item newItem1 = new Item(description1);
            Item newItem2 = new Item(description2);
            List<Item> newList = new List<Item> {newItem1, newItem2};

            //Act
            List<Item> result = Item.GetAll();
            foreach (Item thisItem in result)
            {
                Console.WriteLine("Output from empty list GetAll test: " + thisItem.Description);
            }

            //Assert
            CollectionAssert.AreEqual(newList, result);

        }
    }
}