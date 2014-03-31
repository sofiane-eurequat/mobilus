IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[XpoMarque]')) 
   ALTER TABLE [dbo].[XpoMarque] 
   DISABLE  CHANGE_TRACKING
GO
