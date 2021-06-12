
namespace Main_DBMS
{
    partial class Delete_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete_user));
            this.lblDeleteUser = new System.Windows.Forms.Label();
            this.btnCancelDeleteUser = new System.Windows.Forms.Button();
            this.btnOKDeleteUser = new System.Windows.Forms.Button();
            this.comboDeleteUsers = new System.Windows.Forms.ComboBox();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.SuspendLayout();
            // 
            // lblDeleteUser
            // 
            this.lblDeleteUser.AutoSize = true;
            this.lblDeleteUser.Font = new System.Drawing.Font("Futura Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteUser.Location = new System.Drawing.Point(6, 9);
            this.lblDeleteUser.Name = "lblDeleteUser";
            this.lblDeleteUser.Size = new System.Drawing.Size(292, 22);
            this.lblDeleteUser.TabIndex = 8;
            this.lblDeleteUser.Text = "PLEASE SELECT A USER TO DELETE";
            // 
            // btnCancelDeleteUser
            // 
            this.btnCancelDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelDeleteUser.Font = new System.Drawing.Font("Futura Bk BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelDeleteUser.Location = new System.Drawing.Point(174, 177);
            this.btnCancelDeleteUser.Name = "btnCancelDeleteUser";
            this.btnCancelDeleteUser.Size = new System.Drawing.Size(99, 27);
            this.btnCancelDeleteUser.TabIndex = 7;
            this.btnCancelDeleteUser.Text = "CANCEL";
            this.btnCancelDeleteUser.UseVisualStyleBackColor = true;
            this.btnCancelDeleteUser.Click += new System.EventHandler(this.btnCancelDeleteUser_Click);
            // 
            // btnOKDeleteUser
            // 
            this.btnOKDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOKDeleteUser.Font = new System.Drawing.Font("Futura Bk BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOKDeleteUser.Location = new System.Drawing.Point(34, 177);
            this.btnOKDeleteUser.Name = "btnOKDeleteUser";
            this.btnOKDeleteUser.Size = new System.Drawing.Size(99, 27);
            this.btnOKDeleteUser.TabIndex = 6;
            this.btnOKDeleteUser.Text = "OK";
            this.btnOKDeleteUser.UseVisualStyleBackColor = true;
            this.btnOKDeleteUser.Click += new System.EventHandler(this.btnOKDeleteUser_Click);
            // 
            // comboDeleteUsers
            // 
            this.comboDeleteUsers.BackColor = System.Drawing.Color.White;
            this.comboDeleteUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboDeleteUsers.Font = new System.Drawing.Font("Futura Bk BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDeleteUsers.ForeColor = System.Drawing.Color.Black;
            this.comboDeleteUsers.FormattingEnabled = true;
            this.comboDeleteUsers.Location = new System.Drawing.Point(9, 108);
            this.comboDeleteUsers.Name = "comboDeleteUsers";
            this.comboDeleteUsers.Size = new System.Drawing.Size(292, 24);
            this.comboDeleteUsers.TabIndex = 5;
            // 
            // lineShape1
            // 
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 300;
            this.lineShape1.X2 = 7;
            this.lineShape1.Y1 = 133;
            this.lineShape1.Y2 = 133;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(307, 222);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // Delete_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(307, 222);
            this.Controls.Add(this.lblDeleteUser);
            this.Controls.Add(this.btnCancelDeleteUser);
            this.Controls.Add(this.btnOKDeleteUser);
            this.Controls.Add(this.comboDeleteUsers);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Delete_user";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeleteUser;
        private System.Windows.Forms.Button btnCancelDeleteUser;
        private System.Windows.Forms.Button btnOKDeleteUser;
        private System.Windows.Forms.ComboBox comboDeleteUsers;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
    }
}