﻿using StoreDataAccess.Data;
using StoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDataAccess.Repositories
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        private ApplicationDbContext _context;
        public OrderDetailRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(OrderDetail orderDetail)
        {
            _context.OrderDetails.Update(orderDetail);
            //var categoryDB = _context.Categories.FirstOrDefault(x => x.Id == category.Id);
            //if (categoryDB != null)
            //{
            //    categoryDB.Name = category.Name;
            //    categoryDB.DisplayOrder = category.DisplayOrder;
            //}
        }
    }
}
