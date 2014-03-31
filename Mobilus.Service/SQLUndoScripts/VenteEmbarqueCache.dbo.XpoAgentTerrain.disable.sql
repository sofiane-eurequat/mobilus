IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[XpoAgentTerrain]')) 
   ALTER TABLE [dbo].[XpoAgentTerrain] 
   DISABLE  CHANGE_TRACKING
GO
