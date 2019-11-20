using System.Collections.Generic;  
using System.Threading.Tasks;  


namespace WebApplication1.Data  
{  
    public interface ICategoryService  
    {  
        Task<IEnumerable<Category>> GetCategories();  
        //Task<bool> CreateProduct(Product product);  
        //Task<bool> EditProduct(int id, Product product);  

        //Task<IEnumerable<Product>> GetProductsByCategory(int categoryId);
        //Task<Product> SingleProduct(int id);  
        //Task<bool> DeleteProduct(int id);  
    }  
} 