using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the To Do List");
            Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
            string reply = Console.ReadLine();
            if (reply != "Add" && reply != "View" && string.IsNullOrEmpty(reply))
            {
                Console.WriteLine("Error! Please respond to the previous question with \"Add\" or \"View\"");
                Main();
            }
            else if(reply == "Add")
            {
                // Console.WriteLine("Please enter the description for the new item.");
                // reply = Console.ReadLine();
                // Item newItem = new Item(reply);
                // Main();
                Item.GetAll().ForEach(x => {
                Console.WriteLine($"{x.counter}. {x.Description}");
                });
                Main();

            }
            else
            {
                List<Item> test = Item.GetAll();
                foreach(Item todo in test)
                {
                    Console.WriteLine(todo.Description);
                }
            Main();
            }

        }
    }
}
