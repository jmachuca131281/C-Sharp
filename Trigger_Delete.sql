create trigger delete_category on CATEGORYS	after delete as
BEGIN
declare @id int
select @id=id from deleted
END