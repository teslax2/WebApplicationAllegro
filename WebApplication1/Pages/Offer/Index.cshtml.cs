using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Extensions;
using WebApplication1.Infrastructure;
using WebApplication1.Model;
using WebApplication1.Models;

namespace WebApplication1.Pages.Offer
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication1Context _context;

        public IndexModel(WebApplication1Context context)
        {
            _context = context;
        }

        public IList<ListingOffer> ListingOffer { get;set; }
        [BindProperty(SupportsGet = true)]
        public string FilterString { get; set; }
        public async Task OnGetAsync(string order = "", string filter = "")
        {
            ViewData["Order"] = order;
            var sessionFilter = HttpContext.Session.GetValue<string>("filter");
            if (!string.IsNullOrEmpty(filter))
            {
                FilterString = filter;
                HttpContext.Session.SetValue<string>("filter", filter);
            }

            else
            {
                FilterString = sessionFilter;
                HttpContext.Session.Remove("filter");
            }

            var listingOfferFilterred = new List<ListingOffer>();
            if (!string.IsNullOrEmpty(FilterString))
                listingOfferFilterred = await _context.ListingOffer.Include(p => p.Images).Where(p => p.Name.Contains(FilterString)).ToListAsync();
            else
                listingOfferFilterred = await _context.ListingOffer.Include(p => p.Images).ToListAsync();
            switch (order)
            {
                case "asc":
                    ListingOffer = listingOfferFilterred.OrderBy(p => p.Price).ToList();
                    break;
                case "desc":
                    ListingOffer = listingOfferFilterred.OrderByDescending(p => p.Price).ToList();
                    break;
                default:
                    ListingOffer = listingOfferFilterred;
                    break;
            }
        }
    }
}
