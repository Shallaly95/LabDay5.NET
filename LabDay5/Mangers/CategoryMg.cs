using LabDay5.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDay5.Mangers
{
    public class CategoryMg : Mngr<Category>, ICategoryMngr
    {
        public CategoryMg(DbSet <Category> db) :base(db)
        { 
        }
    }
}
