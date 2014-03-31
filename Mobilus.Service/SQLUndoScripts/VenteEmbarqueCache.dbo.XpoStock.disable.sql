IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[XpoStock]')) 
   ALTER TABLE [dbo].[XpoStock] 
   DISABLE  CHANGE_TRACKING
GO
