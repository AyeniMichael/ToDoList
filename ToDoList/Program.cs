using System;
using System.Collections.Generic;
using ToDoList.Models;


namespace ToDoList
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to ToDoList App");
            Console.WriteLine("Would you like to add an item to your list or View Your List? (Add/View)");
            string inputString = Console.ReadLine();
            if(inputString == "Add")
            {
                Add();
            }
            else if (inputString == "View")
            {
                Console.WriteLine("Youve not added anything");
                Main();
            }
            else
            {
                Console.WriteLine("You entered an invalid option");
                Main();
            }
        }

        static void Add()
        {
            Console.WriteLine("Enter your Item:");
            string inputItem = Console.ReadLine();
            Item newItem = new Item(inputItem);
            Console.WriteLine("Your Item has successfully added to the List");
            Console.WriteLine("Would you Like to Add another Item or View your Items? (Add/View)");
            string reply = Console.ReadLine();
            if (reply == "Add")
            {
                Add();
            }
            else if (reply == "View")
            {
                View();
            }
            else
            {
                Console.WriteLine("You entered an invalid option");
            }
        }

        static void View()
        {
            List<Item> newList = Item.GetAll();
            foreach (Item task in newList)
            {
                Console.WriteLine(task.Description);
            }
            Console.WriteLine("Do you still want to add more items? (Yes/No)");
            string answer = Console.ReadLine();
            if (answer == "Yes")
            {
                Add();
            }
            else
            {
                Console.WriteLine("GoodBye");
            }
        }

    }
}