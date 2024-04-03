drop table UserInfo;
drop table ItemInfo;

create table UserInfo(
	UserName VarChar(50) Primary Key,
	UserPassword VarChar(50) not null,
	UserAddress VarChar(50),
	UserEmail VarChar(50),
	UserImage varChar(max),
	UserGender int,
	UserRating int 
);
go

create table ItemInfo(
	ItemName VarChar(50),
	ItemQuantity int,
	ItemDiscription VarChar(100),
	ItemPrice int,
	ItemImage VarChar(max),
	ItemImage1 VarChar(max),
	ItemImage2 VarChar(max),
	ItemYear int,
	ItemQuanlity int,
	UserName VarChar(50) References UserInfo(UserName),
	ItemOldPrice int,
	ItemRating int,
	Primary Key (ItemName, UserName)
);
go

create procedure UpdateRating
	@ItemName VarChar(50),
	@ItemRating int
as
begin
	update ItemInfo
	set ItemRating = @ItemRating
	where ItemName = @ItemName
end;
go

select * from UserInfo;
select * from ItemInfo;

--delete from ItemInfo where ItemName = '1234';