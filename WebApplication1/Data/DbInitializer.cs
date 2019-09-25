using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public static class DbInitializer
    {
        public static void Initialize(WebApplication1Context context)
        {
            context.Database.EnsureCreated();

            if (context.ListingOffer.Any())
            {
                return;
      
            }
        }

        public static void Save(WebApplication1Context context, ApiModel.ListingResponse response)
        {
            context.Database.EnsureCreated();

            if (context.ListingOffer.Any())
            {
                foreach (var item in response.Items.Promoted.Select(p=>p.Seller))
                {
                    context.Seller.Add(new OfferSeller() { Company = item.Company, SuperSeller = item.SuperSeller });
                }
                context.SaveChanges();
            }
        }
    }
}
