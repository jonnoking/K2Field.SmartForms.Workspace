using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2Field.SmartForms.Workspace.Data
{
    public class Workspace : INotify
    {
        private Guid id;
        public Guid Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    NotifyPropertyChanged("Id");
                }
            }
        }

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

        private string description;
        public string Description
        {
            get { return description; }
            set
            {
                if (description != value)
                {
                    description = value;
                    NotifyPropertyChanged("Description");
                }
            }
        }

        private string smartformsruntimeurl;
        public string SmartFormsRuntimeUrl
        {
            get { return smartformsruntimeurl; }
            set
            {
                if (smartformsruntimeurl != value)
                {
                    smartformsruntimeurl = value;
                    NotifyPropertyChanged("SmartFormsRuntimeUrl");
                }
            }
        }

        private string icon;
        public string Icon
        {
            get { return icon; }
            set
            {
                if (icon != value)
                {
                    icon = value;
                    NotifyPropertyChanged("Icon");
                }
            }
        }


        private WorkspaceLink starturl;

        public virtual WorkspaceLink StartUrl
        {
            get { return starturl; }
            set
            {
                if (starturl != value)
                {
                    starturl = value;
                    NotifyPropertyChanged("StartUrl");
                }
            }
        }


        private ObservableCollection<WorkspaceLink> links;
        public virtual ObservableCollection<WorkspaceLink> Links
        {
            get
            {
                return links;
            }
            set
            {
                if (links != value)
                {
                    links = value;
                    NotifyPropertyChanged("Links");
                }
            }
        }

        private ObservableCollection<WorkspaceTeam> workspaceteams;
        public virtual ObservableCollection<WorkspaceTeam> WorkspaceTeams
        {
            get
            {
                return workspaceteams;
            }
            set
            {
                if (workspaceteams != value)
                {
                    workspaceteams = value;
                    NotifyPropertyChanged("WorkspaceTeams");
                }
            }
        }

        private ObservableCollection<WorkspaceUser> workspaceusers;
        public virtual ObservableCollection<WorkspaceUser> WorkspaceUsers
        {
            get
            {
                return workspaceusers;
            }
            set
            {
                if (workspaceusers != value)
                {
                    workspaceusers = value;
                    NotifyPropertyChanged("WorkspaceUsers");
                }
            }
        }

    }
}
