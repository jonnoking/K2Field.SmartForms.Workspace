using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace K2Field.SmartForms.Workspace.Data
{

    public class WorkspaceLink : INotify
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

        
        private string smartform;
        public string SmartForm
        {
            get { return smartform; }
            set
            {
                if (smartform != value)
                {
                    smartform = value;
                    NotifyPropertyChanged("SmartForm");
                }
            }
        }


        private string url;
        public string Url
        {
            get { return url; }
            set
            {
                if (url != value)
                {
                    url = value;
                    NotifyPropertyChanged("Url");
                }
            }
        }

        private bool issmartform;
        public bool IsSmartForm
        {
            get { return issmartform; }
            set
            {
                if (issmartform != value)
                {
                    issmartform = value;
                    NotifyPropertyChanged("IsSmartForm");
                }
            }
        }


        private int level;
        public int Level
        {
            get { return level; }
            set
            {
                if (level != value)
                {
                    level = value;
                    NotifyPropertyChanged("Level");
                }
            }
        }

        private string type;
        public string Type
        {
            get { return type; }
            set
            {
                if (type != value)
                {
                    type = value;
                    NotifyPropertyChanged("Type");
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

        private bool isenabled;
        public bool IsEnabled
        {
            get { return isenabled; }
            set
            {
                if (isenabled != value)
                {
                    isenabled = value;
                    NotifyPropertyChanged("IsEnabled");
                }
            }
        }

        private int sequence;
        public int Sequence
        {
            get { return sequence; }
            set
            {
                if (sequence != value)
                {
                    sequence = value;
                    NotifyPropertyChanged("Sequence");
                }
            }
        }

        private int minheight;
        public int MinHeight
        {
            get { return minheight; }
            set
            {
                if (minheight != value)
                {
                    minheight = value;
                    NotifyPropertyChanged("MinHeight");
                }
            }
        }


        private ObservableCollection<WorkspaceLink> childlinks;
        public virtual ObservableCollection<WorkspaceLink> ChildLinks
        {
            get
            {
                return childlinks;
            }
            set
            {
                if (childlinks != value)
                {
                    childlinks = value;
                    NotifyPropertyChanged("ChildLinks");
                }
            }
        }

        private ObservableCollection<WorkspaceLink> parentlinks;
        public virtual ObservableCollection<WorkspaceLink> ParentLinks
        {
            get
            {
                return parentlinks;
            }
            set
            {
                if (parentlinks != value)
                {
                    parentlinks = value;
                    NotifyPropertyChanged("ParentLinks");
                }
            }
        }


        private ObservableCollection<Workspace> workspaces;
        public virtual ObservableCollection<Workspace> Workspaces
        {
            get
            {
                return workspaces;
            }
            set
            {
                if (workspaces != value)
                {
                    workspaces = value;
                    NotifyPropertyChanged("Workspaces");
                }
            }
        }


        //public event PropertyChangedEventHandler PropertyChanged;
        //public void NotifyPropertyChanged(string propertyName)
        //{
        //    if (PropertyChanged != null)
        //    {
        //        PropertyChanged(this,
        //            new PropertyChangedEventArgs(propertyName));
        //    }
        //}
    }
}
