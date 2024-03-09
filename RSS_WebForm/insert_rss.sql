CREATE PROCEDURE sp_insert_rss @title nvarchar(max),@summery nvarchar(max)
AS
INSERT INTO [RSS_DB].[dbo].[RSS_TB] VALUES (@title, @summery)
GO;

EXEC sp_insert_rss @title = '2',@summery ='test';
