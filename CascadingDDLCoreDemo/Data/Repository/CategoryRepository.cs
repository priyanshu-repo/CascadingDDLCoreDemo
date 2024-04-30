﻿using CascadingDDLCoreDemo.Data.Repository.IRepository;
using CascadingDDLCoreDemo.Models;

namespace CascadingDDLCoreDemo.Data.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            _db.Categories.Update(category);
        }
    }
}
