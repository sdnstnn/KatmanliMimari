using StoreDataAccess.Repositories;
using StoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDataAccess.Repositories
{
    public interface IRepositoryCategory : IRepository<Category>
    {
        void Update(Category category);
    }
}


