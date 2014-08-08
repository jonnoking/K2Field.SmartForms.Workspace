using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2Field.SmartForms.Workspace.Data
{
    public class WorkspaceUser : INotify
    {
        //private Guid id;
        //public Guid Id
        //{
        //    get { return id; }
        //    set
        //    {
        //        if (id != value)
        //        {
        //            id = value;
        //            NotifyPropertyChanged("Id");
        //        }
        //    }
        //}

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    NotifyPropertyChanged("Name");
                }
            }
        }

        private string displayname;
        public string DisplayName
        {
            get { return displayname; }
            set
            {
                if (displayname != value)
                {
                    displayname = value;
                    NotifyPropertyChanged("DisplayName");
                }
            }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                if (email != value)
                {
                    email = value;
                    NotifyPropertyChanged("Email");
                }
            }
        }

        private string fqn;
        public string FQN
        {
            get { return fqn; }
            set
            {
                if (fqn != value)
                {
                    fqn = value;
                    NotifyPropertyChanged("FQN");
                }
            }
        }

        private bool isactive;
        public bool IsActive
        {
            get
            {
                return isactive;
            }
            set
            {
                if (isactive != value)
                {
                    isactive = value;
                    NotifyPropertyChanged("IsActive");
                }
            }
        }

        private ObservableCollection<WorkspaceTeam> roles;
        public virtual ObservableCollection<WorkspaceTeam> Roles
        {
            get
            {
                return roles;
            }
            set
            {
                if (roles != value)
                {
                    roles = value;
                    NotifyPropertyChanged("Roles");
                }
            }
        }
    }
}
