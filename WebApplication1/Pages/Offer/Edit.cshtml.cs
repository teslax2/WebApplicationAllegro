using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;
using WebApplication1.Models;

namespace WebApplication1.Pages.Offer
{
    public class EditModel : PageModel
    {
        private readonly WebApplication1.Models.WebApplication1Context _context;

        public EditModel(WebApplication1.Models.WebApplication1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public ListingOffer ListingOffer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ListingOffer = await _context.ListingOffer
                .Include(l => l.Delivery)
                .Include(l => l.Promotion)
                .Include(l => l.SellingMode)
                .Include(l => l.Stock)
                .Include(l => l.Vendor).FirstOrDefaultAsync(m => m.ID == id);

            if (ListingOffer == null)
            {
                return NotFound();
            }
           ViewData["DeliveryID"] = new SelectList(_context.Set<OfferDelivery>(), "ID", "ID");
           ViewData["PromotionID"] = new SelectList(_context.Set<OfferPromotion>(), "ID", "ID");
           ViewData["SellingModeID"] = new SelectList(_context.Set<OfferSellingMode>(), "ID", "ID");
           ViewData["StockID"] = new SelectList(_context.Set<OfferStock>(), "ID", "ID");
           ViewData["VendorID"] = new SelectList(_context.Set<OfferVendor>(), "ID", "ID");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ListingOffer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ListingOfferExists(ListingOffer.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ListingOfferExists(int id)
        {
            return _context.ListingOffer.Any(e => e.ID == id);
        }
    }
}
