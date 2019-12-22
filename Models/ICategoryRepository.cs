using System;
using System.Collections.Generic;
namespace LiuPieShop.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
