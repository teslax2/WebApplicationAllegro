using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;
using WebApplication1.Models;

namespace WebApplication1.Pages.Offer
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication1.Models.WebApplication1Context _context;

        public IndexModel(WebApplication1.Models.WebApplication1Context context)
        {
            _context = context;
        }

        public IList<ListingOffer> ListingOffer { get;set; }

        public async Task OnGetAsync()
        {
            ListingOffer = await _context.ListingOffer.Include(p => p.Images).ToListAsync();
            //ListingOffer = await (from offer in _context.ListingOffer
            //                join images in _context.OfferImages on offer.ID equals images.ListingOfferID
            //                select new ListingOffer
            //                {
            //                    Category = offer.Category,
            //                    DeliveryCost = offer.DeliveryCost,
            //                    ID = offer.ID,
            //                    SellerID = offer.SellerID,
            //                    SellingMode = offer.SellingMode,
            //                    Stock = offer.Stock,
            //                    Name = offer.Name,
            //                    Price = offer.Price,
            //                    Images = images

            //                }).ToListAsync();
        }
    }
}
