IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[XpoProduct]')) 
   ALTER TABLE [dbo].[XpoProduct] 
   DISABLE  CHANGE_TRACKING
GO
