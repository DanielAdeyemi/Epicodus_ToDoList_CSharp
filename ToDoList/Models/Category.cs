using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Category
  {
    public Category()
    {
      this.JoinEntities = new HashSet<CategoryItem>();
    }
    public virtual ICollection<CategoryItem> JoinEntities { get; set; }

    public int CategoryId { get; set; }
    public string Name { get; set; }
  }
}