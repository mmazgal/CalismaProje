
using CalismaProje.Models;

namespace CalismaProje.Data 
{
    public class CategoryRepository
    {
        private static List<Category>? _category =null;
        static CategoryRepository()
        {
            _category = new List<Category>
            {
                new Category {CategoryId=1, Name="Bilgisayar", Description="Apple"},
                new Category {CategoryId=2, Name="Telefon", Description="Samsung"}
            };
        }
        public static List<Category>? Categories
        {
            get
            {
                return _category;
            }
        }
        public static void AddCategory(Category category)
        {
            _category.Add(category);
        }
        public static Category GetCategoryById(int id)
        {
            return _category.FirstOrDefault(p=>p.CategoryId==id);
        }
    }
}