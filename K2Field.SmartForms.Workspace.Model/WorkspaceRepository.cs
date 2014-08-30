using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace K2Field.SmartForms.Workspace.Model
{
    public class WorkspaceRepository : IRepository<K2Field.SmartForms.Workspace.Data.Workspace>
    {
        protected DbSet<K2Field.SmartForms.Workspace.Data.Workspace> DBSet { get; set; }
        protected DbContext Context { get; set; }

        public WorkspaceRepository(DbContext context)
        {
            if (context == null)
            {
                throw new ArgumentException("An instance of DbContext is " +
                    "required to use this repository.", "context");
            }

            this.Context = context;
            this.DBSet = this.Context.Set<K2Field.SmartForms.Workspace.Data.Workspace>();
        }

        public virtual IQueryable<K2Field.SmartForms.Workspace.Data.Workspace> All()
        {
            //return DBSet.Include("Profile").Include("Email").Where(p => p.Profile.ProfileName.Equals(username, StringComparison.OrdinalIgnoreCase)).AsEnumerable()
            //    .Select(k => SimplifyLocation(k)).ToList<Data.Location>();
            return DBSet;
        }

        public virtual IQueryable<K2Field.SmartForms.Workspace.Data.Workspace> All(Func<K2Field.SmartForms.Workspace.Data.Workspace, bool> where)
        {
            return DBSet.Where(where).AsQueryable();
        }

        public virtual IQueryable<K2Field.SmartForms.Workspace.Data.Workspace> AllIncluding(params Expression<Func<K2Field.SmartForms.Workspace.Data.Workspace, object>>[] includeProperties)
        {
            IQueryable<K2Field.SmartForms.Workspace.Data.Workspace> query = DBSet;
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return DBSet;
        }

        public virtual K2Field.SmartForms.Workspace.Data.Workspace Find(Guid id)
        {
            return DBSet.Find(id);
        }

        public virtual void Add(K2Field.SmartForms.Workspace.Data.Workspace entity)
        {
            DbEntityEntry entry = this.Context.Entry(entity);
            if (entry.State != EntityState.Detached)
            {
                entry.State = EntityState.Added;
            }
            else
            {
                this.DBSet.Add(entity);
            }
        }

        public virtual void Update(K2Field.SmartForms.Workspace.Data.Workspace entity)
        {
            DbEntityEntry entry = this.Context.Entry(entity);

            if (entry.State == EntityState.Detached)
            {
                this.DBSet.Attach(entity);
            }

            entry.State = EntityState.Modified;
        }

        public virtual void Detach(K2Field.SmartForms.Workspace.Data.Workspace entity)
        {
            DbEntityEntry entry = this.Context.Entry(entity);

            entry.State = EntityState.Detached;
        }

        public virtual void Delete(K2Field.SmartForms.Workspace.Data.Workspace entity)
        {
            DbEntityEntry entry = this.Context.Entry(entity);

            if (entry.State != EntityState.Deleted)
            {
                entry.State = EntityState.Deleted;
            }
            else
            {
                this.DBSet.Attach(entity);
                this.DBSet.Remove(entity);
            }
        }

        public virtual void Delete(Guid id)
        {
            var entity = this.Find(id);

            if (entity != null)
            {
                this.Delete(entity);
            }
        }


        //public virtual void InsertOrUpdate(T entity)
        //{
        //    if (entity.Id == default(int))
        //    {
        //        // New entity
        //        DBSet.Add(EventType);
        //    }
        //    else
        //    {
        //        // Existing entity
        //        context.Entry(EventType).State = EntityState.Modified;
        //    }
        //}



    }
}
