using StoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDataAccess.Repositories
{
    public interface IRepositoryProduct:IRepository<Product>
    {
        void Update(Product product);
    }
}
