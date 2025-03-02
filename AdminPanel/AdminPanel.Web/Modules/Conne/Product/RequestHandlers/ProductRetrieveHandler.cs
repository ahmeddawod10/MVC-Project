using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminPanel.Conne.ProductRow>;
using MyRow = AdminPanel.Conne.ProductRow;

namespace AdminPanel.Conne;

public interface IProductRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ProductRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IProductRetrieveHandler
{
    public ProductRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}