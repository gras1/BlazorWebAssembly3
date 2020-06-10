using BlazorWebAssembly3.ClassLibrary;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorWebAssembly3.DataAccess
{
    public interface IProductCategoryData
    {
        Task<ICollection<ProductCategory>> GetAllAsync();

        Task<ICollection<ProductCategory>> SearchProductsAsync(string searchTerm);
    }
}