--DECLARE @uid uniqueidentifier, @index int, @indexStr varchar(5)

--Set @index=1

--While @index<10
--Begin
--	SET @uid  = newid()
--	Set @indexStr = CONVERT(varchar(5), @index)

--	insert into [User] values (@uid,'User'+@indexStr,'Userov'+@indexStr,'Email'+@indexStr+'@Email.com')
--	insert into Account values (@uid,0,0,'password'+@indexStr,SYSDATETIME(),'Login'+@indexStr)
	
--	Set @index=@index+1
--end

select * from Account