IF NOT EXISTS (SELECT * FROM sys.change_tracking_databases WHERE database_id = DB_ID(N'Inventaire')) 
   ALTER DATABASE [Inventaire] 
   SET  CHANGE_TRACKING = ON
GO
