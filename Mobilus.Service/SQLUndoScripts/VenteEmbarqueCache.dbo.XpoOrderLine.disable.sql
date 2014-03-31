IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[XpoOrderLine]')) 
   ALTER TABLE [dbo].[XpoOrderLine] 
   DISABLE  CHANGE_TRACKING
GO
