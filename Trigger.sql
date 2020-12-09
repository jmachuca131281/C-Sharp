create trigger delete_provider on PROVIDERS after delete as
BEGIN
declare @id int
select @id=id from deleted
END