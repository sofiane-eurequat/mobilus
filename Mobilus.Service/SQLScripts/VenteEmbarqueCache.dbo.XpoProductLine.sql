IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[XpoProductLine]')) 
   ALTER TABLE [dbo].[XpoProductLine] 
   ENABLE  CHANGE_TRACKING
GO
