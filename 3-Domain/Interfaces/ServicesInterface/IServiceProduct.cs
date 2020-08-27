using System.Threading.Tasks;
using Entities.Entities;

namespace Domain.Interfaces.ServicesInterface
{
    public interface IServiceProduct
    {
        Task AddProduct(Product product);
        Task UpdateProduct(Product product);
    }
}