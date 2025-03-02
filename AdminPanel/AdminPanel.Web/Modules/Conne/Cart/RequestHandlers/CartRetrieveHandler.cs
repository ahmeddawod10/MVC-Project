﻿using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminPanel.Conne.CartRow>;
using MyRow = AdminPanel.Conne.CartRow;

namespace AdminPanel.Conne;

public interface ICartRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class CartRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICartRetrieveHandler
{
    public CartRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}