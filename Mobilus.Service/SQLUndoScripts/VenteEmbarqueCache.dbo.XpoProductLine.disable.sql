IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[XpoProductLine]')) 
   ALTER TABLE [dbo].[XpoProductLine] 
   DISABLE  CHANGE_TRACKING
GO
