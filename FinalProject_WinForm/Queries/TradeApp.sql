--drop table UserInfo;
--drop table ItemInfo;
--drop procedure AddToCartProc;
--drop procedure UpdateRatingProc;
--drop table CartDetail;
--drop view CartView;

--Create tables
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
	ItemId uniqueidentifier default newid() primary key,
	ItemName VarChar(50),
	ItemQuantity int,
	ItemDiscription VarChar(100),
	ItemPrice int,
	ItemImage VarChar(max),
	ItemImage1 VarChar(max),
	ItemImage2 VarChar(max),
	ItemYear datetime,
	ItemQuanlity int,
	OwnerName VarChar(50) References UserInfo(UserName),
	ItemOldPrice int,
	ItemRating int,
	ItemCatagory varchar(20)
);
go



create table CartDetail(
	ItemId uniqueidentifier references ItemInfo(ItemId),
	UserName VarChar(50) references UserInfo(UserName),
	ItemQuantity int,
	Constraint PK_CartDetail primary key (ItemId, UserName),
	IsPay BIT default 0
);
go

--Procedures
create procedure UpdateRatingProc
	@ItemName VarChar(50),
	@ItemRating int
as
begin
	update ItemInfo
	set ItemRating = @ItemRating
	where ItemName = @ItemName
end;
go

create procedure AddToCartProc
	@UserName Varchar(50),
	@ItemId uniqueidentifier,
	@ItemQuantity int
as
begin
	Insert into CartDetail(ItemId, UserName, ItemQuantity) Values (@ItemId, @UserName, @ItemQuantity)
end;
go

--Views
create view CartView as
select i.ItemName, i.ItemPrice, cd.UserName, cd.ItemId, cd.ItemQuantity
from CartDetail cd
join UserInfo u on cd.UserName = u.UserName
join ItemInfo i on cd.ItemId = i.ItemId
go


--View Table
select * from UserInfo;
select * from ItemInfo;
select * from CartDetail;
select * from CartView;
