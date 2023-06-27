﻿using cscb766.DataAccess.Data;
using cscb766.DataAccess.Repository.IRepository;
using cscb766.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace cscb766.DataAccess.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private readonly ApplicationDbContext _db;

        public ShoppingCartRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ShoppingCart obj)
        {
            _db.ShoppingCarts.Update(obj);
        }
    }
}