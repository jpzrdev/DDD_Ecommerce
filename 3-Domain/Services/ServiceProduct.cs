using System.Threading.Tasks;
using Domain.Interfaces.ProductInterface;
using Domain.Interfaces.ServicesInterface;
using Entities.Entities;

namespace Domain.Services
{
    public class ServiceProduct : IServiceProduct
    {
        private readonly IProduct _IProduct;
        public ServiceProduct(IProduct iProduct)
        {
            _IProduct = iProduct;
        }

        public async Task AddProduct(Product product)
        {
            var validaNome = product.ValidarPropriedadeString(product.Nome, "Nome");
            var validaValor = product.ValidarPropriedadeDecimal(product.Valor, "Valor");

            if (validaNome && validaValor)
            {
                product.Estado = true;
                await _IProduct.Add(product);
            }
        }

        public async Task UpdateProduct(Product product)
        {
            var validaNome = product.ValidarPropriedadeString(product.Nome, "Nome");
            var validaValor = product.ValidarPropriedadeDecimal(product.Valor, "Valor");

            if (validaNome && validaValor)
            {
                product.Estado = true;
                await _IProduct.Update(product);
            }
        }
    }
}