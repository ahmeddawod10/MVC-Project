using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanel.Conne.CartRow>;
using MyRow = AdminPanel.Conne.CartRow;

namespace AdminPanel.Conne;

public interface ICartListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class CartListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICartListHandler
{
    public CartListHandler(IRequestContext context)
            : base(context)
    {
    }
}