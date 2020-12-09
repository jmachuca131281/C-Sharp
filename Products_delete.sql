create trigger delete_product on PRODUCTS after delete as
BEGIN
declare @id int
select @id=id from deleted
END