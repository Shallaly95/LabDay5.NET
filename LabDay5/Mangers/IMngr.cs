using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDay5.Mangers
{
    public interface IMngr <T> where T : class
    {
        IEnumerable<T> GetAll();
       public void Add(T item);
        public void Remove(T item);
        public void Update(T item);

    }
}
