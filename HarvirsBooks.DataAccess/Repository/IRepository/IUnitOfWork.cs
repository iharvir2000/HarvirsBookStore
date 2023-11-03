namespace HarvirsBooks.DataAccess.Repository.IRepository
{
    interface UnitOfWork
    {
        ICategoryRepository Category { get; }

        ISP_Call SP_Call { get; }
    }
}
