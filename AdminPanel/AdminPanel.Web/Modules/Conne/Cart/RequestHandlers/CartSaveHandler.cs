using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminPanel.Conne.CartRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanel.Conne.CartRow;

namespace AdminPanel.Conne;

public interface ICartSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class CartSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICartSaveHandler
{
    public CartSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}