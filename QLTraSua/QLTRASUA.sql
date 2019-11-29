CREATE DATABASE QUANLYTS
GO

USE QUANLYTS
GO


CREATE TABLE TABLE_DRINK(
	ID_TABLE INT IDENTITY PRIMARY KEY,
	NAME_TABLE NVARCHAR(100) NOT NULL,
	STATUS NVARCHAR(100) NOT NULL DEFAULT N'Trống'			-- 0 : TRỐNG - 1: CÓ NGƯỜI
)
GO

CREATE TABLE USERS (
	USERNAME NVARCHAR(100) PRIMARY KEY,
	PASSWORD NVARCHAR(100) NOT NULL,
	PERMISSION INT NOT NULL,				-- 0 : NHÂN VIÊN - 1 : QUẢN LÍ
	NAME_USER NVARCHAR(100) NOT NULL,
	EMAIL NCHAR(50) NOT NULL,
	PHONE INT NOT NULL
)
GO
CREATE TABLE DRINK_TYPE(
	ID_TYPE INT IDENTITY PRIMARY KEY,
	NAME_TYPE NVARCHAR(100) NOT NULL,
)

CREATE TABLE DRINK(
	ID_DRINK INT IDENTITY PRIMARY KEY,
	NAME_DRINK NVARCHAR(100) NOT NULL,
	ID_TYPE INT NOT NULL,
	PRICE FLOAT NOT NULL,
	ISDELETE BIT NOT NULL

	FOREIGN KEY (ID_TYPE) REFERENCES DBO.DRINK_TYPE(ID_TYPE)
)
GO

CREATE TABLE BILL(
	ID_BILL INT IDENTITY PRIMARY KEY,
	ORDERTIME DATE NOT NULL DEFAULT GETDATE(),
	ID_TABLE INT NOT NULL,
	IS_PAID INT NOT NULL DEFAULT 0, -- 0 : CHƯA THANH TOÁN , 1 : ĐÃ THANH TOÁN
	FOREIGN KEY (ID_TABLE) REFERENCES DBO.TABLE_DRINK(ID_TABLE)
)
GO

CREATE TABLE DETAIL_BILL(
	ID_BILL_DETAIL INT IDENTITY PRIMARY KEY,
	ID_BILL INT NOT NULL,
	ID_DRINK INT NOT NULL,
	QUANTITY INT NOT NULL DEFAULT 0,

	FOREIGN KEY (ID_BILL) REFERENCES DBO.BILL(ID_BILL),
	FOREIGN KEY (ID_DRINK) REFERENCES DBO.DRINK(ID_DRINK)
)

GO

CREATE PROC US_getUserByUserName
@userName nvarchar(100),@passWord NCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.USERS WHERE USERNAME=@userName
END
GO

CREATE PROC US_Login
@userName NVARCHAR(100), @passWord NVARCHAR(100)
AS
BEGIN
	SELECT * FROM DBO.USERS WHERE USERNAME=@userName AND PASSWORD=@passWord
END
GO

CREATE PROC US_getTableList
AS SELECT * FROM dbo.TABLE_DRINK
GO

INSERT dbo.USERS
        ( USERNAME ,
          PASSWORD ,
          PERMISSION ,
          NAME_USER ,
          EMAIL ,
          PHONE
        )
VALUES  ( N'a1' , -- USERNAME - nvarchar(100)
          N'1' , -- PASSWORD - nvarchar(100)
          0 , -- PERMISSION - int
          N'' , -- NAME_USER - nvarchar(100)
          N'' , -- EMAIL - nchar(50)
          0  -- PHONE - int
        )


DECLARE @i INT =0
WHILE @i<=10
BEGIN
	INSERT dbo.TABLE_DRINK ( NAME_TABLE, STATUS ) VALUES  ( N'' + CAST(@i AS NVARCHAR(100)), N'Trống' )
	SET @i=@i +1
END

GO

-- Thêm drink_type
INSERT dbo.DRINK_TYPE
        ( NAME_TYPE )
VALUES  ( N'Topping'  -- NAME_TYPE - nvarchar(100)
          )
INSERT dbo.DRINK_TYPE
        ( NAME_TYPE )
VALUES  ( N'Trà sữa đặc biệt'  -- NAME_TYPE - nvarchar(100)
          )

INSERT dbo.DRINK_TYPE
        ( NAME_TYPE )
VALUES  ( N'Trà sữa bình thường'  -- NAME_TYPE - nvarchar(100)
          )

-- Thêm drink

INSERT dbo.DRINK
        ( NAME_DRINK ,
          ID_TYPE ,
          PRICE ,
          ISDELETE
        )
VALUES  ( N'Trân châu đen' , -- NAME_DRINK - nvarchar(100)
          1 , -- ID_TYPE - int
          7000 , -- PRICE - float
          0  -- ISDELETE - bit
        )
INSERT dbo.DRINK
        ( NAME_DRINK ,
          ID_TYPE ,
          PRICE ,
          ISDELETE
        )
