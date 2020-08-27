using System.Threading.Tasks;
using Entities.Entities;

namespace Application.Interfaces
{
    public interface IProductApp : IGenericApp<Product>
    {
        Task AddProduct(Product product);
        Task UpdateProduct(Product product);
    }
}