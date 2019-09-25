using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication1.Model;
using WebApplication1.Models;

namespace WebApplication1.Pages.Offer
{
    public class CreateModel : PageModel
    {
        private readonly WebApplication1.Models.WebApplication1Context _context;

        public CreateModel(WebApplication1.Models.WebApplication1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["DeliveryID"] = new SelectList(_context.Set<OfferDelivery>(), "ID", "ID");
        ViewData["PromotionID"] = new SelectList(_context.Set<OfferPromotion>(), "ID", "ID");
        ViewData["SellingModeID"] = new SelectList(_context.Set<OfferSellingMode>(), "ID", "ID");
        ViewData["StockID"] = new SelectList(_context.Set<OfferStock>(), "ID", "ID");
        ViewData["VendorID"] = new SelectList(_context.Set<OfferVendor>(), "ID", "ID");
            return Page();
        }

        [BindProperty]
        public ListingOffer ListingOffer { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ListingOffer.Add(ListingOffer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}