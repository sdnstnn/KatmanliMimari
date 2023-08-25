using StoreDataAccess.Data;
using StoreModels;
using StoreDataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDataAccess.Repositories
{
    public class CategoryRepository:Repository<Category>, IRepositoryCategory
    {
        private ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context):base(context)
        {
            _context = context;
        }
        public void Update(Category category)
        {
            var categoryDB=_context.Categories.FirstOrDefault(x=>x.Id==category.Id);
            if (categoryDB!=null)
            {
                categoryDB.Nmae=category.Nmae;
                categoryDB.DisplayOrder=category.DisplayOrder;
            }
        }
    }
}
