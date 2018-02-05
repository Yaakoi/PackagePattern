namespace Interface_Nicolas
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
            this.pluginViewCtrl = new Pic.Plugin.ViewCtrl.PluginViewCtrl();
            this.listView = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.spécialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spécialToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.propriétésToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.propriétésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.symetrieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.symetrieXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.symetrieYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pluginViewCtrl)).BeginInit();
            this.pluginViewCtrl.Panel1.SuspendLayout();
            this.pluginViewCtrl.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pluginViewCtrl
            // 
            this.pluginViewCtrl.CloseButtonVisible = false;
            this.pluginViewCtrl.Component = null;
            this.pluginViewCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pluginViewCtrl.HasDependancies = false;
            this.pluginViewCtrl.Localizer = null;
            this.pluginViewCtrl.Location = new System.Drawing.Point(0, 0);
            this.pluginViewCtrl.Name = "pluginViewCtrl";
            // 
            // pluginViewCtrl.Panel1
            // 
            this.pluginViewCtrl.Panel1.Controls.Add(this.listView);
            this.pluginViewCtrl.Panel1.Controls.Add(this.menuStrip1);
            // 
            // pluginViewCtrl.Panel2
            // 
            this.pluginViewCtrl.Panel2.AutoScroll = true;
            this.pluginViewCtrl.ParamValues = null;
            this.pluginViewCtrl.ReflectionX = false;
            this.pluginViewCtrl.ReflectionY = false;
            this.pluginViewCtrl.ShowAxes = true;
            this.pluginViewCtrl.ShowCotationsAuto = true;
            this.pluginViewCtrl.ShowCotationsCode = false;
            this.pluginViewCtrl.ShowSummary = true;
            this.pluginViewCtrl.Size = new System.Drawing.Size(1300, 700);
            this.pluginViewCtrl.SplitterDistance = 1050;
            this.pluginViewCtrl.SplitterWidth = 1;
            this.pluginViewCtrl.TabIndex = 0;
            this.pluginViewCtrl.ValidateButtonVisible = false;
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(12, 49);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(232, 229);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.OnSelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spécialToolStripMenuItem,
            this.spécialToolStripMenuItem1,
            this.symetrieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1050, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // spécialToolStripMenuItem
            // 
            this.spécialToolStripMenuItem.Name = "spécialToolStripMenuItem";
            this.spécialToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // spécialToolStripMenuItem1
            // 
            this.spécialToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propriétésToolStripMenuItem1});
            this.spécialToolStripMenuItem1.Name = "spécialToolStripMenuItem1";
            this.spécialToolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.spécialToolStripMenuItem1.Text = "Spécial";
            // 
            // propriétésToolStripMenuItem1
            // 
            this.propriétésToolStripMenuItem1.Name = "propriétésToolStripMenuItem1";
            this.propriétésToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.propriétésToolStripMenuItem1.Text = "Propriétés";
            this.propriétésToolStripMenuItem1.Click += new System.EventHandler(this.propriétésToolStripMenuItem1_Click);
            // 
            // propriétésToolStripMenuItem
            // 
            this.propriétésToolStripMenuItem.Name = "propriétésToolStripMenuItem";
            this.propriétésToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.propriétésToolStripMenuItem.Text = "Propriétés";
            // 
            // symetrieToolStripMenuItem
            // 
            this.symetrieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.symetrieXToolStripMenuItem,
            this.symetrieYToolStripMenuItem});
            this.symetrieToolStripMenuItem.Name = "symetrieToolStripMenuItem";
            this.symetrieToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.symetrieToolStripMenuItem.Text = "Symetrie";
            // 
            // symetrieXToolStripMenuItem
            // 
            this.symetrieXToolStripMenuItem.Name = "symetrieXToolStripMenuItem";
            this.symetrieXToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.symetrieXToolStripMenuItem.Text = "Symetrie X";
            this.symetrieXToolStripMenuItem.Click += new System.EventHandler(this.symetrieXToolStripMenuItem_Click);
            // 
            // symetrieYToolStripMenuItem
            // 
            this.symetrieYToolStripMenuItem.Name = "symetrieYToolStripMenuItem";
            this.symetrieYToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.symetrieYToolStripMenuItem.Text = "Symetrie Y";
            this.symetrieYToolStripMenuItem.Click += new System.EventHandler(this.symetrieYToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.pluginViewCtrl);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Interface";
            this.pluginViewCtrl.Panel1.ResumeLayout(false);
            this.pluginViewCtrl.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pluginViewCtrl)).EndInit();
            this.pluginViewCtrl.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private Pic.Plugin.ViewCtrl.PluginViewCtrl pluginViewCtrl;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem spécialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propriétésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spécialToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem propriétésToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem symetrieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem symetrieXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem symetrieYToolStripMenuItem;
    }
}