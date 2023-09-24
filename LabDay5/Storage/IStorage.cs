using LabDay5.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LabDay5.Storage
{
    public interface IStorage
    {
        DbSet<Category> Categories { get; set; }
        DbSet<PostAttachment> PostAttachments { get; set; }


        int SaveChanges();



    }
}