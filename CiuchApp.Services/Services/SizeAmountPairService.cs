using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CiuchApp.DataContext;
using CiuchApp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace CiuchApp.Services
{
    public class SizeAmountPairService : BaseService<SizeAmountPair>, ICrudService<SizeAmountPair>
    {
        public SizeAmountPairService(ApplicationDbContext context) : base(context)
        {
        }

        public bool Add(SizeAmountPair item)
        {
            _context.SizeAmountPairs.Add(item);
            return _context.SaveChanges() > 0;
        }

        public bool Update(SizeAmountPair item)
        {
            _context.Entry(item).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }

        public bool Delete(SizeAmountPair item)
        {
            _context.SizeAmountPairs.Remove(item);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            _context.SizeAmountPairs.Remove(_context.SizeAmountPairs.First(x => x.Id == id));
            return _context.SaveChanges() > 0;
        }

        public IList<SizeAmountPair> GetAll() => GetSizeAmountPairsIncludeSize().ToList();
        public async Task<List<SizeAmountPair>> GetAllAsync() => await GetSizeAmountPairsIncludeSize().ToListAsync();
        public Task<SizeAmountPair> GetByIdAsync(int id) => GetSizeAmountPairsIncludeSize().FirstOrDefaultAsync(x => x.Id == id);
        public SizeAmountPair GetById(int id) => GetSizeAmountPairsIncludeSize().First(x => x.Id == id);
        private IIncludableQueryable<SizeAmountPair, Size> GetSizeAmountPairsIncludeSize() => _context.SizeAmountPairs.Include(p => p.Size);
    }
}
