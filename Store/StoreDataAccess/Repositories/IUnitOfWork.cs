using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDataAccess.Repositories
{
    public interface IUnitOfWork
    {
        IRepositoryCategory Category { get; }
        
        IRepositoryProduct Product { get; }
        ICartRepository Cart { get; }


        IApplicationUser ApplicationUser { get; }
      
        IOrderHeaderRepository OrderHeader { get; }
        IOrderDetailRepository OrderDetail { get; }
        
        void Save();

    }
}
