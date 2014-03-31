IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[XpoCategory]')) 
   ALTER TABLE [dbo].[XpoCategory] 
   DISABLE  CHANGE_TRACKING
GO
