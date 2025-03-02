using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminPanel.Conne.Pages;

[PageAuthorize(typeof(CategoryRow))]
public class CategoryPage : Controller
{
    [Route("Conne/Category")]
    public ActionResult Index()
    {
        return this.GridPage<CategoryRow>("@/Conne/Category/CategoryPage");
    }
}