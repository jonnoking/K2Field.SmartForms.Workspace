using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2Field.SmartForms.Workspace.Model
{
    public class WorkspaceContext : DbContext
    {
        public WorkspaceContext()
            : base("WorkspaceContext")
        {
        }

        public DbSet<K2Field.SmartForms.Workspace.Data.Workspace> Workspace { get; set; }
        public DbSet<K2Field.SmartForms.Workspace.Data.WorkspaceTeam> Team { get; set; }
        public DbSet<K2Field.SmartForms.Workspace.Data.WorkspaceUser> User { get; set; }
        public DbSet<K2Field.SmartForms.Workspace.Data.WorkspaceLink> Link { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Data.Workspace>().Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Data.WorkspaceTeam>().Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Data.WorkspaceLink>().Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Data.WorkspaceUser>().HasKey(p => p.Username);

            //modelBuilder.Entity<Data.CaseUser>().Ignore(p => p.FullName);
            //modelBuilder.Entity<Data.CaseInstance>().Ignore(p => p.ExceedsExpected);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //base.OnModelCreating(modelBuilder);
        }

    }
}
