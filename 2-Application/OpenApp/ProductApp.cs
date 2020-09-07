using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Interfaces.ProductInterface;
using Domain.Interfaces.ServicesInterface;
using Entities.Entities;

namespace Application.OpenApp
{
    public class ProductApp : IProductApp
    {

        private readonly IProduct _IProduct;
        private readonly IServiceProduct _IServiceProduct;
        public ProductApp(IProduct iProduct, IServiceProduct iServiceProduct)
        {
            _IProduct = iProduct;
            _IServiceProduct = iServiceProduct;
        }

        public async Task AddProduct(Product product)
        {
            await _IServiceProduct.AddProduct(product);
        }
        public async Task UpdateProduct(Product product)
        {
            await _IServiceProduct.UpdateProduct(product);
        }
        public async Task Add(Product product)
        {
            await _IProduct.Add(product);
        }

        public async Task Delete(Product product)
        {
            await _IProduct.Delete(product);
        }

        public async Task<Product> GetEntityById(int id)
        {
            return await _IProduct.GetEntityById(id);
        }

        public async Task<List<Product>> List()
        {
            return await _IProduct.List();
        }

        public async Task Update(Product product)
        {
            await _IProduct.Update(product);
        }


    }
}