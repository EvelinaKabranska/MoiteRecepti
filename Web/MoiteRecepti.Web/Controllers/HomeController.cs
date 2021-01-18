namespace MoiteRecepti.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using MoiteRecepti.Data;
    using MoiteRecepti.Data.Common.Repositories;
    using MoiteRecepti.Data.Models;
    using MoiteRecepti.Services.Data;
    using MoiteRecepti.Web.ViewModels;
    using MoiteRecepti.Web.ViewModels.Home;

    // 1. ApplicationDbContext
    // 2. Repositories
    // 3. Service
    public class HomeController : BaseController
    {
        private readonly IGetCountsService countsService;
        // 2.2 private readonly IMapper mapper;

        // 1 public HomeController(IGetCountsService countsService)
        // 2.2 public HomeController(IGetCountsService countsService, IMapper mapper)
        public HomeController(IGetCountsService countsService)
        {
            // 1 this.countsService = countsService;
            // 2.2 this.mapper = mapper;
            this.countsService = countsService;
        }

        public IActionResult Index()
         {
            var counts = this.countsService.GetCounts();
            var viewModel = new IndexViewModel
         { 
            CategoriesCount = counts.CategoriesCount,
            ImagesCount = counts.ImagesCount,
            IngredientsCount = counts.IngredientsCount, 
            RecipesCount = counts.RecipesCount,
         };
            return this.View(viewModel);
         }

        // 2.2 public IActionResult Index()
        // 2.2 {
        // 2.2    var countsDto = this.countsService.GetCounts();
        // 2.2    var viewModel = this.mapper.Map<IndexViewModel>(countsDto);
        // 2.2    return this.View(viewModel);
        // 2.2 }

        // 1 public IActionResult Index()
        // 1 {
        // 1    var viewModel = this.countsService.GetCounts();
        // 1    return this.View(viewModel);
        // 1 }

        // 2.1 public IActionResult Index()
        // 2.1 {
        // 2.1 var counts = this.countsService.GetCounts();
        // 2.1 var viewModel = new IndexViewModel
        // 2.1 { 
        // 2.1 CategoriesCount = counts.CategoriesCount,
        // 2.1 ImagesCount = counts.ImagesCount,
        // 2.1 IngredientsCount = counts.IngredientsCount, 
        // 2.1 RecipesCount = counts.RecipesCount,
        // 2.1 };
        // 2.1 return this.View(viewModel);
        // 2.1 }
        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
