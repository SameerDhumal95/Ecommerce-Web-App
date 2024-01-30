﻿using ShoppingCart.DataAccess.Data;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;

        public ICategoryRepository Category { get; private set; }

        public IProductRepository Product { get; private set; }

        public ICartRepository Cart { get; private set; }

        public IApplicationUser ApplicationUser { get; private set; }
        public OrderDetailRepository OrderDetail { get; private set; }
        public IOrderHeaderRepository OrderHeader {  get; private set; }

        public IOrderDetailRepository OrderDetails => throw new NotImplementedException();

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            this.Category = new CategoryRepository(context);
            Product = new ProductRepository(context);

            Cart = new CartRepository(context);
            ApplicationUser = new ApplicationUserRepository(context);
            OrderDetail = new OrderDetailRepository(context);
            OrderHeader = new OrderHeaderRepository(context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
