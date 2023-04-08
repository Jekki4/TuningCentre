using TuningCentre.Api.Entities;
using Microsoft.EntityFrameworkCore;
using TuningCentre.Api.Data;
using TuningCentre.Api.Repositories.Contracts;

namespace TuningCentre.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly TuningCentreDbContext TuningCentreDbContext;

        public ProductRepository(TuningCentreDbContext TuningCentreDbContext)
        {
            this.TuningCentreDbContext = TuningCentreDbContext;
        }
        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await this.TuningCentreDbContext.ProductCategories.ToListAsync();

            return categories;

        }

        public async Task<ProductCategory> GetCategory(int id)
        {
            var category = await TuningCentreDbContext.ProductCategories.SingleOrDefaultAsync(c => c.Id == id);
            return category;
        }

        public async Task<Product> GetItem(int id)
        {
            var product = await TuningCentreDbContext.Products
                                .Include(p => p.ProductCategory)
                                .SingleOrDefaultAsync(p => p.Id == id);
            return product;
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.TuningCentreDbContext.Products
                                     .Include(p => p.ProductCategory).ToListAsync();

            return products;

        }

        public async Task<IEnumerable<Product>> GetItemsByCategory(int id)
        {
            var products = await this.TuningCentreDbContext.Products
                                     .Include(p => p.ProductCategory)
                                     .Where(p => p.CategoryId == id).ToListAsync();
            return products;
        }
    }
}
