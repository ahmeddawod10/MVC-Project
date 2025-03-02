using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminPanel.Conne.ProductRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanel.Conne.ProductRow;

namespace AdminPanel.Conne;

public interface IProductSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ProductSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IProductSaveHandler
{
    public ProductSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}