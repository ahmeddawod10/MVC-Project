using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminPanel.Conne.ReviewRow>;
using MyRow = AdminPanel.Conne.ReviewRow;

namespace AdminPanel.Conne;

public interface IReviewRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ReviewRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IReviewRetrieveHandler
{
    public ReviewRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}