use bsc31314
go
create proc InserOrd
@CustomerId int, @SalesPersonID smallint,
@OrderId int output
as
begin try
insert into dbo.OrderTbl
(CustomerID,SalesPersonID,OrderDate)
values
(@CustomerId, @SalesPersonID,GETDATE())
end try
begin catch
return error_number()
end catch
select @OrderId=SCOPE_IDENTITY()
return 0



