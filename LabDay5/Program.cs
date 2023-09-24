using System;
using System.Collections.Generic;
using LabDay5.Mangers;
using LabDay5.Models;
using LabDay5.Storage;

namespace LabDay5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mngr asd = new Mngr();
            IStorage storage = new InMemoryStorage();
            IUnitOfWork unitOfWork = new UnitOfWork(storage);

            unitOfWork.Pmgr.Add(new PostAttachment { Id = 1, Name = "Shallaly" });
            unitOfWork.Pmgr.Add(new PostAttachment { Id = 12, Name = "Shallaly2" });

            unitOfWork.savechanges();
            IEnumerable<PostAttachment> list = unitOfWork.Pmgr.GetAll();
            foreach (PostAttachment item in list)
                Console.WriteLine(item.Name);
        }
    }
}