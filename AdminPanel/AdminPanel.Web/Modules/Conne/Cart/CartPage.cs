using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminPanel.Conne.Pages;

[PageAuthorize(typeof(CartRow))]
public class CartPage : Controller
{
    [Route("Conne/Cart")]
    public ActionResult Index()
    {
        return this.GridPage<CartRow>("@/Conne/Cart/CartPage");
    }
}