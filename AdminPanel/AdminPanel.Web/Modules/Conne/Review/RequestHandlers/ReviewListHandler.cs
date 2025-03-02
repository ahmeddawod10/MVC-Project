using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanel.Conne.ReviewRow>;
using MyRow = AdminPanel.Conne.ReviewRow;

namespace AdminPanel.Conne;

public interface IReviewListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ReviewListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IReviewListHandler
{
    public ReviewListHandler(IRequestContext context)
            : base(context)
    {
    }
}