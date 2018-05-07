namespace SharedDrivePerms
{
    partial class MainFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGetPerm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtboxGrpName = new System.Windows.Forms.TextBox();
            this.cmbBoxAccessType = new System.Windows.Forms.ComboBox();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.lblAccessType = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSetPerms = new System.Windows.Forms.Button();
            this.lblSharedDrive = new System.Windows.Forms.Label();
            this.txtBoxSharedPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView.Location = new System.Drawing.Point(12, 101);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 30;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.Size = new System.Drawing.Size(574, 196);
            this.dataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IdentityReference";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "AccessControlType";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "FileSystemRights";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Is Inherited";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnGetPerm
            // 
            this.btnGetPerm.Location = new System.Drawing.Point(426, 303);
            this.btnGetPerm.Name = "btnGetPerm";
            this.btnGetPerm.Size = new System.Drawing.Size(95, 23);
            this.btnGetPerm.TabIndex = 1;
            this.btnGetPerm.Text = "Fetch Permission";
            this.btnGetPerm.UseVisualStyleBackColor = true;
            this.btnGetPerm.Click += new System.EventHandler(this.btnGetPerm_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(527, 303);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtboxGrpName
            // 
            this.txtboxGrpName.Location = new System.Drawing.Point(85, 36);
            this.txtboxGrpName.Name = "txtboxGrpName";
            this.txtboxGrpName.Size = new System.Drawing.Size(275, 20);
            this.txtboxGrpName.TabIndex = 3;
            this.txtboxGrpName.TextChanged += new System.EventHandler(this.txtboxGrpName_TextChanged);
            // 
            // cmbBoxAccessType
            // 
            this.cmbBoxAccessType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxAccessType.FormattingEnabled = true;
            this.cmbBoxAccessType.Items.AddRange(new object[] {
            "Read Only",
            "Modify"});
            this.cmbBoxAccessType.Location = new System.Drawing.Point(85, 63);
            this.cmbBoxAccessType.Name = "cmbBoxAccessType";
            this.cmbBoxAccessType.Size = new System.Drawing.Size(79, 21);
            this.cmbBoxAccessType.TabIndex = 4;
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Location = new System.Drawing.Point(12, 37);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(67, 13);
            this.lblGroupName.TabIndex = 5;
            this.lblGroupName.Text = "Group Name";
            // 
            // lblAccessType
            // 
            this.lblAccessType.AutoSize = true;
            this.lblAccessType.Location = new System.Drawing.Point(12, 66);
            this.lblAccessType.Name = "lblAccessType";
            this.lblAccessType.Size = new System.Drawing.Size(69, 13);
            this.lblAccessType.TabIndex = 6;
            this.lblAccessType.Text = "Access Type";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 340);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(598, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // btnSetPerms
            // 
            this.btnSetPerms.Location = new System.Drawing.Point(325, 303);
            this.btnSetPerms.Name = "btnSetPerms";
            this.btnSetPerms.Size = new System.Drawing.Size(95, 23);
            this.btnSetPerms.TabIndex = 8;
            this.btnSetPerms.Text = "Set Permission";
            this.btnSetPerms.UseVisualStyleBackColor = true;
            this.btnSetPerms.Click += new System.EventHandler(this.btnSetPerms_Click);
            // 
            // lblSharedDrive
            // 
            this.lblSharedDrive.AutoSize = true;
            this.lblSharedDrive.Location = new System.Drawing.Point(12, 11);
            this.lblSharedDrive.Name = "lblSharedDrive";
            this.lblSharedDrive.Size = new System.Drawing.Size(66, 13);
            this.lblSharedDrive.TabIndex = 10;
            this.lblSharedDrive.Text = "Shared Path";
            // 
            // txtBoxSharedPath
            // 
            this.txtBoxSharedPath.Location = new System.Drawing.Point(85, 10);
            this.txtBoxSharedPath.Name = "txtBoxSharedPath";
            this.txtBoxSharedPath.Size = new System.Drawing.Size(275, 20);
            this.txtBoxSharedPath.TabIndex = 9;
            this.txtBoxSharedPath.TextChanged += new System.EventHandler(this.txtBoxSharedPath_TextChanged);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 362);
            this.Controls.Add(this.lblSharedDrive);
            this.Controls.Add(this.txtBoxSharedPath);
            this.Controls.Add(this.btnSetPerms);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblAccessType);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.cmbBoxAccessType);
            this.Controls.Add(this.txtboxGrpName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGetPerm);
            this.Controls.Add(this.dataGridView);
            this.MaximizeBox = false;
            this.Name = "MainFrom";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnGetPerm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txtboxGrpName;
        private System.Windows.Forms.ComboBox cmbBoxAccessType;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.Label lblAccessType;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Button btnSetPerms;
        private System.Windows.Forms.Label lblSharedDrive;
        private System.Windows.Forms.TextBox txtBoxSharedPath;
    }
}

