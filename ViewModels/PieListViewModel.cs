using System;
using LiuPieShop.Models;
using System.Collections.Generic;
namespace LiuPieShop.ViewModels
{
    public class PieListViewModel
    {

        public IEnumerable<Pie> Pies { get; set; }
        public string CurentCategory { get; set; }
        
    }
}
