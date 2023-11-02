using HarvirsBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HarvirsBooks.DataAccess.Repository.IRepository
{
   public interface ICategoryRepository : IRepository<Category>
    {
        void update(Category category);
    }
}
