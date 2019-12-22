using System;
using System.Collections.Generic;

namespace LiuPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public MockCategoryRepository()
        {
        }

        public IEnumerable<Category> AllCategories
        {
            get
            {
                List<Category> temp = new List<Category>
                {
                    new Category{CategoryId=1, CategoryName="Fruit pies", Description="All-fruity pies"},
                    new Category{CategoryId=2, CategoryName="Cheese cakes", Description="Cheesy all the way"},
                    new Category{CategoryId=3, CategoryName="Seasonal pies", Description="Get in the mood for a seasonal pie"}
                };
                
                return temp;
            }
        }
    }
}
