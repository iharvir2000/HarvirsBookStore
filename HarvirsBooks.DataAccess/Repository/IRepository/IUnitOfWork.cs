using System;

namespace HarvirsBooks.DataAccess.Repository.IRepository
{
    interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ICategoryRepository CoverType { get; }

        ISP_Call SP_Call { get; }
    }
}
