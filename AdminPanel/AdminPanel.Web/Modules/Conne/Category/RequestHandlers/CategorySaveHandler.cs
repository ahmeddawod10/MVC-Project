using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminPanel.Conne.CategoryRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanel.Conne.CategoryRow;

namespace AdminPanel.Conne;

public interface ICategorySaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class CategorySaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICategorySaveHandler
{
    public CategorySaveHandler(IRequestContext context)
            : base(context)
    {
    }
}