﻿using CascadingDDLCoreDemo.Models;

namespace CascadingDDLCoreDemo.Data.Repository.IRepository
{
    public interface ICategoryRepository:IRepository<Category>
    {
        void Update(Category category);
    }
}