VALUES  ( N'Bánh Pudding' , -- NAME_DRINK - nvarchar(100)
          1 , -- ID_TYPE - int
          9000 , -- PRICE - float
          0  -- ISDELETE - bit
        )

INSERT dbo.DRINK
        ( NAME_DRINK ,
          ID_TYPE ,
          PRICE ,
          ISDELETE
        )
VALUES  ( N'Trà sữa Panda' , -- NAME_DRINK - nvarchar(100)
          2 , -- ID_TYPE - int
          54000 , -- PRICE - float
          0  -- ISDELETE - bit
        )
INSERT dbo.DRINK
        ( NAME_DRINK ,
          ID_TYPE ,
          PRICE ,
          ISDELETE
        )
VALUES  ( N'Trà sữa Pudding' , -- NAME_DRINK - nvarchar(100)
          2 , -- ID_TYPE - int
          54000 , -- PRICE - float
          0  -- ISDELETE - bit
        )
INSERT dbo.DRINK
        ( NAME_DRINK ,
          ID_TYPE ,
          PRICE ,
          ISDELETE
        )
VALUES  ( N'Trà sữa truyền thống' , -- NAME_DRINK - nvarchar(100)
          3 , -- ID_TYPE - int
          27000 , -- PRICE - float
          0  -- ISDELETE - bit
        )

	--- BILLL

INSERT dbo.BILL
        ( ORDERTIME ,
          ID_TABLE ,
          IS_PAID 
        )
VALUES  ( GETDATE() , -- ORDERTIME - date
          1 , -- ID_TABLE - int
          0 
        )

INSERT dbo.BILL
        ( ORDERTIME ,
          ID_TABLE ,
          IS_PAID 
        )
VALUES  ( GETDATE() , -- ORDERTIME - date
          2 , -- ID_TABLE - int
          0 
        )

INSERT dbo.BILL
        ( ORDERTIME ,
          ID_TABLE ,
          IS_PAID 
        )
VALUES  ( GETDATE() , -- ORDERTIME - date
          3 , -- ID_TABLE - int
          1 
        )


--- DETAIL BILL

INSERT dbo.DETAIL_BILL
        ( ID_BILL, ID_DRINK, QUANTITY )
VALUES  ( 1, -- ID_BILL - int
          2, -- ID_DRINK - int
          2  -- QUANTITY - int
          )
INSERT dbo.DETAIL_BILL
        ( ID_BILL, ID_DRINK, QUANTITY )
VALUES  ( 1, -- ID_BILL - int
          1, -- ID_DRINK - int
          1  -- QUANTITY - int
          )


INSERT dbo.DETAIL_BILL
        ( ID_BILL, ID_DRINK, QUANTITY )
VALUES  ( 2, -- ID_BILL - int
          3, -- ID_DRINK - int
          2  -- QUANTITY - int
          )
INSERT dbo.DETAIL_BILL
        ( ID_BILL, ID_DRINK, QUANTITY )
VALUES  ( 2, -- ID_BILL - int
          1, -- ID_DRINK - int
          2  -- QUANTITY - int
          )

INSERT dbo.DETAIL_BILL
        ( ID_BILL, ID_DRINK, QUANTITY )
VALUES  ( 3, -- ID_BILL - int
          1, -- ID_DRINK - int
          3  -- QUANTITY - int
          )
INSERT dbo.DETAIL_BILL
        ( ID_BILL, ID_DRINK, QUANTITY )
VALUES  ( 3, -- ID_BILL - int
          2, -- ID_DRINK - int
          4  -- QUANTITY - int
          )

SELECT * FROM dbo.BILL
SELECT * FROM dbo.DETAIL_BILL
SELECT * FROM dbo.DRINK
SELECT * FROM dbo.DRINK_TYPE

SELECT * FROM dbo.BILL WHERE ID_TABLE = 1  AND IS_PAID = 0

SELECT * FROM dbo.DETAIL_BILL WHERE ID_BILL = 1

EXEC dbo.US_getTableList

GO
CREATE PROC US_getInfor
@username nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.USERS WHERE USERNAME=@username
END
GO

CREATE PROC US_updatePassWord
@username NVARCHAR(100), @password NVARCHAR(100),@passwordnew NVARCHAR(100)
AS 
BEGIN
	DECLARE @isRight INT=0;
	SELECT @isRight = COUNT(*) FROM dbo.USERS WHERE USERNAME =@username AND PASSWORD = @password
	IF (@isRight =1)
	BEGIN
	UPDATE dbo.USERS SET PASSWORD=@passwordnew WHERE USERNAME=@username
	END
END
GO
GO
EXEC dbo.US_getInfor @username = N'a1' -- nvarchar(100)

SELECT f.NAME_DRINK, bi.QUANTITY, f.PRICE, f.PRICE*bi.QUANTITY AS totalPrice 
FROM dbo.DETAIL_BILL AS bi, dbo.BILL AS b, dbo.DRINK AS f 
WHERE bi.ID_BILL = b.ID_BILL AND bi.ID_DRINK = f.ID_DRINK AND b.IS_PAID = 0 AND b.ID_TABLE = 1