using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using K2Field.SmartForms.Workspace.Model;
using System.Data.Entity;
using System.Collections.ObjectModel;

namespace K2Field.SmartForms.Workspace.Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // will reset database
            Database.SetInitializer(new DropCreateDatabaseAlways<K2Field.SmartForms.Workspace.Model.WorkspaceContext>());

            using (var unit = new ApplicationUnit())
            {
                Data.WorkspaceUser u = new Data.WorkspaceUser() { Username = @"K2:denallix\administrator", FQN = @"denallix\administrator", DisplayName = "Administrator", Email = "administrator@denallix.com", IsActive = true };



                Data.WorkspaceLink link1a = new Data.WorkspaceLink()
                {
                    Name = "mytasks",
                    DisplayName = "My Tasks",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "https://k2.denallix.com/Runtime/Runtime/View/Demo+CRM+Account+List/",
                    Type = "Link",
                    Icon = "fa fa-bar-chart-o fa-fw",
                    MinHeight = 500
                };

                Data.WorkspaceLink link1b = new Data.WorkspaceLink()
                {
                    Name = "teamtasks",
                    DisplayName = "Team Tasks",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "https://k2.denallix.com/Runtime/Runtime/View/Demo+CRM+Account+List/",
                    Type = "Link",
                    Icon = "fa fa-bar-chart-o fa-fw",
                    MinHeight = 500
                };

                Data.WorkspaceLink link1c = new Data.WorkspaceLink()
                {
                    Name = "hrtasks",
                    DisplayName = "HR Tasks",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "https://k2.denallix.com/Runtime/Runtime/View/Demo+CRM+Account+List/",
                    Type = "Link",
                    Icon = "fa fa-bar-chart-o fa-fw",
                    MinHeight = 500
                };

                ObservableCollection<Data.WorkspaceLink> tasks = new ObservableCollection<Data.WorkspaceLink>();
                tasks.Add(link1a);
                tasks.Add(link1b);
                tasks.Add(link1c);

                Data.WorkspaceLink link1 = new Data.WorkspaceLink()
                {
                    Name = "tasks",
                    DisplayName = "Tasks",
                    IsEnabled = true,
                    IsSmartForm = false,
                    Level = 0,
                    Type = "Heading",
                    ChildLinks = tasks,
                    Icon = "fa fa-bar-chart-o fa-fw",
                };


                Data.WorkspaceLink link2 = new Data.WorkspaceLink()
                {
                    Name = "apps",
                    DisplayName = "Apps",
                    IsEnabled = true,
                    IsSmartForm = false,
                    Level = 0,
                    Url = "https://k2.denallix.com/Runtime/Runtime/View/Demo+CRM+Account+List/",
                    Type = "Heading",
                    Icon = "fa fa-bar-chart-o fa-fw",
                };


                Data.WorkspaceLink link3 = new Data.WorkspaceLink()
                {
                    Name = "dashboards",
                    DisplayName = "Dashboards",
                    IsEnabled = true,
                    IsSmartForm = false,
                    Level = 0,
                    Type = "Heading"
                };

                ObservableCollection<Data.WorkspaceLink> headings = new ObservableCollection<Data.WorkspaceLink>();
                headings.Add(link1);
                headings.Add(link2);
                headings.Add(link3);

                    //Url = "https://k2.denallix.com/Runtime/Runtime/View/Demo+CRM+Account+List/",
                

                unit.WorklistUsers.Add(u);

                Data.Workspace w = new Data.Workspace() { DisplayName = "Workspace", Name = "workspace", SmartFormsRuntimeUrl = "https://k2.denallix.com/runtime/", Links = headings };
                unit.Workspaces.Add(w);

                int rows = unit.SaveChanges();
                MessageBox.Show("Rows: " + rows);
            }

            //using (var context = new K2Field.SmartForms.Workspace.Model.WorkspaceContext())
            //{
            //    //K2Field.Demo.CaseManagement.Data.CaseType ct = new CaseManagement.Data.CaseType() { Name = "Incident Management", UseSharePoint = false, LifeCycleProcess = "Incident Process", Description = "Incident Management" };

            //    Data.WorkspaceUser u = new Data.WorkspaceUser() { Username = @"K2:denallix\administrator", FQN = @"denallix\administrator", DisplayName = "Administrator", Email = "administrator@denallix.com", IsActive = true };

            //    context.User.Add(u);
                
            //    int rows = context.SaveChanges();
            //    MessageBox.Show("Rows: " + rows);

            //}
        }
    }
}
