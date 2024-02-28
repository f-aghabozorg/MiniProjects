using LINQ_WebApp.Models;
using LINQ_WebApp.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Xml.Linq;

namespace LINQ_WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ProductRepository repo = ProductRepository.Current;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //نمایش تمام محصولات
            var result = repo.GetAll();
            return View(result);
        }

        public IActionResult Query1()
        {
            //بازیابی محصولات دسته بندی 1
            var result = repo.GetAll().Where(p => p.Category == "Category 1");
            return View(nameof(Index), result);
        }

        public IActionResult Query2()
        {
            //محصول با بالاترین قیمت
            int maxPrice = repo.GetAll().Max(p => p.Price);
            var result = repo.GetAll().Where(p=>p.Price == maxPrice).ToList();
            return View(nameof(Index), result);
        }

        public IActionResult Query3()
        {
            //مجموع قیمت تمامی محصولات
            List<Product> result= new List<Product>();
            result.Add(new Product()
            { 
                Id = 0,
                Name = "",
                Category = "",
                Price = repo.GetAll().Sum(p => p.Price)
            });

            return View(nameof(Index), result);
        }

        public IActionResult Query4()
        {
            //گروه بندی محصولات بر اساس دسته بندی
            var result = repo.GetAll().GroupBy(p => p.Category)
                                      .Select(product => new ProductGroupViewModel {Key = product.Key
                                                                                   ,Products = product.OrderBy(x=>x.Id).ToList()}).ToList();
            
           
            return View(nameof(Query4), result);
        }

        public IActionResult Query5()
        {
            //میانگین قیمت محصولات
            List<Product> result = new List<Product>();
            result.Add(new Product()
            {
                Id = 0,
                Name = "",
                Category = "",
                Price = repo.GetAll().Sum(p => p.Price) / repo.GetAll().Count()
            });

            return View(nameof(Index), result);
        }

    }
}
