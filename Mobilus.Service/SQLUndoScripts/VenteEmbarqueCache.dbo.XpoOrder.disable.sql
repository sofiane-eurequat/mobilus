IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[XpoOrder]')) 
   ALTER TABLE [dbo].[XpoOrder] 
   DISABLE  CHANGE_TRACKING
GO
