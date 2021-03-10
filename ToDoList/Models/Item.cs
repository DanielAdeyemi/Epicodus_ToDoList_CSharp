
namespace ToDoList.Models
{
  public class Item
  {
    public string Description { get; set; }
    public int ItemId { get; set;}
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }

  }
}