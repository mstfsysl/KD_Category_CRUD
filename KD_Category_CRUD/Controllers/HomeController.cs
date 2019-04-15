using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KD_Category_CRUD.Models;

namespace KD_Category_CRUD.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult List()
        {
            BAECommerce_PreProd_NewContext bAECommerce_PreProd_NewContext = new BAECommerce_PreProd_NewContext();

            List<MasterProduct> products = bAECommerce_PreProd_NewContext.MasterProduct.Where(a => a.Status != 0).ToList();

            return View(products);
        }

        public IActionResult Create()
        {
            BAECommerce_PreProd_NewContext bAECommerce_PreProd_NewContext = new BAECommerce_PreProd_NewContext();

            List<Category> categories = bAECommerce_PreProd_NewContext.Category.ToList();

            TempData["Categories"] = categories;

            List<Brand> brands = bAECommerce_PreProd_NewContext.Brand.ToList();

            TempData["Brands"] = brands;

            return View();
        }

        [HttpPost]
        public IActionResult Create(MasterProduct masterProduct)
        {
            BAECommerce_PreProd_NewContext bAECommerce_PreProd_NewContext = new BAECommerce_PreProd_NewContext();

            List<Category> categories = bAECommerce_PreProd_NewContext.Category.ToList();

            TempData["Categories"] = categories;

            List<Brand> brands = bAECommerce_PreProd_NewContext.Brand.ToList();

            TempData["Brands"] = brands;

            string sCategoryGuid = HttpContext.Request.Form["Category"];

            if (!string.IsNullOrEmpty(sCategoryGuid))
            {
                Guid categoryGuid = Guid.Parse(sCategoryGuid);

                masterProduct.CategoryId = categoryGuid;
            }
            else
            {
                ViewBag.Message = "Lütfen bir category seçiniz!";
                return View(masterProduct);
            }

            string sBrandGuid = HttpContext.Request.Form["Brand"];

            if (!string.IsNullOrEmpty(sBrandGuid))
            {
                Guid brandGuid = Guid.Parse(sBrandGuid);

                masterProduct.BrandId = brandGuid;
            }
            else
            {
                ViewBag.Message = "Lütfen bir brand seçiniz!";
                return View(masterProduct);
            }
            
            bAECommerce_PreProd_NewContext.MasterProduct.Add(masterProduct);
            bAECommerce_PreProd_NewContext.SaveChanges();

            ViewBag.Message = "Ürün başarıyla kaydedildi";

            return View(masterProduct);
        }

        public IActionResult Update()
        {
            string guid = HttpContext.Request.Path.Value.Split('/')[3];

            BAECommerce_PreProd_NewContext bAECommerce_PreProd_NewContext = new BAECommerce_PreProd_NewContext();
            List<MasterProduct> products = bAECommerce_PreProd_NewContext.MasterProduct.Where(a => a.Status != 0).ToList();

            if (string.IsNullOrEmpty(guid))
            {
                ViewBag.Message = "Ürün bulunamadı";
                return View("List", products);
            }

            List<Category> categories = bAECommerce_PreProd_NewContext.Category.ToList();

            TempData["Categories"] = categories;

            List<Brand> brands = bAECommerce_PreProd_NewContext.Brand.ToList();

            TempData["Brands"] = brands;

            MasterProduct masterProduct = bAECommerce_PreProd_NewContext.MasterProduct.Find(new Guid(guid));

            return View(masterProduct);
        }

        [HttpPost]
        public IActionResult Update(MasterProduct masterProduct)
        {
            BAECommerce_PreProd_NewContext bAECommerce_PreProd_NewContext = new BAECommerce_PreProd_NewContext();

            List<Category> categories = bAECommerce_PreProd_NewContext.Category.ToList();

            TempData["Categories"] = categories;

            List<Brand> brands = bAECommerce_PreProd_NewContext.Brand.ToList();

            TempData["Brands"] = brands;

            bAECommerce_PreProd_NewContext.MasterProduct.Update(masterProduct);
            bAECommerce_PreProd_NewContext.SaveChanges();

            ViewBag.Message = "Ürün başarıyla güncellendi";

            return View(masterProduct);
        }

        public IActionResult Delete()
        {
            string guid = HttpContext.Request.Path.Value.Split('/')[3];

            BAECommerce_PreProd_NewContext bAECommerce_PreProd_NewContext = new BAECommerce_PreProd_NewContext();
            List<MasterProduct> products = bAECommerce_PreProd_NewContext.MasterProduct.Where(a => a.Status != 0).ToList();

            if (string.IsNullOrEmpty(guid))
            {
                ViewBag.Message = "Ürün bulunamadı";
                return View("List", products);
            }

            MasterProduct masterProduct = bAECommerce_PreProd_NewContext.MasterProduct.Find(new Guid(guid));
            //bAECommerce_PreProd_NewContext.MasterProduct.Remove(masterProduct);
            masterProduct.Status = 0;
            bAECommerce_PreProd_NewContext.MasterProduct.Update(masterProduct);
            bAECommerce_PreProd_NewContext.SaveChanges();

            ViewBag.Message = "Ürün başarıyla silindi";

            return View("List",products);
        }

        public IActionResult DataTableDeneme()
        {
            return View();
        }
    }
}
