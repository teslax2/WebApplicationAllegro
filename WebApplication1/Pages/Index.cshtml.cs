using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using WebApplication1.Api;
using WebApplication1.Api.Requests;
using WebApplication1.ApiModel;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private IApi _api;
        private IDbOperations _dbOperations;

        public IndexModel(IApi api, IDbOperations dbOperations)
        {
            _api = api;
            _dbOperations = dbOperations;
        }
        public async Task OnGet()
        {
            var tokenResult = await _api.Login(new RequestLogin(Endpoints.URLAuth, Endpoints.Login, "fc475aa8dfe4424fb1507bebea59c924", "jWo1K9tKptPaIza31ByS3WxE678FHJxK7dsFinXFxJD1rgoypuTz8LmuBEmHoLQa"));
            if (tokenResult is Token token)
            {
                var offers = await _api.Offers(new RequestOffers(Endpoints.URL, token.access_token, "xiaomi mi mix"));
                if (offers is ListingResponse listingResponse)
                {
                    _dbOperations.AddOrUpdate<ListingResponseOffers>(offers.Items);
                }
            }
        }
    }
}
