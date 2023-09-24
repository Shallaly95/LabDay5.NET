using LabDay5.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDay5.Mangers
{
    public class Mngr<T> : IMngr<T> where T : BasModel
    {   
        private DbSet<T> _dbSet;
        public Mngr(DbSet<T> dbSet)
        {
            _dbSet = dbSet;
        }
        public void Add(T item)
        {
            _dbSet.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet;
        }

        public void Remove(T item)
        {
            _dbSet.Remove(item);
        }

        public void Update(T item)
        {
            _dbSet.Update(item);
        }
    }
}
