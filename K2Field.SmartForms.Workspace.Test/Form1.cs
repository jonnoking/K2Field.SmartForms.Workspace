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
                unit.WorklistUsers.Add(u);

                Data.Workspace w = new Data.Workspace() { DisplayName = "Workspace", Name = "workspace", SmartFormsRuntimeUrl = "https://k2.denallix.com/runtime/" };
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
