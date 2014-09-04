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

            // team - user m:m
            modelBuilder.Entity<Data.WorkspaceTeam>().HasMany(r => r.WorkspaceUsers).WithMany(u => u.WorkspaceTeams)
              .Map(mc =>
              {
                  mc.ToTable("WorkspaceTeamUsers");
                  mc.MapLeftKey("WorkspaceTeamId");
                  mc.MapRightKey("WorkspaceUserId");
              });

            modelBuilder.Entity<Data.Workspace>().HasMany(r => r.WorkspaceTeams).WithMany(u => u.Workspaces)
              .Map(mc =>
              {
                  mc.ToTable("WorkspaceTeamWorkspaces");
                  mc.MapLeftKey("WorkspaceId");
                  mc.MapRightKey("WorkspaceTeamId");
              });

            modelBuilder.Entity<Data.Workspace>().HasMany(r => r.Links).WithMany(u => u.Workspaces)
              .Map(mc =>
              {
                  mc.ToTable("WorkspaceLinksWorkspaces");
                  mc.MapLeftKey("WorkspaceId");
                  mc.MapRightKey("WorkspaceLinkId");
              });

            modelBuilder.Entity<Data.WorkspaceLink>().HasMany(r => r.ChildLinks).WithMany(u => u.ParentLinks)
              .Map(mc =>
              {
                  mc.ToTable("WorkspaceLinksWorkspacesLinks");
                  mc.MapLeftKey("WorkspaceLinkChildId");
                  mc.MapRightKey("WorkspaceLinkParentId");
              });

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //base.OnModelCreating(modelBuilder);
        }

    }
}
