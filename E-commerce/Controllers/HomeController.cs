using System.Diagnostics;
using E_commerce.Models;
using E_commerce.View_Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_commerce.Controllers
{
    public class HomeController : Controller
    {
        EcommerceContext db =new EcommerceContext();
       

        public IActionResult Index()
        {
            IndexVm vm = new IndexVm();
            vm.Categories=db.Categories.ToList();
            vm.Products=db.Products.ToList();
            vm.Reviews=db.Reviews.ToList();
           
            return View(vm);

        }

        public IActionResult Privacy()
        {
            return View();
        }
        [Authorize]
        public IActionResult Cart()
        {
            return View(db.Carts.Include(x=>x.product).Where(x=>x.userid==User.Identity.Name).ToList());
        }
        [Authorize]
        public IActionResult AddToCart(int id)
        {
            var price = db.Products.Find(id).price;
            var item=db.Carts.FirstOrDefault( x=>x.productid==id&&x.userid==User.Identity.Name);
            if (item != null) {
                item.count += 1;
                db.SaveChanges();
            }
            else
                db.Carts.Add(new Cart { productid = id, userid = User.Identity.Name, count = 1, Price = (int)price });
            db.SaveChanges ();
            return RedirectToAction("Cart");
        }
        public IActionResult RemoveFromCart(int id)
        {
            var item = db.Carts.FirstOrDefault(x => x.id == id && x.userid == User.Identity.Name);

            if (item != null)
            {
                if (item.count > 1)
                {
                    item.count -= 1; // Decrease count if more than 1
                }
                else
                {
                    db.Carts.Remove(item); // Remove from cart if count reaches 0
                }
                db.SaveChanges();
            }

            return RedirectToAction("Cart");
        }

        public IActionResult Categories()
        {
          var cats=  db.Categories.ToList();
            return View(cats);
        }
        public IActionResult Products(int id)
        {
            var products = db.Products.Where(x => x.catid == id).ToList();
            return View(products);
        }
        [Route("Home/ProductDetails/{id}")]
        public IActionResult ProductDetails(int id)
        {
            var products = db.Products.Include(x=>x.cat).FirstOrDefault(x => x.id == id);
            return View(products);
        }
        //-------------------------------------------------------------------

        [HttpGet]
        public IActionResult ProductSearch(string xname)
        {
            var products =new List<Product>();
            if (string.IsNullOrEmpty(xname))
                products = db.Products.ToList();
            else products=db.Products.Where(x => x.name.Contains(xname)).ToList();
             return View(products);
        }

        [HttpPost]
        public IActionResult sendReview(Review model)
        {
             db.Reviews.Add(new Review { name=model.name,email= model.email,subject= model.subject,description= model.description });
            db.SaveChanges();
            return RedirectToAction("index");
        }
        //-----------------------------------------------------------------------------------

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
