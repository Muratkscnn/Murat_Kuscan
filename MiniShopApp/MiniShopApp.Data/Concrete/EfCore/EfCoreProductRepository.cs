using Microsoft.EntityFrameworkCore;
using MiniShopApp.Data.Abstract;
using MiniShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Data.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product, MiniShopContext>, IProductRepository
    {
        public List<Product> GetHomePageProducts()
        {
            using (var context = new MiniShopContext())
            {
                return context.Products.Where(x => x.IsApproved && x.IsHome).ToList();
            }
        }

        public Product GetProductDetails(string url)
        {
            using (var context=new MiniShopContext())
            {
                return context.Products.Where(x => x.Url == url).Include(x => x.ProductCategories).ThenInclude(x => x.Category).FirstOrDefault();
            }
        }

        public List<Product> GetProductsByCategory(string name)
        {
            using (var context=new MiniShopContext())
            {
                var products = context.Products.Where(x => x.IsApproved).AsQueryable();
                if (!string.IsNullOrEmpty(name))
                {
                    products = products.Include(x => x.ProductCategories).ThenInclude(x => x.Category).Where(x => x.ProductCategories.Any(i => i.Category.Url == name));
                }
                return products.ToList();
            }
        }

        public List<Product> GetSearchResult(string searchString)
        {
            searchString = searchString.ToLower();

            using (var context = new MiniShopContext())
            {
                var products = context.Products.Where(x => x.IsApproved && (x.Name.ToLower().Contains(searchString) || x.Description.ToLower().Contains(searchString))).ToList();
                return products;
            }
            
        }
    }
}
