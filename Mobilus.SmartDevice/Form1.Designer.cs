namespace Mobilus.SmartDevice
{
    partial class Form1
    {
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.miNew = new System.Windows.Forms.MenuItem();
            this.miSynchro = new System.Windows.Forms.MenuItem();
            this.inventaireDataSet = new Mobilus.SmartDevice.InventaireDataSet();
            this.xpoOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xpoOrderTableAdapter = new Mobilus.SmartDevice.InventaireDataSetTableAdapters.XpoOrderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.inventaireDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpoOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.miNew);
            this.mainMenu1.MenuItems.Add(this.miSynchro);
            // 
            // miNew
            // 
            this.miNew.Text = "New";
            this.miNew.Click += new System.EventHandler(this.newMenuItemMenuItem_Click);
            // 
            // miSynchro
            // 
            this.miSynchro.Text = "Synchronizer";
            this.miSynchro.Click += new System.EventHandler(this.miSynchro_Click);
            // 
            // inventaireDataSet
            // 
            this.inventaireDataSet.DataSetName = "InventaireDataSet";
            this.inventaireDataSet.Prefix = "";
            this.inventaireDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xpoOrderBindingSource
            // 
            this.xpoOrderBindingSource.DataMember = "XpoOrder";
            this.xpoOrderBindingSource.DataSource = this.inventaireDataSet;
            // 
            // xpoOrderTableAdapter
            // 
            this.xpoOrderTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventaireDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpoOrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private InventaireDataSet inventaireDataSet;
        private System.Windows.Forms.BindingSource xpoOrderBindingSource;
        private Mobilus.SmartDevice.InventaireDataSetTableAdapters.XpoOrderTableAdapter xpoOrderTableAdapter;
        private System.Windows.Forms.MenuItem miNew;
        private System.Windows.Forms.MenuItem miSynchro;
    }
}

