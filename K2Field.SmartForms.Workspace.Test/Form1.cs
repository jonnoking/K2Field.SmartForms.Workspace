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

            CreateK2UKApp();

            //using (var unit = new ApplicationUnit())
            //{
            //    Data.WorkspaceUser u = new Data.WorkspaceUser() { Username = @"denallix\administrator", FQN = @"denallix\administrator", DisplayName = "Administrator", Email = "administrator@denallix.com", IsActive = true };

            //    ObservableCollection<Data.WorkspaceUser> r = new ObservableCollection<Data.WorkspaceUser>();
            //    r.Add(u);

            //    Data.WorkspaceTeam t = new Data.WorkspaceTeam()
            //    {
            //        Name = "team1",
            //        DisplayName = "Team 1",
            //        Description = "team description team description team description",
            //        IsActive = true,
            //        WorkspaceUsers = r,                    
            //    };

            //    Data.WorkspaceLink link1a = new Data.WorkspaceLink()
            //    {
            //        Name = "mytasks",
            //        DisplayName = "My Tasks",
            //        IsEnabled = true,
            //        IsSmartForm = true,
            //        Level = 1,
            //        Url = "https://k2.denallix.com/Runtime/Runtime/View/Demo+CRM+Account+List/",
            //        Type = "Link",
            //        Icon = "fa fa-bar-chart-o fa-fw",
            //        MinHeight = 150
            //    };

            //    Data.WorkspaceLink link1b = new Data.WorkspaceLink()
            //    {
            //        Name = "teamtasks",
            //        DisplayName = "Team Tasks",
            //        IsEnabled = true,
            //        IsSmartForm = true,
            //        Level = 1,
            //        Url = "https://k2.denallix.com/Runtime/Runtime/View/Demo+CRM+Account+List/",
            //        Type = "Link",
            //        Icon = "fa fa-bar-chart-o fa-fw",
            //        MinHeight = 500
            //    };

            //    Data.WorkspaceLink link1c = new Data.WorkspaceLink()
            //    {
            //        Name = "hrtasks",
            //        DisplayName = "HR Tasks",
            //        IsEnabled = true,
            //        IsSmartForm = true,
            //        Level = 1,
            //        Url = "https://k2.denallix.com/Runtime/Runtime/View/Demo+CRM+Account+List/",
            //        Type = "Link",
            //        Icon = "fa fa-bar-chart-o fa-fw",
            //        MinHeight = 300
            //    };

            //    ObservableCollection<Data.WorkspaceLink> tasks = new ObservableCollection<Data.WorkspaceLink>();
            //    tasks.Add(link1a);
            //    tasks.Add(link1b);
            //    tasks.Add(link1c);

            //    Data.WorkspaceLink link1 = new Data.WorkspaceLink()
            //    {
            //        Name = "tasks",
            //        DisplayName = "Tasks",
            //        IsEnabled = true,
            //        IsSmartForm = false,
            //        Level = 0,
            //        Type = "Heading",
            //        ChildLinks = tasks,
            //        Icon = "fa fa-bar-chart-o fa-fw",
            //    };


            //    Data.WorkspaceLink link2 = new Data.WorkspaceLink()
            //    {
            //        Name = "apps",
            //        DisplayName = "Apps",
            //        IsEnabled = true,
            //        IsSmartForm = false,
            //        Level = 0,
            //        Url = "https://k2.denallix.com/Runtime/Runtime/View/Demo+CRM+Account+List/",
            //        Type = "Heading",
            //        Icon = "fa fa-bar-chart-o fa-fw",
            //    };


            //    Data.WorkspaceLink link3 = new Data.WorkspaceLink()
            //    {
            //        Name = "dashboards",
            //        DisplayName = "Dashboards",
            //        IsEnabled = true,
            //        IsSmartForm = false,
            //        Level = 0,
            //        Type = "Heading"
            //    };

            //    ObservableCollection<Data.WorkspaceLink> headings = new ObservableCollection<Data.WorkspaceLink>();
            //    headings.Add(link1);
            //    headings.Add(link2);
            //    headings.Add(link3);

            //        //Url = "https://k2.denallix.com/Runtime/Runtime/View/Demo+CRM+Account+List/",
                

            //    //unit.WorklistUsers.Add(u);


            //    Data.Workspace w = new Data.Workspace() 
            //    { 
            //        DisplayName = "K2 Workdesck", 
            //        Name = "K2workdesk",
            //        Description = "K2 Workdesk description....",
            //        SmartFormsRuntimeUrl = "https://k2.denallix.com/runtime/", 
            //        Links = headings 
            //    };

            //    Data.Workspace w1 = new Data.Workspace()
            //    {
            //        DisplayName = "K2 HR Workdesk",
            //        Name = "k2hrworkspace",
            //        Description = "K2 HR Workdesk description...",
            //        SmartFormsRuntimeUrl = "https://k2.denallix.com/runtime/",
            //        Links = headings
            //    };

            //    Data.Workspace w2 = new Data.Workspace()
            //    {
            //        DisplayName = "K2 Finance Workdesk",
            //        Name = "k2financeworkspace",
            //        Description = "K2 Finance Workdesk description...",
            //        SmartFormsRuntimeUrl = "https://k2.denallix.com/runtime/",
            //        Links = headings
            //    };

            //    w.WorkspaceTeams = new ObservableCollection<Data.WorkspaceTeam>();
            //    w.WorkspaceTeams.Add(t);

            //    w1.WorkspaceTeams = new ObservableCollection<Data.WorkspaceTeam>();
            //    w1.WorkspaceTeams.Add(t);

            //    w2.WorkspaceTeams = new ObservableCollection<Data.WorkspaceTeam>();
            //    w2.WorkspaceTeams.Add(t);

            //    //unit.WorkspaceTeams.Add(t);
            //    unit.Workspaces.Add(w);
            //    unit.Workspaces.Add(w1);
            //    unit.Workspaces.Add(w2);

            //    int rows = unit.SaveChanges();
            //    MessageBox.Show("Rows: " + rows);


            //    //w1.WorkspaceTeams = new ObservableCollection<Data.WorkspaceTeam>();
            //    //w1.WorkspaceTeams.Add(t);
            //    //w1.Links = headings;

            //    //unit.Workspaces.Update(w1);
            //    //rows = unit.SaveChanges();
            //    //MessageBox.Show("Rows: " + rows);

            //    //// throws error
            //    //w2.WorkspaceTeams = new ObservableCollection<Data.WorkspaceTeam>();
            //    //w2.WorkspaceTeams.Add(t);
            //    //w2.Links = headings;
                
            //    //unit.Workspaces.Update(w2);
            //    //rows = unit.SaveChanges();
            //    //MessageBox.Show("Rows: " + rows);

            //}

            //using (var context = new K2Field.SmartForms.Workspace.Model.WorkspaceContext())
            //{
            //    //K2Field.Demo.CaseManagement.Data.CaseType ct = new CaseManagement.Data.CaseType() { Name = "Incident Management", UseSharePoint = false, LifeCycleProcess = "Incident Process", Description = "Incident Management" };

            //    Data.WorkspaceUser u = new Data.WorkspaceUser() { Username = @"K2:denallix\administrator", FQN = @"denallix\administrator", DisplayName = "Administrator", Email = "administrator@denallix.com", IsActive = true };

            //    context.User.Add(u);
                
            //    int rows = context.SaveChanges();
            //    MessageBox.Show("Rows: " + rows);

            //}
        }


        private void CreateK2UKApp()
        {
            //Database.SetInitializer(new DropCreateDatabaseAlways<K2Field.SmartForms.Workspace.Model.WorkspaceContext>());

            using (var unit = new ApplicationUnit())
            {
                Data.WorkspaceUser u = new Data.WorkspaceUser() 
                { 
                    Username = @"denallix\administrator", 
                    FQN = @"denallix\administrator", 
                    DisplayName = "Administrator", 
                    Email = "administrator@denallix.com", 
                    IsActive = true 
                };


                ObservableCollection<Data.WorkspaceUser> r = new ObservableCollection<Data.WorkspaceUser>();
                r.Add(u);

                Data.WorkspaceTeam scna = new Data.WorkspaceTeam()
                {
                    Name = "scna",
                    DisplayName = "K2 SCNA",
                    Description = "K2 North American Team",
                    IsActive = true,
                    WorkspaceUsers = r,
                };

                Data.WorkspaceTeam scuk = new Data.WorkspaceTeam()
                {
                    Name = "scuk",
                    DisplayName = "K2 SCUK",
                    Description = "K2 UK Europe Team",
                    IsActive = true,
                    WorkspaceUsers = r,
                };

                Data.WorkspaceLink link1a = new Data.WorkspaceLink()
                {
                    Name = "mytasks",
                    DisplayName = "My Tasks",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "https://k2.denallix.com/Runtime/Runtime/Form/Worklist/",
                    Type = "Link",
                    Icon = "fa fa-male fa-fw",
                    MinHeight = 400
                };

                Data.WorkspaceLink link1b = new Data.WorkspaceLink()
                {
                    Name = "teamtasks",
                    DisplayName = "Team Tasks",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "https://k2.denallix.com/Runtime/Runtime/Form/Worklist/",
                    Type = "Link",
                    Icon = "fa fa-group fa-fw",
                    MinHeight = 400
                };

                Data.WorkspaceLink link1c = new Data.WorkspaceLink()
                {
                    Name = "servicetasks",
                    DisplayName = "Service Tasks",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "https://k2.denallix.com/Runtime/Runtime/Form/Worklist/",
                    Type = "Link",
                    Icon = "fa fa-sort-amount-asc fa-fw",
                    MinHeight = 400
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
                    Icon = "fa fa-tasks fa-fw",
                };


                Data.WorkspaceLink link2 = new Data.WorkspaceLink()
                {
                    Name = "apps",
                    DisplayName = "Apps",
                    IsEnabled = true,
                    IsSmartForm = false,
                    Level = 0,
                    //Url = "https://k2.denallix.com/Runtime/Runtime/View/Demo+CRM+Account+List/",
                    Type = "Heading",
                    Icon = "fa fa-cogs fa-fw",
                    MinHeight = 500
                };

                Data.WorkspaceLink taskalloc = new Data.WorkspaceLink()
                {
                    Name = "taskallocation",
                    DisplayName = "Task Allocation",
                    Description = "Allocate a managed tasks to users",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "https://k2.denallix.com/runtime/runtime/form/cm.task__create.form/?_theme=jove1",
                    Type = "Link",
                    Icon = "fa fa-sitemap fa-fw",
                    MinHeight = 500,
                    Sequence = 0,
                };

                Data.WorkspaceLink sendmessage = new Data.WorkspaceLink()
                {
                    Name = "sendmessage",
                    DisplayName = "Send Message",
                    Description = "Send a tracked email or SMS message",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "https://k2.denallix.com/runtime/runtime/form/cm.sendmessage.form/?_theme=jove1",
                    Type = "Link",
                    Icon = "fa fa-paper-plane fa-fw",
                    MinHeight = 500,
                    Sequence = 0,
                };

                Data.WorkspaceLink customerfeedback = new Data.WorkspaceLink()
                {
                    Name = "customerfeedback",
                    DisplayName = "Customer Feedback",
                    Description = "Record and manage customer feedback",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "https://k2.denallix.com/runtime/runtime/form/newportal__denallix__com__sales__lists__customer__feedbacktaskform/?_theme=jove1",
                    Type = "Link",
                    Icon = "fa fa-rocket fa-fw",
                    MinHeight = 500,
                    Sequence = 0,
                };

                Data.WorkspaceLink logaconversation = new Data.WorkspaceLink()
                {
                    Name = "logaconversation",
                    DisplayName = "Log a Conversation",
                    Description = "Log a conversation with an employee or customer",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "https://k2.denallix.com/runtime/runtime/form/cm.logconversation.form/",
                    Type = "Link",
                    Icon = "fa fa-wechat fa-fw",
                    MinHeight = 500,
                    Sequence = 0,
                };

                Data.WorkspaceLink employeeonboarding = new Data.WorkspaceLink()
                {
                    Name = "employeeonboarding",
                    DisplayName = "Employee Onboarding",
                    Description = "Onboard a new employee",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "https://k2.denallix.com/runtime/runtime/form/eo.submitnewemployee.form/",
                    Type = "Link",
                    Icon = "fa fa-desktop fa-fw",
                    MinHeight = 500,
                    Sequence = 0,
                };

                Data.WorkspaceLink raiseapurchaseorder = new Data.WorkspaceLink()
                {
                    Name = "raiseapurchaseorder",
                    DisplayName = "Raise Purchase Order",
                    Description = "Raise new purchase order",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "https://k2.denallix.com/runtime/runtime/form/po.raisenewpo.form/?_theme=jove1",
                    Type = "Link",
                    Icon = "fa fa-usd fa-fw",
                    MinHeight = 500,
                    Sequence = 0,
                };
                
                ObservableCollection<Data.WorkspaceLink> apps = new ObservableCollection<Data.WorkspaceLink>();
                apps.Add(taskalloc);
                apps.Add(sendmessage);
                apps.Add(customerfeedback);
                apps.Add(logaconversation);
                apps.Add(employeeonboarding);
                apps.Add(raiseapurchaseorder);

                link2.ChildLinks = apps;

                Data.WorkspaceLink link3 = new Data.WorkspaceLink()
                {
                    Name = "dashboards",
                    DisplayName = "Dashboards",
                    IsEnabled = true,
                    IsSmartForm = false,
                    Level = 0,
                    Type = "Heading",
                    Icon = "fa fa-dashboard fa-fw",
                    MinHeight = 500,
                    Sequence = 2,
                };


                Data.WorkspaceLink chart1 = new Data.WorkspaceLink()
                {
                    Name = "chart1",
                    DisplayName = "Org KPI ",
                    Description = "Organization wide KPIs",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "https://k2.denallix.com/runtime/runtime/form/po.raisenewpo.form/?_theme=jove1",
                    Type = "Link",
                    Icon = "fa fa-area-chart fa-fw",
                    MinHeight = 500,
                    Sequence = 0,
                };


                Data.WorkspaceLink chart2 = new Data.WorkspaceLink()
                {
                    Name = "chart2",
                    DisplayName = "Task Dashboard ",
                    Description = "Task Dashboard",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "https://k2.denallix.com/runtime/runtime/form/po.raisenewpo.form/?_theme=jove1",
                    Type = "Link",
                    Icon = "fa fa-line-chart fa-fw",
                    MinHeight = 500,
                    Sequence = 0,
                };

                Data.WorkspaceLink chart3 = new Data.WorkspaceLink()
                {
                    Name = "chart3",
                    DisplayName = "Customer Service Dashboard ",
                    Description = "Customer Service  Dashboard",
                    IsEnabled = true,
                    IsSmartForm = true,
                    Level = 1,
                    Url = "https://k2.denallix.com/runtime/runtime/form/po.raisenewpo.form/?_theme=jove1",
                    Type = "Link",
                    Icon = "fa fa-pie-chart fa-fw",
                    MinHeight = 500,
                    Sequence = 0,
                };

                ObservableCollection<Data.WorkspaceLink> dash = new ObservableCollection<Data.WorkspaceLink>();
                dash.Add(chart1);
                dash.Add(chart2);
                dash.Add(chart3);

                link3.ChildLinks = dash;

                ObservableCollection<Data.WorkspaceLink> headings = new ObservableCollection<Data.WorkspaceLink>();
                headings.Add(link1);
                headings.Add(link2);
                headings.Add(link3);

                //Url = "https://k2.denallix.com/Runtime/Runtime/View/Demo+CRM+Account+List/",


                //unit.WorklistUsers.Add(u);


                Data.Workspace w = new Data.Workspace()
                {
                    DisplayName = "K2 Workdesk",
                    Name = "K2workdesk",
                    Description = "K2 Workdesk description....",
                    SmartFormsRuntimeUrl = "https://k2.denallix.com/runtime/",
                    Links = headings,
                    Icon = "fa fa-suitcase fa-2x",
                };




                ObservableCollection<Data.WorkspaceLink> headings1 = new ObservableCollection<Data.WorkspaceLink>();
                headings1.Add(link1a);
                headings1.Add(link1b);
                headings1.Add(link1c);
                headings1.Add(chart1);
                headings1.Add(chart2);

                Data.Workspace w1 = new Data.Workspace()
                {
                    DisplayName = "Task Management",
                    Name = "taskmanagement",
                    Description = "Task Management workdesk description...",
                    SmartFormsRuntimeUrl = "https://k2.denallix.com/runtime/",
                    Links = headings1,
                    Icon = "fa fa-share-alt fa-2x",
                };


                Data.WorkspaceLink linkservice = new Data.WorkspaceLink()
                {
                    Name = "serviceapps",
                    DisplayName = "Service Apps",
                    IsEnabled = true,
                    IsSmartForm = false,
                    Level = 0,
                    //Url = "https://k2.denallix.com/Runtime/Runtime/View/Demo+CRM+Account+List/",
                    Type = "Heading",
                    Icon = "fa fa-cogs fa-fw",
                    MinHeight = 500
                };

                ObservableCollection<Data.WorkspaceLink> serviceapps = new ObservableCollection<Data.WorkspaceLink>();
                serviceapps.Add(customerfeedback);
                serviceapps.Add(sendmessage);
                serviceapps.Add(logaconversation);
                serviceapps.Add(taskalloc);

                linkservice.ChildLinks = serviceapps;

                ObservableCollection<Data.WorkspaceLink> headings2 = new ObservableCollection<Data.WorkspaceLink>();
                headings2.Add(link1a);
                headings2.Add(link1b);
                headings2.Add(linkservice);
                headings2.Add(chart1);
                headings2.Add(chart3);


                Data.Workspace w2 = new Data.Workspace()
                {
                    DisplayName = "Service Desks",
                    Name = "servicedesk",
                    Description = "Customer Service Desk description...",
                    SmartFormsRuntimeUrl = "https://k2.denallix.com/runtime/",
                    Links = headings2,
                    Icon = "fa fa-trophy fa-2x",
                };

                w.WorkspaceTeams = new ObservableCollection<Data.WorkspaceTeam>();
                w.WorkspaceTeams.Add(scna);
                w.WorkspaceTeams.Add(scuk);

                w1.WorkspaceTeams = new ObservableCollection<Data.WorkspaceTeam>();
                w1.WorkspaceTeams.Add(scna);
                w1.WorkspaceTeams.Add(scuk);

                w2.WorkspaceTeams = new ObservableCollection<Data.WorkspaceTeam>();
                w2.WorkspaceTeams.Add(scna);
                w2.WorkspaceTeams.Add(scuk);

                //unit.WorkspaceTeams.Add(t);
                unit.Workspaces.Add(w);
                unit.Workspaces.Add(w1);
                unit.Workspaces.Add(w2);

                int rows = unit.SaveChanges();
                MessageBox.Show("Rows: " + rows);



            }


        }

    }
}
