using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mobilus.SmartDevice.VenteEmbarqueCacheWebRef;

namespace Mobilus.SmartDevice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (InventaireDataSetUtil.DesignerUtil.IsRunTime())
            {
                // TODO: Delete this line of code to remove the default AutoFill for 'inventaireDataSet.XpoOrder'.
                this.xpoOrderTableAdapter.Fill(this.inventaireDataSet.XpoOrder);
            }

        }

        private void newMenuItemMenuItem_Click(object sender, EventArgs e)
        {
            xpoOrderBindingSource.AddNew();
            Mobilus.SmartDevice.XpoOrderEditViewDialog xpoorderEditViewDialog = Mobilus.SmartDevice.XpoOrderEditViewDialog.Instance(this.xpoOrderBindingSource);
            xpoorderEditViewDialog.ShowDialog();

        }

        private void xpoOrderDataGrid_Click(object sender, EventArgs e)
        {
            Mobilus.SmartDevice.XpoOrderSummaryViewDialog xpoorderSummaryViewDialog = Mobilus.SmartDevice.XpoOrderSummaryViewDialog.Instance(this.xpoOrderBindingSource);
            xpoorderSummaryViewDialog.ShowDialog();

        }

        private void miSynchro_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var webSvcProxy = new  VenteEmbarqueCacheSyncService();
            var serverProvider = new Microsoft.Synchronization.Data.ServerSyncProviderProxy(webSvcProxy);


            var syncAgent = new VenteEmbarqueCacheSyncAgent();
            syncAgent.RemoteProvider = serverProvider;
            syncAgent.XpoOrder.SyncDirection = Microsoft.Synchronization.Data.SyncDirection.Bidirectional;
            syncAgent.XpoOrderLine.SyncDirection = Microsoft.Synchronization.Data.SyncDirection.Bidirectional;


            Microsoft.Synchronization.Data.SyncStatistics stats = syncAgent.Synchronize();

            xpoOrderTableAdapter.Fill(inventaireDataSet.XpoOrder);


            MessageBox.Show("Changement telechargé : " + stats.TotalChangesDownloaded.ToString() +"\r\n" + "Changement uploadé: " + stats.TotalChangesUploaded.ToString());

            Cursor.Current = Cursors.Default;
        }
    }
}