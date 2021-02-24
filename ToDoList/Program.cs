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
            }
            else if(reply == "Add")
            {
                // Add branch
            }
            else
            {
                // View branch
            }

        }
    }
}
