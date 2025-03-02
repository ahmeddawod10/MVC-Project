using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminPanel.Conne.CategoryRow>;
using MyRow = AdminPanel.Conne.CategoryRow;

namespace AdminPanel.Conne;

public interface ICategoryRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class CategoryRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoryRetrieveHandler
{
    public CategoryRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}