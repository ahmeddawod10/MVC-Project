using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminPanel.Conne.ReviewRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanel.Conne.ReviewRow;

namespace AdminPanel.Conne;

public interface IReviewSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ReviewSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IReviewSaveHandler
{
    public ReviewSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}