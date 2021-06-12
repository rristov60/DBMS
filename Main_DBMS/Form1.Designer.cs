
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
            this.removeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTableChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.table = new System.Windows.Forms.DataGridView();
            this.Filters = new System.Windows.Forms.GroupBox();
            this.btnApplyFilters = new System.Windows.Forms.Button();
            this.lblRadio = new System.Windows.Forms.Label();
            this.radioOR = new System.Windows.Forms.RadioButton();
            this.radioAnd = new System.Windows.Forms.RadioButton();
            this.txtBoxFilters = new System.Windows.Forms.TextBox();
            this.lblFilters = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.Filters.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.discardChangesToolStripMenuItem1.Click += new System.EventHandler(this.discardChangesToolStripMenuItem1_Click);
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
            this.removeUserToolStripMenuItem,
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
            this.administratorToolStripMenuItem1.Click += new System.EventHandler(this.administratorToolStripMenuItem1_Click);
            // 
            // regularUserToolStripMenuItem
            // 
            this.regularUserToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.regularUserToolStripMenuItem.Name = "regularUserToolStripMenuItem";
            this.regularUserToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.regularUserToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.regularUserToolStripMenuItem.Text = "Regular User";
            this.regularUserToolStripMenuItem.Click += new System.EventHandler(this.regularUserToolStripMenuItem_Click);
            // 
            // readOnlyToolStripMenuItem
            // 
            this.readOnlyToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.readOnlyToolStripMenuItem.Name = "readOnlyToolStripMenuItem";
            this.readOnlyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.readOnlyToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.readOnlyToolStripMenuItem.Text = "Read Only";
            this.readOnlyToolStripMenuItem.Click += new System.EventHandler(this.readOnlyToolStripMenuItem_Click);
            // 
            // removeUserToolStripMenuItem
            // 
            this.removeUserToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.removeUserToolStripMenuItem.Image = global::Main_DBMS.Properties.Resources.remove;
            this.removeUserToolStripMenuItem.Name = "removeUserToolStripMenuItem";
            this.removeUserToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.removeUserToolStripMenuItem.Text = "Remove User";
            this.removeUserToolStripMenuItem.Click += new System.EventHandler(this.removeUserToolStripMenuItem_Click);
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
            this.changeTableChangesToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.formatToolStripMenuItem.Text = "Data Base";
            // 
            // changeTableChangesToolStripMenuItem
            // 
            this.changeTableChangesToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.changeTableChangesToolStripMenuItem.Image = global::Main_DBMS.Properties.Resources.Table_icon;
            this.changeTableChangesToolStripMenuItem.Name = "changeTableChangesToolStripMenuItem";
            this.changeTableChangesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.changeTableChangesToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.changeTableChangesToolStripMenuItem.Text = "Change Table";
            this.changeTableChangesToolStripMenuItem.Click += new System.EventHandler(this.changeTableChangesToolStripMenuItem_Click);
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
            this.applicationToolStripMenuItem.Click += new System.EventHandler(this.applicationToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.userToolStripMenuItem.Image = global::Main_DBMS.Properties.Resources.group;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.userToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
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
            this.Filters.Controls.Add(this.btnApplyFilters);
            this.Filters.Controls.Add(this.lblRadio);
            this.Filters.Controls.Add(this.radioOR);
            this.Filters.Controls.Add(this.radioAnd);
            this.Filters.Controls.Add(this.txtBoxFilters);
            this.Filters.Controls.Add(this.lblFilters);
            this.Filters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filters.Font = new System.Drawing.Font("Futura Bk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filters.Location = new System.Drawing.Point(806, 27);
            this.Filters.Name = "Filters";
            this.Filters.Size = new System.Drawing.Size(403, 411);
            this.Filters.TabIndex = 2;
            this.Filters.TabStop = false;
            this.Filters.Text = "Filters";
            // 
            // btnApplyFilters
            // 
            this.btnApplyFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyFilters.Font = new System.Drawing.Font("Futura Bk BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyFilters.Location = new System.Drawing.Point(107, 363);
            this.btnApplyFilters.Name = "btnApplyFilters";
            this.btnApplyFilters.Size = new System.Drawing.Size(188, 27);
            this.btnApplyFilters.TabIndex = 8;
            this.btnApplyFilters.Text = "APPLY FILTERS";
            this.btnApplyFilters.UseVisualStyleBackColor = true;
            this.btnApplyFilters.Click += new System.EventHandler(this.btnApplyFilters_Click);
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(38, 297);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(328, 14);
            this.lblRadio.TabIndex = 22;
            this.lblRadio.Text = "Please select if you want these filters to be applied with AND or OR";
            // 
            // radioOR
            // 
            this.radioOR.AutoSize = true;
            this.radioOR.Location = new System.Drawing.Point(213, 320);
            this.radioOR.Name = "radioOR";
            this.radioOR.Size = new System.Drawing.Size(41, 18);
            this.radioOR.TabIndex = 21;
            this.radioOR.TabStop = true;
            this.radioOR.Text = "OR";
            this.radioOR.UseVisualStyleBackColor = true;
            // 
            // radioAnd
            // 
            this.radioAnd.AutoSize = true;
            this.radioAnd.Location = new System.Drawing.Point(144, 320);
            this.radioAnd.Name = "radioAnd";
            this.radioAnd.Size = new System.Drawing.Size(49, 18);
            this.radioAnd.TabIndex = 20;
            this.radioAnd.TabStop = true;
            this.radioAnd.Text = "AND";
            this.radioAnd.UseVisualStyleBackColor = true;
            // 
            // txtBoxFilters
            // 
            this.txtBoxFilters.Location = new System.Drawing.Point(9, 100);
            this.txtBoxFilters.Multiline = true;
            this.txtBoxFilters.Name = "txtBoxFilters";
            this.txtBoxFilters.Size = new System.Drawing.Size(388, 190);
            this.txtBoxFilters.TabIndex = 2;
            this.txtBoxFilters.TextChanged += new System.EventHandler(this.txtBoxFilters_TextChanged);
            // 
            // lblFilters
            // 
            this.lblFilters.AutoSize = true;
            this.lblFilters.Font = new System.Drawing.Font("Futura Bk BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilters.Location = new System.Drawing.Point(6, 23);
            this.lblFilters.Name = "lblFilters";
            this.lblFilters.Size = new System.Drawing.Size(326, 64);
            this.lblFilters.TabIndex = 0;
            this.lblFilters.Text = "Please enter the filters below in the following format:\r\n\r\nColumnName1 = DesiredV" +
    "alue1\r\nColumnName2 = DesiredValue2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Filters);
            this.panel1.Controls.Add(this.table);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 450);
            this.panel1.TabIndex = 3;
            // 
            // frmDBMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1221, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
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
            this.Filters.ResumeLayout(false);
            this.Filters.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem regularUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enabledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disabledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeTableChangesToolStripMenuItem;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.RadioButton radioOR;
        private System.Windows.Forms.RadioButton radioAnd;
        private System.Windows.Forms.TextBox txtBoxFilters;
        private System.Windows.Forms.Label lblFilters;
        private System.Windows.Forms.Button btnApplyFilters;
    }
}

