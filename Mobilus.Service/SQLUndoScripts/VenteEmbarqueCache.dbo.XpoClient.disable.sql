IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[XpoClient]')) 
   ALTER TABLE [dbo].[XpoClient] 
   DISABLE  CHANGE_TRACKING
GO
