using LabDay5.Mangers;
using LabDay5.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDay5
{
    internal class UnitOfWork : IUnitOfWork
    {
        private ICategoryMngr _categoryMngr;
        private IPostMgr _postMgr;
        private IStorage storage;

        public UnitOfWork(IStorage storage)
        {
            this.storage = storage;            
        }

        public ICategoryMngr Cmgr
        {
            get 
            {
                if(this._categoryMngr == null)
                {
                    _categoryMngr = new CategoryMg(storage.Categories);
                }
                return _categoryMngr; 
            }
        }

        public IPostMgr Pmgr
        {
            get
            {
                if(this._postMgr == null)
                {
                    _postMgr = new PostMgr(storage.PostAttachments);
                }
                return _postMgr;
            }
        }

        public void savechanges()
        {
           storage.SaveChanges();
        }
    }
}
