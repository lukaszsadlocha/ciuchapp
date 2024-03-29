﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using CiuchApp.Domain;
using System.Threading.Tasks;
using CiuchApp.DataContext;

namespace CiuchApp.Services
{
    public class DropdownService<T> : BaseService<T>, ICrudService<T> where T: CiuchAppBaseModel
    {
        private DbSet<T> _contextSet;
        public DropdownService(ApplicationDbContext context) : base(context)
        {
            _contextSet = context.Set<T>();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _contextSet.ToListAsync();
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await _contextSet.FirstOrDefaultAsync(x => x.Id == id);
        }

        public IList<T> GetAll()
        {
            return _contextSet.ToList();
        }

        public bool Add(T item)
        {
            _contextSet.Add(item);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(T item)
        {
            _contextSet.Remove(item);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            _contextSet.Remove(_contextSet.First(x=>x.Id==id));
            return _context.SaveChanges() > 0;
        }

        public T GetById(int id)
        {
            return _contextSet.GetById<T>(id);
        }

        public bool Update(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }
    }
}
