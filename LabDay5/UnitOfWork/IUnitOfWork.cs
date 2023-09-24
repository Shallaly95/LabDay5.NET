using LabDay5.Mangers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDay5
{
    public interface IUnitOfWork
    {    
        ICategoryMngr Cmgr { get; }
        IPostMgr Pmgr { get; }
        void savechanges();
           
    }
}
