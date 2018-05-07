using System;
using System.IO;
using System.Windows.Forms;


namespace SharedDrivePerms
{
    public partial class MainFrom : Form
    {
        //string path = @"\\hpsserv02\MSShare\LOCAL MIS DATA";


        public MainFrom()
        {
            InitializeComponent();
            dataGridView.Rows.Clear();
            dataGridView.RowHeadersVisible = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cmbBoxAccessType.SelectedIndex = 0;
           

        }

        private void btnGetPerm_Click(object sender, EventArgs e)
        {
            if (txtBoxSharedPath.Text != "" && txtBoxSharedPath != null)
            {   
                
                dataGridView.Rows.Clear();
                Evaluate(txtBoxSharedPath.Text.Trim());
            }
            else
            {
                toolStripStatusLabel.Text = "Enter shared path to be evaluated";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal async void Evaluate(string path)
        {
            GetFolderPermission perm = new GetFolderPermission(path);

            try
            {
                var perms = await perm.GetPermissionAsync();

                foreach (var item in perms)
                {

                    dataGridView.Rows.Add(item.IdentityReference, item.AccessControlType, item.FileSystemRights, item.IsInherited);
                }

            }

            catch(Exception ex)
            {
                if (ex is DirectoryNotFoundException)
                { toolStripStatusLabel.Text = ex.Message + " is not accessible"; }
                else
                { toolStripStatusLabel.Text = ex.Message; }
            }
            
                        
        }

        private void btnSetPerms_Click(object sender, EventArgs e)
        {
            

            if (txtBoxSharedPath.Text != "" && txtboxGrpName.Text != null)
            {
                if (txtboxGrpName.Text != "" && txtboxGrpName.Text != null)
                {

                   
                    try
                    {

                        SetFolderPermission newperms = new SetFolderPermission(txtboxGrpName.Text.Trim(), txtBoxSharedPath.Text.Trim(), cmbBoxAccessType.Text);
                        newperms.AddFolderPermission();
                        dataGridView.Rows.Clear();
                        Evaluate(txtBoxSharedPath.Text.Trim());
                    }
                    
                    catch (Exception ex)
                    {
                        if (ex is DirectoryNotFoundException)
                        { toolStripStatusLabel.Text = ex.Message + " is not accessible"; }
                        else
                        { toolStripStatusLabel.Text = ex.Message; }
                    }
                }
                else
                {
                    toolStripStatusLabel.Text = "Please enter group name for which permission will be applied";
                }
            }
            else
            {
                toolStripStatusLabel.Text = "Enter shared path to be evaluated";
            }
        }

        private void txtBoxSharedPath_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "";
            if(Directory.Exists(txtBoxSharedPath.Text.Trim()))
            {
                txtBoxSharedPath.BackColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                txtBoxSharedPath.BackColor = System.Drawing.Color.Orange;
            }
            if(txtBoxSharedPath.Text == "")
            {
                txtBoxSharedPath.BackColor = System.Drawing.Color.White;
            }
        }

        private void txtboxGrpName_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "";
        }

        
 
    }
}
