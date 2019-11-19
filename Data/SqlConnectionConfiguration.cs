using System;

namespace WebApplication1.Data
{
    public class SqlConnectionConfiguration  
    {  
        public SqlConnectionConfiguration(string value) => Value = value;  
        public string Value { get; }  
    } 

}
