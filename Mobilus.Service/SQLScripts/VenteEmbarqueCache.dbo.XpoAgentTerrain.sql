IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[XpoAgentTerrain]')) 
   ALTER TABLE [dbo].[XpoAgentTerrain] 
   ENABLE  CHANGE_TRACKING
GO
