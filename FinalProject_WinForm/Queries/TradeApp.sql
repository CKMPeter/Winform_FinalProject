delete from UserInfo;
delete from ItemInfo;
delete from CartDetail;

drop procedure AddToCartProc;
drop procedure UpdateRatingProc;
drop table CartDetail;

drop table UserInfo;
drop table ItemInfo;
drop table CartDetail;
drop view CartView;
--Create tables
create table UserInfo(
	UserName VarChar(50) Primary Key,
	UserPassword VarChar(50) not null,
	UserAddress VarChar(50),
	UserEmail VarChar(50),
	UserImage varChar(max),
	UserGender int,
	UserRating int,
	UserVisa VarChar(50),
	UserPaypal VarChar(50)
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
	Id uniqueidentifier default newid() primary key,
	ItemId uniqueidentifier references ItemInfo(ItemId),
	UserName VarChar(50) references UserInfo(UserName),
	ItemQuantity int,
	IsPay BIT default 0,
	IsDeleted BIT default 0,
	CancelDisciption VarChar(255) default null
);
go

create table Rating(
	UserName Varchar(50) references UserInfo(UserName),
	ItemId uniqueidentifier references ItemInfo(ItemId),
	Rating int,
	UpdatedTime DateTime default Current_timestamp
);
go

create table Voucher(
	VoucherId uniqueidentifier default newid() primary key,
	ItemId uniqueidentifier references ItemInfo(ItemId),
	VoucherValue int
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

create procedure DeletedCartItemProc
	@UserName Varchar(50),
	@ItemId uniqueidentifier,
	@CancelDisciption VarChar(255)
as
begin
	Update CartDetail
	set IsDeleted = 1,
		CancelDisciption = @CancelDisciption
	where UserName = @UserName and ItemId = @ItemId;
end;
go

create procedure PayCartProc
	@UserName Varchar(50),
	@ItemId uniqueidentifier
as
begin
	Update CartDetail
	set IsPay = 1
	where UserName = @UserName and ItemId = @ItemId;
end;
go

--Views
create view CartView as
select i.ItemName, i.ItemPrice, cd.UserName, cd.ItemId, cd.ItemQuantity, cd.IsDeleted, cd.IsPay
from CartDetail cd
join UserInfo u on cd.UserName = u.UserName
join ItemInfo i on cd.ItemId = i.ItemId
go

create view VoucherView as
select i.ItemName, i.ItemPrice, v.VoucherId, v.VoucherValue
from Voucher v
join ItemInfo i on v.ItemId = i.ItemId
go

--View Table
select * from UserInfo;
select * from ItemInfo;
select * from CartDetail;
select * from CartView;
select * from Rating;
select * from Voucher;
select * from VoucherView;

