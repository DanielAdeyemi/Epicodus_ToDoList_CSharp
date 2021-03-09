using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
  public class ToDoListContext : DbContext
  {
    public DbSet<Item> Items { get; set; } //represents Items table
    public ToDoListContext(DbContextOptions options) : base(options) {}
  }
}