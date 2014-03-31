IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[XpoSector]')) 
   ALTER TABLE [dbo].[XpoSector] 
   DISABLE  CHANGE_TRACKING
GO
