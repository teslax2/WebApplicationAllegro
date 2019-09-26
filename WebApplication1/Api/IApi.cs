using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Api.Requests;
using WebApplication1.ApiModel;

namespace WebApplication1.Api
{
    public interface IApi
    {
        Task<Token> Login(RequestLogin requestLogin);
        Task<ListingResponse> Offers(RequestOffers requestOffers);
    }
}
