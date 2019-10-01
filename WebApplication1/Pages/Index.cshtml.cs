using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using WebApplication1.Api;
using WebApplication1.Api.Requests;
using WebApplication1.ApiModel;
using WebApplication1.Data;
using WebApplication1.Infrastructure;
using WebApplication1.Model;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private IApi _api;
        private IDbOperations _dbOperations;
        private AllegroConfiguration _allegroConfiguration;
        [BindProperty(SupportsGet = true)]
        public string Search { get; set; }

        public IndexModel(IApi api, IDbOperations dbOperations, IConfiguration configuration)
        {
            _api = api;
            _dbOperations = dbOperations;
            _allegroConfiguration = configuration.GetSection("Allegro").Get<AllegroConfiguration>();
        }
        public async Task OnGet()
        {
            if (!string.IsNullOrEmpty(Search))
            {
                var tokenResult = await _api.Login(new RequestLogin(Endpoints.URLAuth, Endpoints.Login, _allegroConfiguration.ClientID, _allegroConfiguration.Secret));
                if (tokenResult is Token token)
                {
                    var offers = await _api.Offers(new RequestOffers(Endpoints.URL, token.access_token, Search));
                    if (offers is ListingResponse listingResponse)
                    {
                        var listingResponseOfferSearchItem = new ListingResponseSearchItem() { ListingResponse = listingResponse, SearchItem = new SearchItem() { Name = Search } };
                        _dbOperations.AddOrUpdate<ListingResponseSearchItem>(listingResponseOfferSearchItem);

                    }
                }
            }
        }
    }
}
