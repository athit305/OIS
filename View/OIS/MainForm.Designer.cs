namespace OIS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.splitContainerMain2 = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.lblDashboard = new OIS.BaseViews.rLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblMachine = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblLastLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblSpring = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblServer = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblDB = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain2)).BeginInit();
            this.splitContainerMain2.Panel1.SuspendLayout();
            this.splitContainerMain2.Panel2.SuspendLayout();
            this.splitContainerMain2.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.IsSplitterFixed = true;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.menuStrip);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerMain2);
            this.splitContainerMain.Size = new System.Drawing.Size(1184, 662);
            this.splitContainerMain.SplitterDistance = 25;
            this.splitContainerMain.SplitterWidth = 1;
            this.splitContainerMain.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // splitContainerMain2
            // 
            this.splitContainerMain2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerMain2.IsSplitterFixed = true;
            this.splitContainerMain2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain2.Name = "splitContainerMain2";
            this.splitContainerMain2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain2.Panel1
            // 
            this.splitContainerMain2.Panel1.Controls.Add(this.tabControl);
            this.splitContainerMain2.Panel1.Controls.Add(this.lblDashboard);
            // 
            // splitContainerMain2.Panel2
            // 
            this.splitContainerMain2.Panel2.Controls.Add(this.statusStrip);
            this.splitContainerMain2.Size = new System.Drawing.Size(1184, 636);
            this.splitContainerMain2.SplitterDistance = 610;
            this.splitContainerMain2.SplitterWidth = 1;
            this.splitContainerMain2.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1184, 610);
            this.tabControl.TabIndex = 0;
            this.tabControl.Visible = false;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.BackColor = System.Drawing.Color.Transparent;
            this.lblDashboard.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDashboard.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDashboard.Location = new System.Drawing.Point(3, 0);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(243, 33);
            this.lblDashboard.TabIndex = 1;
            this.lblDashboard.Text = "ERTC DashBoard";
            this.lblDashboard.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.SteelBlue;
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblUser,
            this.tsslblMachine,
            this.tsslblLastLogin,
            this.tsslblSpring,
            this.tsslblVersion,
            this.tsslblServer,
            this.tsslblDB});
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1184, 25);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tsslblUser
            // 
            this.tsslblUser.ForeColor = System.Drawing.Color.White;
            this.tsslblUser.Margin = new System.Windows.Forms.Padding(10, 3, 10, 2);
            this.tsslblUser.Name = "tsslblUser";
            this.tsslblUser.Size = new System.Drawing.Size(30, 20);
            this.tsslblUser.Text = "User";
            // 
            // tsslblMachine
            // 
            this.tsslblMachine.ForeColor = System.Drawing.Color.White;
            this.tsslblMachine.Margin = new System.Windows.Forms.Padding(10, 3, 10, 2);
            this.tsslblMachine.Name = "tsslblMachine";
            this.tsslblMachine.Size = new System.Drawing.Size(53, 20);
            this.tsslblMachine.Text = "Machine";
            // 
            // tsslblLastLogin
            // 
            this.tsslblLastLogin.ForeColor = System.Drawing.Color.White;
            this.tsslblLastLogin.Margin = new System.Windows.Forms.Padding(10, 3, 10, 2);
            this.tsslblLastLogin.Name = "tsslblLastLogin";
            this.tsslblLastLogin.Size = new System.Drawing.Size(58, 20);
            this.tsslblLastLogin.Text = "LastLogin";
            // 
            // tsslblSpring
            // 
            this.tsslblSpring.Name = "tsslblSpring";
            this.tsslblSpring.Size = new System.Drawing.Size(801, 20);
            this.tsslblSpring.Spring = true;
            // 
            // tsslblVersion
            // 
            this.tsslblVersion.ForeColor = System.Drawing.Color.White;
            this.tsslblVersion.Margin = new System.Windows.Forms.Padding(10, 3, 10, 2);
            this.tsslblVersion.Name = "tsslblVersion";
            this.tsslblVersion.Size = new System.Drawing.Size(46, 20);
            this.tsslblVersion.Text = "Version";
            // 
            // tsslblServer
            // 
            this.tsslblServer.ForeColor = System.Drawing.Color.White;
            this.tsslblServer.Margin = new System.Windows.Forms.Padding(10, 3, 10, 2);
            this.tsslblServer.Name = "tsslblServer";
            this.tsslblServer.Size = new System.Drawing.Size(39, 20);
            this.tsslblServer.Text = "Server";
            // 
            // tsslblDB
            // 
            this.tsslblDB.ForeColor = System.Drawing.Color.White;
            this.tsslblDB.Margin = new System.Windows.Forms.Padding(10, 3, 10, 2);
            this.tsslblDB.Name = "tsslblDB";
            this.tsslblDB.Size = new System.Drawing.Size(22, 20);
            this.tsslblDB.Text = "DB";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.splitContainerMain);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(600, 700);
            this.Name = "MainForm";
            this.Text = "ERTC: Office Information System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerMain2.Panel1.ResumeLayout(false);
            this.splitContainerMain2.Panel1.PerformLayout();
            this.splitContainerMain2.Panel2.ResumeLayout(false);
            this.splitContainerMain2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain2)).EndInit();
            this.splitContainerMain2.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.SplitContainer splitContainerMain2;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslblUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslblServer;
        private System.Windows.Forms.ToolStripStatusLabel tsslblMachine;
        private System.Windows.Forms.ToolStripStatusLabel tsslblDB;
        private System.Windows.Forms.TabControl tabControl;
        private BaseViews.rLabel lblDashboard;
        private System.Windows.Forms.ToolStripStatusLabel tsslblSpring;
        private System.Windows.Forms.ToolStripStatusLabel tsslblVersion;
        private System.Windows.Forms.ToolStripStatusLabel tsslblLastLogin;
    }
}