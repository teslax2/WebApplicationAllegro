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
    public class DeleteModel : PageModel
    {
        private readonly WebApplication1.Models.WebApplication1Context _context;

        public DeleteModel(WebApplication1.Models.WebApplication1Context context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ListingOffer = await _context.ListingOffer.FindAsync(id);

            if (ListingOffer != null)
            {
                _context.ListingOffer.Remove(ListingOffer);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
