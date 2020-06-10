using System.Collections.Generic;

namespace BlazorWebAssembly3.DataAccess
{
    public interface ICategoryData
    {
        void AddCategory(ClassLibrary.Category category);

        List<ClassLibrary.Category> GetCategories();
    }
}
