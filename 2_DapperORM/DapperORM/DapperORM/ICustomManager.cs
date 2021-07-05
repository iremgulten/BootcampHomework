using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace DapperORM
{
    public interface ICustomManager<TEntity,TKey> where TEntity : class
    {
        List<TEntity> GetAll();
        bool AddCustomer(TEntity item);
        bool UpdateCustomer(TEntity item);
        bool DeleteCustomer(TEntity item);
    }
}
