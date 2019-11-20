using Dapper;  
using Microsoft.Data.SqlClient;  
using System;  
using System.Collections.Generic;  
using System.Data;  
using System.Threading.Tasks;  
  
namespace WebApplication1.Data{  
    public class ProductService : IProductService 
    {  
        private readonly SqlConnectionConfiguration _configuration;  
        public ProductService(SqlConnectionConfiguration configuration)  
        {  
            _configuration = configuration;  
        }  
        public async Task<bool> CreateProduct(Product product)  
        {  
            using (var conn = new SqlConnection(_configuration.Value))  
            {  
                const string query = @"insert into dbo.Product (Name,Price) values (@Name,@Price)";  
                if (conn.State == ConnectionState.Closed)  
                    conn.Open();  
                try  
                {  
                    await conn.ExecuteAsync(query, new { product.Name, product.Price }, commandType: CommandType.Text);  
                }  
                catch (Exception ex)  
                {  
                    throw ex;  
                }  
                finally  
                {  
                    if (conn.State == ConnectionState.Open)  
                        conn.Close();  
                }  
            }  
            return true;  
        }  
        public async Task<bool> DeleteProduct(int id)  
        {  
            using (var conn = new SqlConnection(_configuration.Value))  
            {  
                const string query = @"delete from dbo.Product where Id=@Id";  
                if (conn.State == ConnectionState.Closed)  
                    conn.Open();  
                try  
                {  
                    await conn.ExecuteAsync(query, new { id }, commandType: CommandType.Text);  
                }  
                catch (Exception ex)  
                {  
                    throw ex;  
                }  
                finally  
                {  
                    if (conn.State == ConnectionState.Open)  
                        conn.Close();  
                }  
            }  
            return true;  
        }  
        public async Task<bool> EditProduct(int id, Product product)  
        {  
            using (var conn = new SqlConnection(_configuration.Value))  
            {  
                const string query = @"update dbo.Product set Name = @Name, Price = @Price where Id=@Id";  
                if (conn.State == ConnectionState.Closed)  
                    conn.Open();  
                try  
                {  
                    await conn.ExecuteAsync(query, new { product.Name, product.Price, id }, commandType: CommandType.Text);  
                }  
                catch (Exception ex)  
                {  
                    throw ex;  
                }  
                finally  
                {  
                    if (conn.State == ConnectionState.Open)  
                        conn.Close();  
                }  
            }  
            return true;  
        }  
        public async Task<IEnumerable<Product>> GetProducts()  
        {  
            IEnumerable<Product> products;  
            using (var conn = new SqlConnection(_configuration.Value))  
            {  
                const string query = @"select * from cash.dbo.Product";  
  
                if (conn.State == ConnectionState.Closed)  
                    conn.Open();  
                try  
                {  
                    products = await conn.QueryAsync<Product>(query);  
  
                }  
                catch (Exception ex)  
                {  
                    throw ex;  
                }  
                finally  
                {  
                    if (conn.State == ConnectionState.Open)  
                        conn.Close();  
                }  
  
            }  
            return products;  
        }
        public async Task<IEnumerable<Product>> GetProductsByCategory(int categoryId){

            IEnumerable<Product> products;  
            using (var conn = new SqlConnection(_configuration.Value))  
            {  
                const string query = @"select * from cash.dbo.Product where CategoryId = @CategoryId";  
  
                if (conn.State == ConnectionState.Closed)  
                    conn.Open();  
                try  
                {  
                    products = await conn.QueryAsync<Product>(query, new { categoryId}, commandType: CommandType.Text);  
  
                }  
                catch (Exception ex)  
                {  
                    throw ex;  
                }  
                finally  
                {  
                    if (conn.State == ConnectionState.Open)  
                        conn.Close();  
                }  
  
            }  
            return products;  

        }
        public async Task<Product> SingleProduct(int id)  
        {  
            Product product = new Product();  
  
            using (var conn = new SqlConnection(_configuration.Value))  
            {  
                const string query = @"select * from dbo.Product where Id =@Id";  
  
                if (conn.State == ConnectionState.Closed)  
                    conn.Open();  
                try  
                {  
                    product = await conn.QueryFirstOrDefaultAsync<Product>(query, new { id }, commandType: CommandType.Text);  
                }  
                catch (Exception ex)  
                {  
                    throw ex;  
                }  
                finally  
                {  
                    if (conn.State == ConnectionState.Open)  
                        conn.Close();  
                }  
            }  
            return product;  
        }  
    }  
}  