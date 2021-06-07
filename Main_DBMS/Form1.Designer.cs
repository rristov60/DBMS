
namespace Main_DBMS
{
    partial class frmDBMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDBMS));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveChangesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.discardChangesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.regularUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regualarUSerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discardChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.table = new System.Windows.Forms.DataGridView();
            this.Filters = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Futura Bk BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.addUserToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1221, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveChangesToolStripMenuItem1,
            this.discardChangesToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(40, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // saveChangesToolStripMenuItem1
            // 
            this.saveChangesToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.saveChangesToolStripMenuItem1.Image = global::Main_DBMS.Properties.Resources.floppy_disk;
            this.saveChangesToolStripMenuItem1.Name = "saveChangesToolStripMenuItem1";
            this.saveChangesToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveChangesToolStripMenuItem1.Size = new System.Drawing.Size(235, 22);
            this.saveChangesToolStripMenuItem1.Text = "Save Changes";
            this.saveChangesToolStripMenuItem1.Click += new System.EventHandler(this.saveChangesToolStripMenuItem1_Click);
            // 
            // discardChangesToolStripMenuItem1
            // 
            this.discardChangesToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.discardChangesToolStripMenuItem1.Image = global::Main_DBMS.Properties.Resources.cancel;
            this.discardChangesToolStripMenuItem1.Name = "discardChangesToolStripMenuItem1";
            this.discardChangesToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.discardChangesToolStripMenuItem1.Size = new System.Drawing.Size(235, 22);
            this.discardChangesToolStripMenuItem1.Text = "Discard Changes";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Image = global::Main_DBMS.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.addUserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administratorToolStripMenuItem,
            this.regualarUSerToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.addUserToolStripMenuItem.Text = "Users";
            // 
            // administratorToolStripMenuItem
            // 
            this.administratorToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.administratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administratorToolStripMenuItem1,
            this.regularUserToolStripMenuItem,
            this.readOnlyToolStripMenuItem});
            this.administratorToolStripMenuItem.Image = global::Main_DBMS.Properties.Resources.add_user;
            this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            this.administratorToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.administratorToolStripMenuItem.Text = "Add User";
            // 
            // administratorToolStripMenuItem1
            // 
            this.administratorToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.administratorToolStripMenuItem1.Name = "administratorToolStripMenuItem1";
            this.administratorToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.administratorToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.administratorToolStripMenuItem1.Text = "Administrator";
            // 
            // regularUserToolStripMenuItem
            // 
            this.regularUserToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.regularUserToolStripMenuItem.Name = "regularUserToolStripMenuItem";
            this.regularUserToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.regularUserToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.regularUserToolStripMenuItem.Text = "Regular User";
            // 
            // readOnlyToolStripMenuItem
            // 
            this.readOnlyToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.readOnlyToolStripMenuItem.Name = "readOnlyToolStripMenuItem";
            this.readOnlyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.readOnlyToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.readOnlyToolStripMenuItem.Text = "Read Only";
            // 
            // regualarUSerToolStripMenuItem
            // 
            this.regualarUSerToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.regualarUSerToolStripMenuItem.Image = global::Main_DBMS.Properties.Resources.remove;
            this.regualarUSerToolStripMenuItem.Name = "regualarUSerToolStripMenuItem";
            this.regualarUSerToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.regualarUSerToolStripMenuItem.Text = "Remove User";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.changePasswordToolStripMenuItem.Image = global::Main_DBMS.Properties.Resources.exchange;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkModeToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // darkModeToolStripMenuItem
            // 
            this.darkModeToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.darkModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enabledToolStripMenuItem,
            this.disabledToolStripMenuItem});
            this.darkModeToolStripMenuItem.Image = global::Main_DBMS.Properties.Resources.night;
            this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            this.darkModeToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.darkModeToolStripMenuItem.Text = "Dark Mode";
            // 
            // enabledToolStripMenuItem
            // 
            this.enabledToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.enabledToolStripMenuItem.Name = "enabledToolStripMenuItem";
            this.enabledToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.enabledToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.enabledToolStripMenuItem.Text = "Enabled";
            // 
            // disabledToolStripMenuItem
            // 
            this.disabledToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.disabledToolStripMenuItem.Name = "disabledToolStripMenuItem";
            this.disabledToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.disabledToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.disabledToolStripMenuItem.Text = "Disabled";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.discardChangesToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.formatToolStripMenuItem.Text = "Data Base";
            // 
            // discardChangesToolStripMenuItem
            // 
            this.discardChangesToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.discardChangesToolStripMenuItem.Image = global::Main_DBMS.Properties.Resources.Table_icon;
            this.discardChangesToolStripMenuItem.Name = "discardChangesToolStripMenuItem";
            this.discardChangesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.discardChangesToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.discardChangesToolStripMenuItem.Text = "Change Table";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.userToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.applicationToolStripMenuItem.Image = global::Main_DBMS.Properties.Resources.info;
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.userToolStripMenuItem.Image = global::Main_DBMS.Properties.Resources.group;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.userToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.userToolStripMenuItem.Text = "User";
            // 
            // table
            // 
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.table.BackgroundColor = System.Drawing.Color.White;
            this.table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(12, 37);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(776, 401);
            this.table.TabIndex = 1;
            // 
            // Filters
            // 
            this.Filters.BackColor = System.Drawing.Color.White;
            this.Filters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filters.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filters.Location = new System.Drawing.Point(806, 27);
            this.Filters.Name = "Filters";
            this.Filters.Size = new System.Drawing.Size(403, 411);
            this.Filters.TabIndex = 2;
            this.Filters.TabStop = false;
            this.Filters.Text = "Filters";
            // 
            // frmDBMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1221, 450);
            this.Controls.Add(this.Filters);
            this.Controls.Add(this.table);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDBMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBMS";
            this.Load += new System.EventHandler(this.frmDBMS_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regualarUSerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem regularUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enabledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disabledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discardChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveChangesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem discardChangesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.GroupBox Filters;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

