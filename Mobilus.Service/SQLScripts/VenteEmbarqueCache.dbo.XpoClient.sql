IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[XpoClient]')) 
   ALTER TABLE [dbo].[XpoClient] 
   ENABLE  CHANGE_TRACKING
GO
