Create database ChattingWithUser
go
use ChattingWithUser
go 
create table Chat(
	Id int identity(1,1) primary key,
	Content nvarchar(max),
	UserName varchar(100),
	SentTime DateTime
);

go 
create table Users(
	UserName varchar(100) primary key,
	Password varchar(100)
);

go
ALTER TABLE Chat
ADD FOREIGN KEY (UserName) REFERENCES Users(UserName);