using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LiuPieShop.Models;
using LiuPieShop.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LiuPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository pieRepository;
        private readonly ICategoryRepository categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            this.pieRepository = pieRepository;
            this.categoryRepository = categoryRepository;
        }


        public ViewResult List()
        {

            PieListViewModel viewModel = new PieListViewModel();
            viewModel.Pies = this.pieRepository.AllPies;
            viewModel.CurentCategory = "Cheese Cake";

            return View(viewModel);
        }
    }
}
