using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;

namespace WebApplication1.Models
{
    public class WebApplication1Context : DbContext
    {
        public WebApplication1Context (DbContextOptions<WebApplication1Context> options)
            : base(options)
        {
        }

        public DbSet<ListingOffer> ListingOffer { get; set; }
        public DbSet<OfferSeller> Seller { get; set; }
        public DbSet<OfferPromotion> Promotion { get; set; }
        public DbSet<OfferDelivery> Delivery { get; set; }
        public DbSet<OfferImages> Images { get; set; }
        public DbSet<OfferSellingMode> SellingMode { get; set; }
        public DbSet<OfferStock> Stock { get; set; }
        public DbSet<OfferVendor> Vendor { get; set; }
    }
}
