using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2Field.SmartForms.Workspace.Model
{
    public class ApplicationUnit : IDisposable
    {
        private WorkspaceContext _context = new WorkspaceContext();

        private IRepository<Data.Workspace> _workspace = null;
        private IRepository<Data.WorkspaceLink> _workspacelink = null;
        private IRepository<Data.WorkspaceTeam> _workspaceteam = null;
        //private IRepository<Data.WorkspaceUser> _workspaceuser = null;
        private WorkspaceUserRepository _workspaceuser = null;


        public IRepository<Data.Workspace> Workspaces
        {
            get
            {
                if (this._workspace == null)
                {
                    this._workspace = new GenericRepository<Data.Workspace>(this._context);
                }
                return this._workspace;
            }
        }

        public IRepository<Data.WorkspaceLink> WorkspaceLinks
        {
            get
            {
                if (this._workspacelink == null)
                {
                    this._workspacelink = new GenericRepository<Data.WorkspaceLink>(this._context);
                }
                return this._workspacelink;
            }
        }

        public IRepository<Data.WorkspaceTeam> WorkspaceTeams
        {
            get
            {
                if (this._workspaceteam == null)
                {
                    this._workspaceteam = new GenericRepository<Data.WorkspaceTeam>(this._context);
                }
                return this._workspaceteam;
            }
        }

        public WorkspaceUserRepository WorkspaceUsers
        {
            get
            {
                if (this._workspaceuser == null)
                {
                    this._workspaceuser = new WorkspaceUserRepository(this._context);
                }
                return this._workspaceuser;
            }
        }


        public int SaveChanges()
        {
            return this._context.SaveChanges();
        }

        public void Dispose()
        {
            if (this._context != null)
            {
                this._context.Dispose();
            }
        }
    }
}
