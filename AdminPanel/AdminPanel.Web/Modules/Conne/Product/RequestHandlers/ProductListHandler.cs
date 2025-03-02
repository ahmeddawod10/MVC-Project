using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanel.Conne.ProductRow>;
using MyRow = AdminPanel.Conne.ProductRow;

namespace AdminPanel.Conne;

public interface IProductListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ProductListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IProductListHandler
{
    public ProductListHandler(IRequestContext context)
            : base(context)
    {
    }
}