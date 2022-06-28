using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Json;
using WebApplicationTree_View_Yapilandirmasi.Models;
using WebApplicationTree_View_Yapilandirmasi.Models.ViewModels;

namespace WebApplicationTree_View_Yapilandirmasi.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            //varsayılan veritabanı dataları burdan gelir.

            var products = new List<Product>()
            {
                new Product() { Id = 1, ProductName = "elma", UnitPrice = 3},
                new Product() { Id = 2, ProductName = "armut", UnitPrice = 4},
                new Product() { Id = 3, ProductName = "mandalina", UnitPrice = 6}
            };

            //controller view 4 farklı şekilde data taşıma sistemi mevcuttur.
            return View(products);
        }

        public IActionResult Index2()
        {
            var products = new List<Product>()
            {
                new Product() { Id = 1, ProductName = "elma", UnitPrice = 3},
                new Product() { Id = 2, ProductName = "armut", UnitPrice = 4},
                new Product() { Id = 3, ProductName = "mandalina", UnitPrice = 6}
            };

            #region ViewBag
            //view'e taşınacak datayı dynamic şekilde tanımlanan bir değişkenle taşımamızı sağlayan bir veri taşıma işlemidir.
            ViewBag.Products = products;
            #endregion

            return View();
        }

        public IActionResult Index3()
        {
            var products = new List<Product>()
            {
                new Product() { Id = 1, ProductName = "elma", UnitPrice = 3},
                new Product() { Id = 2, ProductName = "armut", UnitPrice = 4},
                new Product() { Id = 3, ProductName = "mandalina", UnitPrice = 6}
            };

            #region ViewData
            //Aynı viewbag'de olduğu gibi actiondaki datayı view'e taşıyan bir kontroldür.
            //Birbirleri arasındaki en temel fark ise viewdata üzerinde getirdiği data'yı object olarak taşır.
            ViewData["product"] = products;

            #endregion

            return View();

        }


        public IActionResult Index4()
        {
            var products = new List<Product>()
            {
                new Product() { Id = 1, ProductName = "elma", UnitPrice = 3},
                new Product() { Id = 2, ProductName = "armut", UnitPrice = 4},
                new Product() { Id = 3, ProductName = "mandalina", UnitPrice = 6}
            };
            #region TempData
            //ViewData'da olduğu gibi actiondaki datayı view'e taşıyan bir kontroldür.
            //Farklı object olarak datayı getirir. Senin unboxing yapman lazım.


            //TempData["products"] = products;

            //Önemli Not = Bazı durumlarda bir action görevini bitirdikten sonra farklı bir actiona yönlendirilmek isteyebilirsiniz. Bu durumda diğer
            //data taşıma yöntemleri türlerinde diğer actiona data taşıyamayacaksınız. Fakat tempdata cookies tutuğu için üzerinde yönlendirilebilen
            //actiion'da da dataları rahatlıkla taşır.


            //Bizim tarayıcımız obje nesne gibi yapılardan anlamaz.. Sadece düz stringden anlar.
            //Bu nedenle bizi elimizde olan products datasını bizim tipden cıkartıp düz stringe cevirmemiz gerekliydi.
            //Bu işlem için JsonSerialize sınıfı içerisindeki serialize(metot) u kullanıldı.
            //Bu metot göndermiş olduğumuz datayı düz stringe cevirdi. Fakat json formatında.

            string data = JsonSerializer.Serialize(products);
            TempData["products"] = data;
            #endregion

            return RedirectToAction("Index6", "Product");
        }

        public IActionResult Index6()
        {
            //Product komplex bir tür olduğu için direk göndermedik. Gelen nesneyi dışarıdan serialize ettik.

            /*Ardından bu işleme karşılık gelen çözme işlemini sağlayan Deserialize<List<Product>>(data) çözmüş olduk.
              Artık json formatında gelen data <List<Product>> dönüşmüş oldu.. */

            //Artık datayı burdan komplex tipinde kullanabiliriz.

            var data = TempData["products"].ToString();
            List<Product> products = JsonSerializer.Deserialize<List<Product>>(data);

            TempData["products"] = products;

            return View();
        }

        public IActionResult Index7()
        {
            Product product = new Product()
            {
                Id = 1,
                ProductName = "meyve",
                UnitPrice = 50
            };

            User user = new User()
            {
                Id = 1,
                LastName = "Basar",
                Name = "Mert"
            };

            UserProduct userProduct = new UserProduct()
            {
                Product = product,
                User = user
            };

            return View(userProduct);
        }

        public IActionResult Index8()
        {
            Product prd1 = new Product()
            {
                Id = 1,
                ProductName = "Sirke",
                UnitPrice= 50
            };

            User usr1 = new User()
            {
                Id = 1,
                LastName = "Aysun",
                Name = "Basar"
            };

            var userProduct = (prd1, usr1);

            return View(userProduct);
        }

        public IActionResult Index9()
        {
            //Bu Action
            return View();
        }
    }
}
