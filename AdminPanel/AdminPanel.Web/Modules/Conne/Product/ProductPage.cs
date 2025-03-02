using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminPanel.Conne.Pages;

[PageAuthorize(typeof(ProductRow))]
public class ProductPage : Controller
{
    [Route("Conne/Product")]
    public ActionResult Index()
    {
        return this.GridPage<ProductRow>("@/Conne/Product/ProductPage");
    }
}