﻿using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdminPanel.Conne.ReviewRow;

namespace AdminPanel.Conne;

public interface IReviewDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ReviewDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IReviewDeleteHandler
{
    public ReviewDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}