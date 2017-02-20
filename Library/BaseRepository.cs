using Microsoft.EntityFrameworkCore;
using PlanMySave.Library.Interface;
using PlanMySave.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanMySave.Library
{
    public abstract class BaseRepository<M> : IBaseRepository<M> where M : class, IEntity
    {
        protected PlanMySaveContext Db { get; }
        private DbSet<M> table = null;

        protected DbSet<M> Table
        {
            get
            {
                return this.table;
            }
        }

        public BaseRepository(PlanMySaveContext dbContext)
        {
            Db = dbContext;
            this.table = Db.Set<M>();
        }

        public void Delete(int id)
        {
            M existing = this.SelectByID(id);
            if (existing != null)
                this.table.Remove(existing);
        }

        public void Delete(M m)
        {
            this.table.Remove(m);
            this.Save();
        }

        public void Insert(M obj)
        {
            this.table.Add(obj);
            this.Save();
        }

        public void Save()
        {
            this.Db.SaveChanges();
        }

        public IEnumerable<M> SelectAll()
        {
            return table.ToList();
        }

        public M SelectByID(int id)
        {
            return table.FirstOrDefault(m => m.Id == id);
        }

        public void Update(M obj)
        {
            table.Attach(obj);
            Db.Entry(obj).State = EntityState.Modified;
            this.Save();
        }
    }
}
