using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminPanel.Conne.Pages;

[PageAuthorize(typeof(ReviewRow))]
public class ReviewPage : Controller
{
    [Route("Conne/Review")]
    public ActionResult Index()
    {
        return this.GridPage<ReviewRow>("@/Conne/Review/ReviewPage");
    }
}