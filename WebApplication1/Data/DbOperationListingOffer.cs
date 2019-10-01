using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class DbOperationListingOffer : IDbOperations
    {
        private WebApplication1Context _context;

        public DbOperationListingOffer(WebApplication1Context context)
        {
            _context = context;
        }

        public int Add<T>(T items)
        {
            if (items is ListingResponseSearchItem listingResponseSearchItem)
            {
                listingResponseSearchItem.SearchItem.ListingOffer = GetOffers(listingResponseSearchItem);
                _context.SearchItems.Add(listingResponseSearchItem.SearchItem);
                var rows = _context.SaveChanges();
                return rows;
            }
            return 0;
        }

        public int AddOrUpdate<T>(T items)
        {
            if (items is ListingResponseSearchItem listingResponseSearchItem)
            {
                var searchItem = _context.SearchItems.FirstOrDefault(p => p.Name == listingResponseSearchItem.SearchItem.Name);
                if (searchItem == null)
                    _context.SearchItems.Add(listingResponseSearchItem.SearchItem);
                else
                    listingResponseSearchItem.SearchItem = searchItem;
                var itemsToAdd = GetOffers(listingResponseSearchItem);
                foreach (var item in itemsToAdd)
                {
                    if (_context.ListingOffer.Contains(item))
                        _context.Update(item);
                    else
                        _context.Add(item);
                }
                var rows = _context.SaveChanges();
                return rows;
            }
            return 0;
        }

        private List<Model.ListingOffer> GetOffers(ListingResponseSearchItem listingResponseSearchItem)
        {
            var itemsToAdd = new List<Model.ListingOffer>();
                foreach (var item in listingResponseSearchItem.ListingResponse.Items.Promoted)
                {
                    var images = item.Images.Select(p => new Model.OfferImages() { Url = p.Url }).ToList();
                    itemsToAdd.Add(new Model.ListingOffer()
                    {
                        ID = item.Id,
                        Category = item.Category.Id,
                        DeliveryCost = double.Parse(item.Delivery.LowestPrice.Amount,CultureInfo.InvariantCulture),
                        Name = item.Name,
                        SellerID = item.Seller.Id,
                        Price = double.Parse(item.SellingMode.Price.Amount, CultureInfo.InvariantCulture),
                        Stock = item.Stock.Available.Value,
                        SellingMode = item.SellingMode.Format.ToString(),
                        Images = images,
                        SearchItem = listingResponseSearchItem.SearchItem,
                        SearchItemID = listingResponseSearchItem.SearchItem.ID
                    });
                }
            return itemsToAdd;
        }
    }
}
