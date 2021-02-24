using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    public string Description {get; set; }
    private static List<Item> _instances = new List<Item> {};
        public  int counter { get; set; } = 0;
        static int instanceCounter = 0;

    public Item(string description)
    {
      Description = description;
      _instances.Add(this); 
      instanceCounter++;
      counter = instanceCounter;
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}