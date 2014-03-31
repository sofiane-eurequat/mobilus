namespace Mobilus.SmartDevice
{
    partial class XpoOrderSummaryViewDialog
    {
        public void AttachVisibilityBindings(ControlCollection controls)
        {
            for (int i = 0; (i < controls.Count); i = (i + 1))
            {
                if ((controls[i].DataBindings["Visible"] != null))
                {
                    // Attach event handlers to auto-hide controls.
                    controls[i].DataBindings["Visible"].Format += new System.Windows.Forms.ConvertEventHandler(this.Visibility_Format);
                    controls[i].DataBindings["Visible"].DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
                }
            }

        }
    
        public void Visibility_Format(object sender, System.Windows.Forms.ConvertEventArgs e)
        {
            if ((e.Value == System.DBNull.Value))
            {
                e.Value = false;
            }
            else
            {
                e.Value = true;
            }

        }
    
        public static XpoOrderSummaryViewDialog Instance(System.Windows.Forms.BindingSource bindingSource)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            if ((defaultInstance == null))
            {
                defaultInstance = new Mobilus.SmartDevice.XpoOrderSummaryViewDialog();
                defaultInstance.xpoOrderBindingSource.DataSource = bindingSource;
            }
            defaultInstance.AutoScrollPosition = new System.Drawing.Point(0, 0);
            defaultInstance.xpoOrderBindingSource.Position = bindingSource.Position;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            return defaultInstance;
        }
    
        private static XpoOrderSummaryViewDialog defaultInstance;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label oidLabel;
            System.Windows.Forms.Label clientLabel;
            System.Windows.Forms.Label prioriteLabel;
            System.Windows.Forms.Label optimisticLockFieldLabel;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.editMenuItemMenuItem = new System.Windows.Forms.MenuItem();
            this.xpoOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oidLabel1 = new System.Windows.Forms.Label();
            this.clientLabel1 = new System.Windows.Forms.Label();
            this.prioriteLabel1 = new System.Windows.Forms.Label();
            this.optimisticLockFieldLabel1 = new System.Windows.Forms.Label();
            this.topBorderPanel = new System.Windows.Forms.Panel();
            this.leftBorderPanel = new System.Windows.Forms.Panel();
            this.rightBorderPanel = new System.Windows.Forms.Panel();
            oidLabel = new System.Windows.Forms.Label();
            clientLabel = new System.Windows.Forms.Label();
            prioriteLabel = new System.Windows.Forms.Label();
            optimisticLockFieldLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xpoOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.editMenuItemMenuItem);
            // 
            // editMenuItemMenuItem
            // 
            this.editMenuItemMenuItem.Text = "Edit";
            this.editMenuItemMenuItem.Click += new System.EventHandler(this.editMenuItemMenuItem_Click);
            // 
            // xpoOrderBindingSource
            // 
            this.xpoOrderBindingSource.DataMember = "XpoOrder";
            this.xpoOrderBindingSource.DataSource = typeof(Mobilus.SmartDevice.InventaireDataSet);
            // 
            // oidLabel
            // 
            oidLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.xpoOrderBindingSource, "Oid", true));
            oidLabel.Dock = System.Windows.Forms.DockStyle.Top;
            oidLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            oidLabel.Location = new System.Drawing.Point(4, 4);
            oidLabel.Name = "oidLabel";
            oidLabel.Size = new System.Drawing.Size(31, 21);
            oidLabel.Text = "Oid:";
            // 
            // oidLabel1
            // 
            this.oidLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xpoOrderBindingSource, "Oid", true));
            this.oidLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.xpoOrderBindingSource, "Oid", true));
            this.oidLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.oidLabel1.Location = new System.Drawing.Point(4, 18);
            this.oidLabel1.Name = "oidLabel1";
            this.oidLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // clientLabel
            // 
            clientLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.xpoOrderBindingSource, "Client", true));
            clientLabel.Dock = System.Windows.Forms.DockStyle.Top;
            clientLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            clientLabel.Location = new System.Drawing.Point(4, 49);
            clientLabel.Name = "clientLabel";
            clientLabel.Size = new System.Drawing.Size(46, 21);
            clientLabel.Text = "Client:";
            // 
            // clientLabel1
            // 
            this.clientLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xpoOrderBindingSource, "Client", true));
            this.clientLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.xpoOrderBindingSource, "Client", true));
            this.clientLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientLabel1.Location = new System.Drawing.Point(4, 63);
            this.clientLabel1.Name = "clientLabel1";
            this.clientLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // prioriteLabel
            // 
            prioriteLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.xpoOrderBindingSource, "Priorite", true));
            prioriteLabel.Dock = System.Windows.Forms.DockStyle.Top;
            prioriteLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            prioriteLabel.Location = new System.Drawing.Point(4, 94);
            prioriteLabel.Name = "prioriteLabel";
            prioriteLabel.Size = new System.Drawing.Size(56, 21);
            prioriteLabel.Text = "Priorite:";
            // 
            // prioriteLabel1
            // 
            this.prioriteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xpoOrderBindingSource, "Priorite", true));
            this.prioriteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.xpoOrderBindingSource, "Priorite", true));
            this.prioriteLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.prioriteLabel1.Location = new System.Drawing.Point(4, 108);
            this.prioriteLabel1.Name = "prioriteLabel1";
            this.prioriteLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // optimisticLockFieldLabel
            // 
            optimisticLockFieldLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.xpoOrderBindingSource, "OptimisticLockField", true));
            optimisticLockFieldLabel.Dock = System.Windows.Forms.DockStyle.Top;
            optimisticLockFieldLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            optimisticLockFieldLabel.Location = new System.Drawing.Point(4, 139);
            optimisticLockFieldLabel.Name = "optimisticLockFieldLabel";
            optimisticLockFieldLabel.Size = new System.Drawing.Size(135, 21);
            optimisticLockFieldLabel.Text = "Optimistic Lock Field:";
            // 
            // optimisticLockFieldLabel1
            // 
            this.optimisticLockFieldLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xpoOrderBindingSource, "OptimisticLockField", true));
            this.optimisticLockFieldLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.xpoOrderBindingSource, "OptimisticLockField", true));
            this.optimisticLockFieldLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.optimisticLockFieldLabel1.Location = new System.Drawing.Point(4, 153);
            this.optimisticLockFieldLabel1.Name = "optimisticLockFieldLabel1";
            this.optimisticLockFieldLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // topBorderPanel
            // 
            this.topBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.topBorderPanel.Name = "topBorderPanel";
            this.topBorderPanel.Size = new System.Drawing.Size(100, 2);
            // 
            // leftBorderPanel
            // 
            this.leftBorderPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.leftBorderPanel.Name = "leftBorderPanel";
            this.leftBorderPanel.Size = new System.Drawing.Size(4, 100);
            // 
            // rightBorderPanel
            // 
            this.rightBorderPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.rightBorderPanel.Name = "rightBorderPanel";
            this.rightBorderPanel.Size = new System.Drawing.Size(4, 100);
            // 
            // XpoOrderSummaryViewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.optimisticLockFieldLabel1);
            this.Controls.Add(optimisticLockFieldLabel);
            this.Controls.Add(this.prioriteLabel1);
            this.Controls.Add(prioriteLabel);
            this.Controls.Add(this.clientLabel1);
            this.Controls.Add(clientLabel);
            this.Controls.Add(this.oidLabel1);
            this.Controls.Add(oidLabel);
            this.Controls.Add(this.topBorderPanel);
            this.Controls.Add(this.leftBorderPanel);
            this.Controls.Add(this.rightBorderPanel);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "XpoOrderSummaryViewDialog";
            this.Text = "XpoOrderSummaryViewDialog";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.XpoOrderSummaryViewDialog_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.xpoOrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem editMenuItemMenuItem;
        private System.Windows.Forms.BindingSource xpoOrderBindingSource;
        private System.Windows.Forms.Label oidLabel1;
        private System.Windows.Forms.Label clientLabel1;
        private System.Windows.Forms.Label prioriteLabel1;
        private System.Windows.Forms.Label optimisticLockFieldLabel1;
        private System.Windows.Forms.Panel topBorderPanel;
        private System.Windows.Forms.Panel leftBorderPanel;
        private System.Windows.Forms.Panel rightBorderPanel;
    }
}