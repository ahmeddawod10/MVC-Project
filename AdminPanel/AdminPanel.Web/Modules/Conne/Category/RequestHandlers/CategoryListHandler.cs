using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanel.Conne.CategoryRow>;
using MyRow = AdminPanel.Conne.CategoryRow;

namespace AdminPanel.Conne;

public interface ICategoryListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class CategoryListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICategoryListHandler
{
    public CategoryListHandler(IRequestContext context)
            : base(context)
    {
    }
}