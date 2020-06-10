using System.Collections.Generic;

namespace BlazorWebAssembly3.DataAccess
{
    public interface IProductData
    {
        void AddProduct(ClassLibrary.Product product);

        List<ClassLibrary.Product> GetProducts();
    }
}
