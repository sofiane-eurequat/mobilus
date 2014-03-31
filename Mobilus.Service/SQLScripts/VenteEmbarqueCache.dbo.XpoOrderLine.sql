IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[XpoOrderLine]')) 
   ALTER TABLE [dbo].[XpoOrderLine] 
   ENABLE  CHANGE_TRACKING
GO
