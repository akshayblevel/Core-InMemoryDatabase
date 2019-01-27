using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreInMemory
{
    public class ApiContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public ApiContext(DbContextOptions options) : base(options)
        {
            LoadCategories();
        }

        public void LoadCategories()
        {
            Category category = new Category() { CategoryName = "Category1" };
            Categories.Add(category);
            category = new Category() { CategoryName = "Category2" };
            Categories.Add(category);
        }

        public List<Category> GetCategories()
        {
            return Categories.Local.ToList<Category>();
        }
    }
}
