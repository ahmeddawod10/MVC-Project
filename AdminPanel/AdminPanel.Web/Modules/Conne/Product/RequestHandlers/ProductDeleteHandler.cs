using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdminPanel.Conne.ProductRow;

namespace AdminPanel.Conne;

public interface IProductDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ProductDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IProductDeleteHandler
{
    public ProductDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}