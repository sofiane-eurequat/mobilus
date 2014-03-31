// 
// <Instructions>
// 
// The class VenteEmbarqueCacheSyncService is a WCF Service that implements the IVenteEmbarqueCacheSyncContract interface.
// This interface must be implemented by any web service that needs to participate in data synchronization.
// 
// *** TODO: ***
// To expose this service as an endpoint add the following to the services section of the app.config file
// 
//       <service name="Mobilus.Service.VenteEmbarqueCacheSyncService" behaviorConfiguration="Mobilus.Service.VenteEmbarqueCacheSyncServiceBehavior">
//         <host>
//           <baseAddresses>
//             <add baseAddress ="http://localhost:8080/VenteEmbarqueCacheSyncService/"/>
//           </baseAddresses>
//         </host>
//         <endpoint address ="" binding="wsHttpBinding" contract="Mobilus.Service.IVenteEmbarqueCacheSyncContract"/>
//         <endpoint address="mex" binding="mexHttpBinding" contract="IMetadataExchange" />
//       </service>
// 
// and the following to the serviceBehaviors section
// 
//        <behavior name="Mobilus.Service.VenteEmbarqueCacheSyncServiceBehavior">
//          <serviceMetadata httpGetEnabled="True" />
//          <serviceDebug includeExceptionDetailInFaults="False" />
//        </behavior>
// 
// </Instructions>
// 
namespace Mobilus.Service {
    using System;
    using System.Data;
    using System.Collections.ObjectModel;
    using System.ServiceModel;
    using Microsoft.Synchronization.Data;
    
    
    public partial class VenteEmbarqueCacheSyncService : object, IVenteEmbarqueCacheSyncContract {
        
        private VenteEmbarqueCacheServerSyncProvider _serverSyncProvider;
        
        public VenteEmbarqueCacheSyncService() {
            this._serverSyncProvider = new VenteEmbarqueCacheServerSyncProvider();
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public virtual SyncContext ApplyChanges(SyncGroupMetadata groupMetadata, DataSet dataSet, SyncSession syncSession) {
            return this._serverSyncProvider.ApplyChanges(groupMetadata, dataSet, syncSession);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public virtual SyncContext GetChanges(SyncGroupMetadata groupMetadata, SyncSession syncSession) {
            return this._serverSyncProvider.GetChanges(groupMetadata, syncSession);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public virtual SyncSchema GetSchema(Collection<string> tableNames, SyncSession syncSession) {
            return this._serverSyncProvider.GetSchema(tableNames, syncSession);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public virtual SyncServerInfo GetServerInfo(SyncSession syncSession) {
            return this._serverSyncProvider.GetServerInfo(syncSession);
        }
    }

    [ServiceContractAttribute(), XmlSerializerFormat()]
    public interface IVenteEmbarqueCacheSyncContract {
        
        [OperationContract()]
        SyncContext ApplyChanges(SyncGroupMetadata groupMetadata, DataSet dataSet, SyncSession syncSession);
        
        [OperationContract()]
        SyncContext GetChanges(SyncGroupMetadata groupMetadata, SyncSession syncSession);
        
        [OperationContract()]
        SyncSchema GetSchema(Collection<string> tableNames, SyncSession syncSession);
        
        [OperationContract()]
        SyncServerInfo GetServerInfo(SyncSession syncSession);
    }
}
