using CiuchApp.DataContext;
using CiuchApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace CiuchApp.Services
{
    public abstract class BaseService<T> where T : CiuchAppBaseModel
    {
        protected readonly ApplicationDbContext _context;
        public BaseService(ApplicationDbContext context)
        {
            _context = context;
        }

        public ApplicationDbContext GetContext()
        {
            return _context;
        }

        public DbSet<T> GetSet()
        {
            return _context.Set<T>();
        }
    }
}