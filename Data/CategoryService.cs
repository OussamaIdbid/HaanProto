using Dapper;  
using Microsoft.Data.SqlClient;  
using System;  
using System.Collections.Generic;  
using System.Data;  
using System.Threading.Tasks;  
  
namespace WebApplication1.Data{  
    public class CategoryService : ICategoryService 
    {  
        private readonly SqlConnectionConfiguration _configuration;  
        public CategoryService(SqlConnectionConfiguration configuration)  
        {  
            _configuration = configuration;  
        }  
        public async Task<bool> CreateCategory(Category category)  
        {  
            using (var conn = new SqlConnection(_configuration.Value))  
            {  
                const string query = @"insert into dbo.Category (Name) values (@Name,@Price)";  
                if (conn.State == ConnectionState.Closed)  
                    conn.Open();  
                try  
                {  
                    await conn.ExecuteAsync(query, new { category.CategoryName}, commandType: CommandType.Text);  
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
        public async Task<bool> DeleteCategory(int CategoryId)  
        {  
            using (var conn = new SqlConnection(_configuration.Value))  
            {  
                const string query = @"delete from dbo.Category where CategoryId=@CategoryId";  
                if (conn.State == ConnectionState.Closed)  
                    conn.Open();  
                try  
                {  
                    await conn.ExecuteAsync(query, new { CategoryId }, commandType: CommandType.Text);  
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
        public async Task<bool> EditCategory(int CategoryId, Category category)  
        {  
            using (var conn = new SqlConnection(_configuration.Value))  
            {  
                const string query = @"update dbo.Category set Name = @Name where CategoryId=@CategoryId";  
                if (conn.State == ConnectionState.Closed)  
                    conn.Open();  
                try  
                {  
                    await conn.ExecuteAsync(query, new { category.CategoryName, CategoryId }, commandType: CommandType.Text);  
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
        public async Task<IEnumerable<Category>> GetCategories()  
        {  
            IEnumerable<Category> categories;  
            using (var conn = new SqlConnection(_configuration.Value))  
            {  
                const string query = @"select * from cash.dbo.Category";  
  
                if (conn.State == ConnectionState.Closed)  
                    conn.Open();  
                try  
                {  
                    categories = await conn.QueryAsync<Category>(query);  
  
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
            return categories;  
        }
        
        public async Task<Category> SingleCategory(int CategoryId)  
        {  
            Category category = new Category();  
  
            using (var conn = new SqlConnection(_configuration.Value))  
            {  
                const string query = @"select * from dbo.Category where CategoryId =@CategoryId";  
  
                if (conn.State == ConnectionState.Closed)  
                    conn.Open();  
                try  
                {  
                    category = await conn.QueryFirstOrDefaultAsync<Category>(query, new { CategoryId }, commandType: CommandType.Text);  
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
            return category;  
        }  
    }  
}  