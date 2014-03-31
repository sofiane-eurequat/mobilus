namespace Mobilus.SmartDevice
{
    partial class XpoOrderEditViewDialog
    {
        public static XpoOrderEditViewDialog Instance(System.Windows.Forms.BindingSource bindingSource)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            if ((defaultInstance == null))
            {
                defaultInstance = new Mobilus.SmartDevice.XpoOrderEditViewDialog();
                defaultInstance.xpoOrderBindingSource.DataSource = bindingSource;
            }
            defaultInstance.oidTextBox.Focus();
            defaultInstance.AutoScrollPosition = new System.Drawing.Point(0, 0);
            defaultInstance.xpoOrderBindingSource.Position = bindingSource.Position;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            return defaultInstance;
        }
    
        private static XpoOrderEditViewDialog defaultInstance;
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
            this.xpoOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oidTextBox = new System.Windows.Forms.TextBox();
            this.clientTextBox = new System.Windows.Forms.TextBox();
            this.prioriteTextBox = new System.Windows.Forms.TextBox();
            this.optimisticLockFieldTextBox = new System.Windows.Forms.TextBox();
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
            // xpoOrderBindingSource
            // 
            this.xpoOrderBindingSource.DataMember = "XpoOrder";
            this.xpoOrderBindingSource.DataSource = typeof(Mobilus.SmartDevice.InventaireDataSet);
            // 
            // oidLabel
            // 
            oidLabel.Dock = System.Windows.Forms.DockStyle.Top;
            oidLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            oidLabel.Location = new System.Drawing.Point(4, 4);
            oidLabel.Name = "oidLabel";
            oidLabel.Size = new System.Drawing.Size(31, 21);
            oidLabel.Text = "Oid:";
            // 
            // oidTextBox
            // 
            this.oidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xpoOrderBindingSource, "Oid", true));
            this.oidTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.oidTextBox.Location = new System.Drawing.Point(4, 18);
            this.oidTextBox.Name = "oidTextBox";
            this.oidTextBox.Size = new System.Drawing.Size(100, 21);
            this.oidTextBox.TabIndex = 1;
            // 
            // clientLabel
            // 
            clientLabel.Dock = System.Windows.Forms.DockStyle.Top;
            clientLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            clientLabel.Location = new System.Drawing.Point(4, 50);
            clientLabel.Name = "clientLabel";
            clientLabel.Size = new System.Drawing.Size(46, 21);
            clientLabel.Text = "Client:";
            // 
            // clientTextBox
            // 
            this.clientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xpoOrderBindingSource, "Client", true));
            this.clientTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientTextBox.Location = new System.Drawing.Point(4, 64);
            this.clientTextBox.Name = "clientTextBox";
            this.clientTextBox.Size = new System.Drawing.Size(100, 21);
            this.clientTextBox.TabIndex = 3;
            // 
            // prioriteLabel
            // 
            prioriteLabel.Dock = System.Windows.Forms.DockStyle.Top;
            prioriteLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            prioriteLabel.Location = new System.Drawing.Point(4, 96);
            prioriteLabel.Name = "prioriteLabel";
            prioriteLabel.Size = new System.Drawing.Size(56, 21);
            prioriteLabel.Text = "Priorite:";
            // 
            // prioriteTextBox
            // 
            this.prioriteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xpoOrderBindingSource, "Priorite", true));
            this.prioriteTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.prioriteTextBox.Location = new System.Drawing.Point(4, 110);
            this.prioriteTextBox.Name = "prioriteTextBox";
            this.prioriteTextBox.Size = new System.Drawing.Size(100, 21);
            this.prioriteTextBox.TabIndex = 5;
            // 
            // optimisticLockFieldLabel
            // 
            optimisticLockFieldLabel.Dock = System.Windows.Forms.DockStyle.Top;
            optimisticLockFieldLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            optimisticLockFieldLabel.Location = new System.Drawing.Point(4, 142);
            optimisticLockFieldLabel.Name = "optimisticLockFieldLabel";
            optimisticLockFieldLabel.Size = new System.Drawing.Size(135, 21);
            optimisticLockFieldLabel.Text = "Optimistic Lock Field:";
            // 
            // optimisticLockFieldTextBox
            // 
            this.optimisticLockFieldTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xpoOrderBindingSource, "OptimisticLockField", true));
            this.optimisticLockFieldTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.optimisticLockFieldTextBox.Location = new System.Drawing.Point(4, 156);
            this.optimisticLockFieldTextBox.Name = "optimisticLockFieldTextBox";
            this.optimisticLockFieldTextBox.Size = new System.Drawing.Size(100, 21);
            this.optimisticLockFieldTextBox.TabIndex = 7;
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
            // XpoOrderEditViewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.optimisticLockFieldTextBox);
            this.Controls.Add(optimisticLockFieldLabel);
            this.Controls.Add(this.prioriteTextBox);
            this.Controls.Add(prioriteLabel);
            this.Controls.Add(this.clientTextBox);
            this.Controls.Add(clientLabel);
            this.Controls.Add(this.oidTextBox);
            this.Controls.Add(oidLabel);
            this.Controls.Add(this.topBorderPanel);
            this.Controls.Add(this.leftBorderPanel);
            this.Controls.Add(this.rightBorderPanel);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "XpoOrderEditViewDialog";
            this.Text = "XpoOrderEditViewDialog";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.XpoOrderEditViewDialog_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.xpoOrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource xpoOrderBindingSource;
        private System.Windows.Forms.TextBox oidTextBox;
        private System.Windows.Forms.TextBox clientTextBox;
        private System.Windows.Forms.TextBox prioriteTextBox;
        private System.Windows.Forms.TextBox optimisticLockFieldTextBox;
        private System.Windows.Forms.Panel topBorderPanel;
        private System.Windows.Forms.Panel leftBorderPanel;
        private System.Windows.Forms.Panel rightBorderPanel;
    }
}