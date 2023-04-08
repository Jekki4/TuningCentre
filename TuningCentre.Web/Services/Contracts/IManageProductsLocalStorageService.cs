using TuningCentre.Models.Dtos;

namespace TuningCentre.Web.Services.Contracts
{
    public interface IManageProductsLocalStorageService
    {
        Task<IEnumerable<ProductDto>> GetCollection();
        Task RemoveCollection();
    }
}
