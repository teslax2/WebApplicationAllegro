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
    public class DetailsModel : PageModel
    {
        private readonly WebApplication1.Models.WebApplication1Context _context;

        public DetailsModel(WebApplication1.Models.WebApplication1Context context)
        {
            _context = context;
        }

        public ListingOffer ListingOffer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ListingOffer = await _context.ListingOffer.FirstOrDefaultAsync(m => m.ID == id);

            if (ListingOffer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
