--insert into [dbo].[Role] values (newid(),'Superadmin')
--insert into [Role] values (newid(),'Admin')
--insert into [Role] values (newid(),'Student')
--insert into [Role] values (newid(),'Teacher')

--insert into GroupStud values (newid(),'САПР-21','2013')

--DECLARE @uid uniqueidentifier,  @index int, @indexStr varchar(5)
--Set @index=1
--While @index<3
--Begin
--	SET @uid  = newid()
--	Set @indexStr = CONVERT(varchar(5), @index)

--	insert into [User] values (@uid,'User'+@indexStr,'Userovich'+@indexStr,'Email'+@indexStr+'@Email.com','Userov'+@indexStr)
--	insert into Account values (@uid,0,0,'password'+@indexStr,SYSDATETIME(),'Login'+@indexStr)
--	insert into UserInRole select [Role].ID as [Role_ID], @uid as [User_ID] from [Role] where [Role].Name='Admin'
--	Set @index=@index+1
--end




--While @index<100
--Begin
--	SET @uid  = newid()
--	Set @indexStr = CONVERT(varchar(5), @index)

--	insert into [User] values (@uid,'User'+@indexStr,'Userovich'+@indexStr,'Email'+@indexStr+'@Email.com','Userov'+@indexStr)
--	insert into Account values (@uid,0,0,'password'+@indexStr,SYSDATETIME(),'Login'+@indexStr)
--	insert into Teacher values (@uid,'ассистент'+@indexStr,'1')
--	insert into UserInRole select [Role].ID as [Role_ID], @uid as [User_ID] from [Role] where [Role].Name='Teacher'
--	Set @index=@index+1
--end

--While @index<1000
--Begin
--	SET @uid  = newid()
--	Set @indexStr = CONVERT(varchar(5), @index)

--	insert into [User] values (@uid,'User'+@indexStr,'Userovich'+@indexStr,'Email'+@indexStr+'@Email.com','Userov'+@indexStr)
--	insert into Account values (@uid,0,0,'password'+@indexStr,SYSDATETIME(),'Login'+@indexStr)
--	insert into Student select @uid as ID_User, [GroupStud].ID as ID_GroupStud from GroupStud where GroupStud.Name='САПР-21'
--	insert into UserInRole select [Role].ID as [Role_ID], @uid as [User_ID] from [Role] where [Role].Name='Student'
--	Set @index=@index+1
--end
select * from Teacher
--delete from Account
--delete from UserInRole
--delete from Role
--delete from Student
--delete from Teacher
--delete from GroupStud
--delete from [User]