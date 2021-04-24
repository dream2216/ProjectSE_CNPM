CREATE DATABASE dbms_final_proj
GO

USE dbms_final_proj
GO
--USE master;
--GO
--ALTER DATABASE dbms_final_proj SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
--GO
--DROP DATABASE dbms_final_proj
--go
-- ///
-- admin_accounts (userid/, uname, upasswd)
-- tho_accounts (userid/, uname, upasswd, acctype)

-- tho_infos (userid/, fname, lname, hinhanh)

-- khachhang (cid/, fname, lname)

-- xe (bienso/, loaixe, hieuxe, hinhanh, cosan)
-- sohuuxe (bienso/, oid/)

-- chitiethd (sohd/, loaihd, ngayhd, ngayhieuluc, ngayhethan, trigiahd)
-- hopdong (sohd/, cid/, bienso/)

-- vexe (bienso/, ngaygiovaoben/, loaive)
-- chamsocxe (bienso/, tho_id/, ngaygiogiaoxe/, noidung)

-- thanhtoanhd (sohd/, fname/, lname/, thoigiantt/, sotien)
-- thanhtoanvexe (bienso/, ngaygiovaoben/, thoigianthanhtoan/, sotien)
-- thanhtoancsx (bienso/, tho_id/, ngaygiogiaoxe/, thoigianthanhtoan/, sotien)

-- bangchamcong (tho_id/, thoigianvaolam/, thoigiantanlam)
-- phieutraluong (tho_id/, thang/, sogiolamviec, tienluong)
-- ///

-- Create tables

CREATE TABLE admin_accounts(
	userid INT IDENTITY(1,1),
	uname VARCHAR(20) UNIQUE NOT NULL,
	upasswd VARCHAR(100) NOT NULL,

	PRIMARY KEY(userid)
)
GO

CREATE TABLE tho_accounts(
	userid INT IDENTITY(1,1),
	uname VARCHAR(20) UNIQUE NOT NULL,
	upasswd VARCHAR(100) NOT NULL,
	acctype TINYINT NOT NULL,	-- 1: giuxe | 2: chamsocxe

	PRIMARY KEY(userid)
)
GO


CREATE TABLE tho_infos(
	userid INT,
	fname NVARCHAR(50) NOT NULL,
	lname NVARCHAR(50) NOT NULL,
	hinhanh IMAGE NULL,

	FOREIGN KEY(userid) REFERENCES dbo.tho_accounts(userid),
	PRIMARY KEY(userid)
)
GO

CREATE TABLE khachhang(
	cid VARCHAR(20),	-- cmnd
	fname NVARCHAR(50) NOT NULL,
	lname NVARCHAR(50) NOT NULL,
	phone NVARCHAR(50) NOT NULL,
	address NVARCHAR(50) NOT NULL,
	PRIMARY KEY(cid)
)
GO

CREATE TABLE xe(
	bienso VARCHAR(20),
	loaixe NVARCHAR(50) NOT NULL,
	hieuxe NVARCHAR(50) NOT NULL,
	hinhanh IMAGE NOT NULL,
	cosan INT NOT NULL, -- 1: Co the cho thue | 0: ko the cho thue

	PRIMARY KEY(bienso)
)
GO

CREATE TABLE sohuuxe(
	bienso VARCHAR(20) REFERENCES dbo.xe(bienso),
	oid VARCHAR(20) REFERENCES dbo.khachhang(cid),	-- cmnd chu xe

	PRIMARY KEY(bienso, oid)
)
GO

CREATE TABLE chitiethd(
	sohd INT IDENTITY(1,1),
	loaihd TINYINT NOT NULL,	-- 1: gui | 2: thue
	ngayhd DATE NOT NULL,
	ngayhieuluc DATE NOT NULL,
	ngayhethan DATE NOT NULL,
	trigiahd MONEY NOT NULL,

	PRIMARY KEY(sohd)
)
GO

CREATE TABLE hopdong(
	sohd INT REFERENCES dbo.chitiethd(sohd),
	cid VARCHAR(20) REFERENCES dbo.khachhang(cid) NOT NULL,
	bienso VARCHAR(20) REFERENCES dbo.xe(bienso) NOT NULL,

	PRIMARY KEY(sohd)
)
GO

CREATE TABLE vexe(
	bienso VARCHAR(20) REFERENCES dbo.xe(bienso),
	ngaygiovaoben DATETIME,
	loaive TINYINT NOT NULL,	-- 1: ve gio | 2: ve ngay | 3: ve tuan | 4: ve thang

	PRIMARY KEY(bienso, ngaygiovaoben)
)
GO

CREATE TABLE chamsocxe(
	bienso VARCHAR(20) REFERENCES dbo.xe(bienso),
	tho_id INT REFERENCES dbo.tho_infos(userid),
	ngaygiogiaoxe DATETIME,
	noidung NTEXT NOT NULL,

	PRIMARY KEY(bienso, tho_id, ngaygiogiaoxe)
)
GO

CREATE TABLE thanhtoanhd(
	sohd INT REFERENCES dbo.chitiethd(sohd),
	fname NVARCHAR(50),
	lname NVARCHAR(50),
	thoigiantt DATETIME,
	sotien MONEY NOT NULL,

	PRIMARY KEY(sohd, fname, lname, thoigiantt)
)
GO

CREATE TABLE thanhtoanvexe(
	bienso VARCHAR(20),
	ngaygiovaoben DATETIME,
	thoigianthanhtoan DATETIME,
	sotien MONEY NOT NULL,

	FOREIGN KEY(bienso) REFERENCES dbo.xe(bienso),
	PRIMARY KEY(bienso, ngaygiovaoben, thoigianthanhtoan)
)
GO

CREATE TABLE thanhtoancsx(
	bienso VARCHAR(20),
	tho_id INT,
	ngaygiogiaoxe DATETIME,
	thoigianthanhtoan DATETIME,
	sotien MONEY NOT NULL,

	FOREIGN KEY(bienso, tho_id, ngaygiogiaoxe) REFERENCES dbo.chamsocxe(bienso, tho_id, ngaygiogiaoxe),
	PRIMARY KEY(bienso, tho_id, ngaygiogiaoxe, thoigianthanhtoan)
)
GO

CREATE TABLE bangchamcong(
	tho_id INT REFERENCES dbo.tho_accounts(userid),
	thoigianvaolam DATETIME,
	thoigiantanlam DATETIME,

	PRIMARY KEY(tho_id, thoigianvaolam, thoigiantanlam)
)
GO

CREATE TABLE phieutraluong(
	tho_id INT REFERENCES dbo.tho_accounts(userid),
	thang DATE, --thang/nam de tinh luong
	sogiolamviec DEC(5,2) NOT NULL,
	tienluong MONEY NOT NULL,

	PRIMARY KEY(tho_id, thang)
)
GO
CREATE TABLE PhanCong(
	ngaythang DATETIME,
	ca int,
	idNV int  REFERENCES dbo.tho_accounts(userid)
	)
GO


--Hung
--view
--Xe danh sách các xe được thuê

CREATE VIEW XEM_XE_THUE AS
SELECT xe.bienso,xe.hieuxe,xe.hinhanh,xe.loaixe,vexe.ngaygiovaoben,vexe.loaive
FROM vexe,xe
WHERE xe.bienso=vexe.bienso;

Select * from XEM_XE_THUE;
--Drop view XEM_XE_THUE

--trigger
-- kiểm tra khách hàng đã tồn tại hay chưa nếu có thì rollback
Create TRIGGER tg_ThemKhachHang ON dbo.khachhang INSTEAD OF INSERT
As
	DECLARE @cid VARCHAR(20), @count int
	SELECT @cid = cid FROM inserted
	SELECT @count = COUNT(*) FROM dbo.khachhang WHERE @cid = cid


	IF(@count = 0) 
		BEGIN
			INSERT khachhang
			SELECT *
			FROM inserted
		END
	ELSE
		BEGIN
			print N'khách hàng đã tồn tại'
			rollback tran;
		END
Go
--xóa trigger
--drop trigger tg_ThemKhachHang
go
--func

CREATE FUNCTION func_getLuong (@thoid INT)
RETURNS DEC(10,3)
AS
BEGIN
    DECLARE @outLuong DEC(10,3);

	SELECT TOP(1) @outLuong = tienluong
	FROM dbo.phieutraluong
	WHERE tho_id = @thoid
	ORDER BY thang DESC;

	RETURN @outLuong;
END
GO

--Thanh toán vé xe
--Vé giờ 30/1h
--Vé ngày 300
--Vé tuần 1000
--Xe máy
--Vé giờ 10/1h
--Vé ngày 200
--Vé tuần 500
--Vé giờ qua ngày phạt 2 vé ngày
--Vé ngày qua ngày vé tuần
--Vé tuần double vé tháng
CREATE FUNCTION PF_CaculatorCost(@bienso varchar(20),@loaixe nvarchar(20),  @start DATETIME,@end DATETIME,@loaive tinyint)
RETURNS @filted_Table TABLE(
	totalcost money,
	detail nvarchar(200),
	penalizecost money
	)
AS
BEGIN
Declare @total money=0
Declare	@penalize money=0
Declare	@detail nvarchar(200)
Declare @Tinhsongay datetime=Convert(datetime,@start)-Convert(datetime,@end)
Declare @tongsongay int=Convert(int,@Tinhsongay)
Declare @tongsogio int=DATEDIFF(HOUR,Convert(datetime,@start),Convert(datetime,@end))
	IF @loaixe = 'Xe máy'
		BEGIN
				if @loaive=1--Vé giờ
					Begin
						 if @tongsongay = 0
						 begin
							if @tongsogio = 0
								begin
								SET @total += 10;
								end
							else
								begin
								SET	@total += 10 * @tongsogio;
								end
						end
					else
					begin
					   SET @total += 200;
						SET @penalize = 200;
					   Set @detail=N'Bạn bị phạt vì gửi quá số giờ'
					end
				end
			else if @loaive=2
				Begin
                if @tongsongay = 0
                   Set @total +=200;
                else
				begin
                    Set @total += 500;
					Set @detail=N'Bạn bị phạt vì gửi qua ngày'
					Set @penalize=500
				end
				End
			else if @loaive=3
				Begin 
				if @tongsongay > 10 and @tongsongay < 30
                    SET @total = 500;
                else
				begin
                    SET @total += 3*500;
					Set @detail=N'Bạn bị phạt vì gửi quá hạn tuần'
					Set @penalize=3*500
				end
				End
			INSERT INTO @filted_Table(totalcost,detail,penalizecost) values(@total,@detail,@penalize)
		END
	ELSE IF @loaixe='Xe hơi'
				BEGIN
				if @loaive=1--Vé giờ
					Begin
						 if @tongsongay = 0
						 begin
							if @tongsogio = 0
								begin
								SET @total += 30;
								end
							else
								begin
								SET	@total += 30 * @tongsogio;
								end
						end
					else
					begin
						SET @total += 300;
					   SET @penalize = 300;
					   Set @detail=N'Bạn bị phạt vì gửi quá số giờ'
					   end
				end
			else if @loaive=2
				Begin
                if @tongsongay = 0
                   Set @total +=300;
                else
				begin
                    Set @total += 1000;
					Set @detail=N'Bạn bị phạt vì gửi qua ngày'
					Set @penalize=1000
				end
				End
			else if @loaive=3
				Begin 
				if @tongsongay > 10 and @tongsongay < 30
                    SET @total = 1000;
                else
				begin
                    SET @total = 3*1000;
					Set @detail=N'Bạn bị phạt vì gửi quá hạn tuần'
					Set @penalize+=@total
				end
				End
			INSERT INTO @filted_Table(totalcost,detail,penalizecost) values(@total,@detail,@penalize)
		END
RETURN
END
GO
--Drop function PF_CaculatorCost

--Thống kê danh sách xe
-- mode với 0 là lấy tất cả các xe
-- mode		1 là lọc theo xe máy
-- mode		2 lọc theo xe hơi 
--mode		3 là lọc theo date
CREATE FUNCTION PF_FiltProjects(@mode INT,  @start DATETIME)
RETURNS @filted_Table TABLE(
	bienso varchar(20),
	hieuxe varchar(20),
	hinhanh image,
	loaixe nvarchar(20),
	ngaygiovaoben datetime,
	ngaygiothanhtoan datetime,
	tongtien money
)
AS
BEGIN
	IF @mode = 0
		BEGIN
			INSERT INTO @filted_Table
				SELECT * FROM 	(	Select xe.bienso,xe.hieuxe,xe.hinhanh,xe.loaixe,thanhtoanvexe.ngaygiovaoben,thanhtoanvexe.thoigianthanhtoan,thanhtoanvexe.sotien
									from xe,thanhtoanvexe
									where xe.bienso=thanhtoanvexe.bienso ) as A
		END
	ELSE IF @mode = 1
		BEGIN
			INSERT INTO @filted_Table
				SELECT * FROM 	(	Select xe.bienso,xe.hieuxe,xe.hinhanh,xe.loaixe,thanhtoanvexe.ngaygiovaoben,thanhtoanvexe.thoigianthanhtoan,thanhtoanvexe.sotien
									from xe,thanhtoanvexe
									where xe.bienso=thanhtoanvexe.bienso AND xe.loaixe='Xe máy' ) as A1
		END
	ELSE IF @mode = 2
		BEGIN
			INSERT INTO @filted_Table
				SELECT * FROM 	(	Select xe.bienso,xe.hieuxe,xe.hinhanh,xe.loaixe,thanhtoanvexe.ngaygiovaoben,thanhtoanvexe.thoigianthanhtoan,thanhtoanvexe.sotien
									from xe,thanhtoanvexe
									where xe.bienso=thanhtoanvexe.bienso and xe.loaixe='Xe hơi' )as A2
		END
	ELSE IF @mode = 3
		BEGIN
		INSERT INTO @filted_Table
				SELECT * FROM 	(	Select xe.bienso,xe.hieuxe,xe.hinhanh,xe.loaixe,thanhtoanvexe.ngaygiovaoben,thanhtoanvexe.thoigianthanhtoan,thanhtoanvexe.sotien
									from xe,thanhtoanvexe
									where xe.bienso=thanhtoanvexe.bienso and Convert(Date,thoigianthanhtoan)=Convert(Date,@start)) as A3
		END
RETURN
END
GO
--Drop function PF_FiltProjects


--Tìm kiếm khách hàng
Create function func_TimKiemKhachHang(@lname NVARCHAR(50))
returns table
As return
	Select * from dbo.khachhang WHERE lname LIKE '%' + @lname + '%'
GO
--Load tất cả các khách hàng
Create function func_TatCaKhachHang ()
returns table
As return
	Select * from dbo.khachhang
GO

--proc
--Thêm một hợp đồng mới thì đầu tiên thêm vào chitiethopdong rồi thêm vào tiếp hopdong
create proc pro_HopDongMoi(@loaihd TINYINT, @ngayhd DATE, @ngayhieuluc DATE, @ngayhethan DATE, @trigiahd MONEY, @cid VARCHAR(20), @bienso VARCHAR(20))
AS
Begin Transaction
	INSERT INTO dbo.chitiethd (loaihd, ngayhd, ngayhieuluc, ngayhethan, trigiahd) Values (@loaihd, @ngayhd, @ngayhieuluc, @ngayhethan, @trigiahd)
	declare @sohd INT
	Select @sohd = Max(sohd) From dbo.chitiethd
	INSERT INTO dbo.hopdong(sohd, cid, bienso) VALUES (@sohd, @cid, @bienso)
Commit
Go
select * from hopdong

--Thêm xe vào danh sách cho thuê
Create proc pro_ThemXeVaoDanhSachChoThue(@bienso VARCHAR(20), @loaixe NVARCHAR(50), @hieuxe NVARCHAR(50), @hinhanh IMAGE, @oid VARCHAR(20), @ngayhd DATE, @ngayhieuluc DATE, @ngayhethan DATE, @trigiahd MONEY)
AS
Begin Transaction
	Exec pro_ThemXe @bienso, @loaixe, @hieuxe, @hinhanh, 1, @oid
	Exec pro_HopDongMoi 1, @ngayhd, @ngayhieuluc, @ngayhethan, @trigiahd, @oid, @bienso
Commit
go


--Chỉnh sửa danh sách cho thuê
Create proc pro_ChinhSuaDanhSachChoThue(@bienso VARCHAR(20), @loaixe NVARCHAR(50), @hieuxe NVARCHAR(50), @hinhanh IMAGE, @ngayhd DATE, @ngayhieuluc DATE, @ngayhethan DATE, @trigiahd MONEY)
As
Begin transaction
	update dbo.xe set loaixe=@loaixe, hieuxe=@hieuxe, hinhanh=@hinhanh Where bienso=@bienso
	declare @sohd int
	Select @sohd = hopdong.sohd From dbo.hopdong, dbo.chitiethd Where bienso=@bienso 
	Update dbo.chitiethd Set ngayhd=@ngayhd, ngayhieuluc=@ngayhieuluc, ngayhethan=@ngayhethan, trigiahd=@trigiahd Where sohd=@sohd
commit
go

--Thêm vào danh sách thuê
Create proc pro_ThemVaoDanhSachThue(@ngayhd DATE, @ngayhieuluc DATE, @ngayhethan DATE, @trigiahd MONEY, @cid VARCHAR(20), @bienso VARCHAR(20))
AS
Begin Transaction
	Exec pro_HopDongMoi 2, @ngayhd, @ngayhieuluc, @ngayhethan, @trigiahd, @cid, @bienso
	Update dbo.xe Set cosan = 0 Where bienso=@bienso
Commit
go
--thực hiện thanh toán hợp đồng
Create proc pro_ThemThanhToanHopDong(@sohd int, @fname NVARCHAR(50), @lname NVARCHAR(50), @thoigiantt DATETIME, @sotien MONEY)
AS
Begin
	Insert into dbo.thanhtoanhd (sohd, fname, lname, thoigiantt, sotien) Values (@sohd, @fname, @lname, @thoigiantt, @sotien)
end
go

--Thanh toán hợp đồng thuê
Create proc pro_ThemThanhToanHopDongThue(@sohd int, @fname NVARCHAR(50), @lname NVARCHAR(50), @thoigiantt DATETIME, @sotien MONEY)
AS
Begin transaction
	declare @bienso VARCHAR(20)
	Select @bienso = bienso  From hopdong Where sohd = @sohd
	Exec pro_ThemThanhToanHopDong @sohd, @fname, @lname, @thoigiantt, @sotien
	update dbo.xe set cosan = 1 Where bienso = @bienso
	Delete From dbo.hopdong Where sohd=@sohd 
commit
go

--Thanh toán hợp đồng cho thuê
Create proc pro_ThemThanhToanHopDongChoThue(@sohd int, @fname NVARCHAR(50), @lname NVARCHAR(50), @thoigiantt DATETIME, @sotien MONEY)
As
Begin Transaction
	declare @bienso VARCHAR(20)
	Select @bienso = bienso From hopdong Where sohd = @sohd
	Exec pro_ThemThanhToanHopDong @sohd, @fname, @lname, @thoigiantt, @sotien
	Delete From dbo.hopdong Where sohd=@sohd 
	Exec pro_XoaXe @bienso
commit
go





--AHuy
--trigger
-- Tringger thực hiện thay đổi trên bangchamcong khi được update
-- Mỗi khi bảng chấm công được update (do cuối ngày thợ đến kết thúc công việc và cập nhật thời gian tan làm)
-- lúc này trigger giúp cập nhật số  giờ làm việc và lương của thợ trong bảng phiếu trả lương
-- nếu là mùng 1 của tháng thì tạo record phiếu trả lương mới cho tháng đó
CREATE TRIGGER trg_hthanh_ngaycong ON dbo.bangchamcong
AFTER UPDATE
AS
BEGIN
	DECLARE @currentDate INT;
	SET @currentDate = DAY(GETDATE());

	DECLARE @thoid INT, @tgvao DATETIME, @tgra DATETIME;
	SELECT @thoid = Inserted.tho_id, @tgvao = Inserted.thoigianvaolam, @tgra = Inserted.thoigiantanlam
	FROM Inserted;

	DECLARE @sogio DEC(5,2);
	SET @sogio = DATEPART(HOUR,@tgra) - DATEPART(HOUR,@tgvao);

	IF @currentDate = 1
	BEGIN
	    INSERT dbo.phieutraluong
	    (
	        tho_id,
	        thang,
	        sogiolamviec,
	        tienluong
	    )
	    VALUES
	    (   @thoid,         -- tho_id - int
	        GETDATE(), -- thang - date
	        @sogio,      -- sogiolamviec - dec(5, 2)
	        @sogio * 40       -- tienluong - money
	        );
	END;
	ELSE
	BEGIN
	    UPDATE dbo.phieutraluong
		SET sogiolamviec = sogiolamviec + @sogio, tienluong = sogiolamviec * 40
		WHERE tho_id = @thoid AND MONTH(thang) = MONTH(GETDATE()) AND YEAR(thang) = YEAR(GETDATE());
	END;
END
GO

--proc
--Thêm vào cái thanh toán vé xe;
CREATE PROC PR_InsertThanhToan(@bienso VARCHAR(20), @Datecheckin DATETIME, @Datecheckout DATETIME,@sotien money)
AS
BEGIN
	INSERT INTO thanhtoanvexe(bienso, ngaygiovaoben, thoigianthanhtoan, sotien)
	VALUES(@bienso, @Datecheckin, @Datecheckout, @sotien)
END
GO
--Tìm kiếm thông tin xe theo số xe 
CREATE PROC PSP_GetInforbyBienso @bienso_search VARCHAR(20)
AS
BEGIN
	SELECT xe.bienso,xe.hieuxe,xe.hinhanh,xe.loaixe,ngaygiovaoben,loaive 
	FROM xe,vexe
	WHERE xe.bienso=vexe.bienso and xe.bienso=@bienso_search
END
--Hoàn tất tiến hành checkout xe ra ngoai
--Xoá xe trong bãi 
--Xoá xe trong vexe
--Thêm vào thanh toán xe
CREATE PROC PR_CheckoutXe(@bienso_in VARCHAR(20), @Datecheckin_in DATETIME,@Datecheckout_in DATETIME,@sotien_in money)
AS
BEGIN TRANSACTION
	Delete from vexe where bienso=@bienso_in and ngaygiovaoben=@Datecheckin_in
	EXEC PR_InsertThanhToan @bienso = @bienso_in, @Datecheckin = @Datecheckin_in , @Datecheckout = @Datecheckout_in , @sotien=@sotien_in
	COMMIT
GO
EXEC PR_CheckoutXe 1,N'2021-01-24 20:09:32.09',N'2021-01-24 20:09:32.09',10
drop proc PR_CheckoutXe
--Thêm khách hàng
Create PROC pro_ThemKhachHang (@cid VARCHAR(20), @fname NVARCHAR(50), @lname NVARCHAR(50), @phone NVARCHAR(50), @address NVARCHAR(50))
AS
BEGIN
	
	INSERT INTO dbo.khachhang(cid, fname, lname,phone,address) VALUES (@cid, @fname, @lname,@phone,@address)
END
Go

--chỉnh sửa khách hàng
create PROC pro_ChinhSuaKhachHang(@cid VARCHAR(20), @fname NVARCHAR(50), @lname NVARCHAR(50), @phone NVARCHAR(50), @address NVARCHAR(50))
AS
BEGIN
	UPDATE dbo.khachhang SET fname=@fname, lname=@lname, phone = @phone, address = @address WHERE cid=@cid
END
GO
--Xóa khách hàng
Create PROC pro_XoaKhachHang(@cid VARCHAR(20))
AS
BEGIN Transaction
	DELETE FROM dbo.sohuuxe WHERE oid=@cid
	DELETE FROM dbo.hopdong WHERE cid=@cid
	DELETE FROM dbo.khachhang WHERE cid=@cid
Commit
GO
--Thực hiện thêm xe và thêm chủ sỡ hữu của xe
CREATE PROC pro_ThemXe (@bienso VARCHAR(20), @loaixe NVARCHAR(50), @hieuxe NVARCHAR(50), @hinhanh IMAGE, @cosan INT, @oid VARCHAR(20))
AS
BEGIN TRANSACTION
	INSERT INTO dbo.xe(bienso, loaixe, hieuxe, hinhanh, cosan) VALUES (@bienso, @loaixe, @hieuxe, @hinhanh, @cosan)
	INSERT INTO dbo.sohuuxe(bienso, oid) VALUES (@bienso, @oid)
COMMIT	
GO
--Xóa xe
Create PROC pro_XoaXe(@bienso VARCHAR(20))
AS
BEGIN TRANSACTION
	DELETE FROM dbo.sohuuxe WHERE bienso=@bienso
	DELETE FROM dbo.xe WHERE bienso=@bienso
COMMIT
GO
--func
--Bảng thanh toán 
Create function func_BangThanhToan()
returns table
As
return
	Select khachhang.cid, fname, lname, loaixe, hieuxe, xe.bienso, hinhanh, ngayhd, trigiahd, ngayhieuluc, ngayhethan, loaihd, hopdong.sohd
	From dbo.khachhang, dbo.xe, dbo.chitiethd, dbo.hopdong
	Where khachhang.cid = hopdong.cid AND xe.bienso = hopdong.bienso AND chitiethd.sohd = hopdong.sohd
go
---Kiểm tra xem 1 ca đã đủ số lượng người làm hay chưa. Nếu đủ không thể đăng kí tiếp.
create function KT_PC( @NgayThang date, @ca int )
returns bit
as
begin
declare @xacnhan bit;
if((select COUNT(PhanCong.Ca) from PhanCong where PhanCong.NgayThang=@NgayThang and PhanCong.Ca=@ca group by PhanCong.Ca)>4)
	set @xacnhan=0;
else
	set @xacnhan=1;
return @xacnhan;
end
--Kiểm tra xem 1 người có đăng kí 2 ca chưa, nếu quá 2 ca sẽ không được đăng kí
create function KT_SO_Ca( @NgayThang date, @id int )
returns bit
as
begin
declare @xacnhan bit;
if((select COUNT(PhanCong.Ca) from PhanCong where PhanCong.NgayThang=@NgayThang and PhanCong.IdNV=@id group by PhanCong.IdNV)>1)
	set @xacnhan=0;
else
	set @xacnhan=1;
return @xacnhan;
end
---Kiểm tra xem 1 tháng người đó có làm quá 24 ca hay không, nếu quá 24 ca phải để cho người khác đăng kí
create function KT_SO_Ca_Thang( @Thang int, @id int )
returns bit
as
begin
declare @xacnhan bit;
if((select COUNT(PhanCong.Ca) from PhanCong where (select MONTH(PhanCong.NgayThang))  = @Thang and PhanCong.IdNV=@id group by PhanCong.IdNV)>23)
	set @xacnhan=0;
else
	set @xacnhan=1;
return @xacnhan;
end
--- Procedure đăng kí . nếu thỏa các điều kiện thì được đăng kí .
---DK: mỗi người làm 2 ca, 1 ca có 5 người, 1 tháng 1 người dc làm 24 ca, 1 người k thể đăng kí 1 ca 2 lần
create proc proc_AddPC
@ngaythang date, @ca int, @id int
as
begin
		if((select dbo.KT_PC(@ngaythang,@ca))=1 and (select dbo.KT_SO_Ca(@ngaythang,@id))=1 and(select dbo.KT_SO_Ca_Thang((Select MONTH(@ngaythang)),@id))=1 and (select dbo.KT_DK(@ngaythang,@ca,@id))=1)
			insert into PhanCong values (@ngaythang,@ca,@id)
		else 
			print('Khong thoa');
end
---Kiểm tra xem ng đó có đăng kí 1 ca 2 lần k?
create function KT_DK( @ngaythang date, @ca int, @id int )
returns bit
as
begin
declare @xacnhan bit;
if((select COUNT(PhanCong.Ca) from PhanCong where PhanCong.NgayThang=@ngaythang and PhanCong.Ca=@ca and PhanCong.IdNV=@id)=1)
	set @xacnhan=0;
else
	set @xacnhan=1;
return @xacnhan;
end

--Huy
--trigger
--Sử dụng Trigger để trả xe cho chủ (trả xe khi xe có trong kho)
Create Trigger tg_TraXeChoChuXe on dbo.hopdong for delete
AS
Begin
	Declare @chuxe int, @sohd int, @bienso VARCHAR(20), @oid VARCHAR(20), @cosan int
	Select @sohd=sohd, @oid=cid, @bienso=bienso from deleted
	--Là chủ xe
	Select @chuxe=Count(*) From dbo.sohuuxe Where bienso=@bienso AND oid=@oid
	if(@chuxe > 0)
	Begin
		Select @cosan=cosan From dbo.xe Where bienso=@bienso
		if(@cosan = 0)
			Begin
				print N'Xin lỗi! Xe không có trong kho để trả'
				rollback tran
			End
	End
End

--proc

-- mỗi lần thợ đến chấm công thì chương trình sẽ truyền vào proc này userid của thợ đó
-- lúc đó thời gian vào làm và tan làm của thợ sẽ được lấy là thời gian hiện tại của database server 
--(do chưa có tan làm nên lấy tạm thời gian hiện tại)
-- mỗi record của bangchamcong là 1 ngày công
CREATE PROC proc_chamcong_vao
@thoid INT
AS
BEGIN
    INSERT dbo.bangchamcong
    (
        tho_id,
        thoigianvaolam,
        thoigiantanlam
    )
    VALUES
    (   0,         -- tho_id - int
        GETDATE(), -- thoigianvaolam - datetime
        GETDATE()  -- thoigiantanlam - datetime
        )
END
GO
-- đến cuối ngày thợ đến kết thúc thời gian làm thì sẽ thay đổi thời gian tan làm thành thời điểm hiện tại 
--(trước đó lấy tạm là bằng thời gian vào làm)
-- truyền vào userid của thợ
CREATE PROC proc_chamcong_ra
@thoid INT
AS
BEGIN
	DECLARE @currentDate DATETIME;
	
	SELECT TOP(1) @currentDate = thoigianvaolam
	FROM dbo.bangchamcong
	WHERE tho_id = @thoid
	ORDER BY thoigianvaolam DESC;

	UPDATE dbo.bangchamcong
	SET thoigiantanlam = GETDATE()
	WHERE tho_id = @thoid AND thoigianvaolam = @currentDate;
END
GO
-- thêm 1 thợ mới vào database gồm các thông tin cần thiết như username, password, acctype (loại tài khoản hay còn gọi là chức vụ), họ, tên và avatar
CREATE PROC proc_insTho
@uname VARCHAR(20), @passwd VARCHAR(100), @acctype TINYINT, @fname NVARCHAR(50), @lname NVARCHAR(50), @img IMAGE
AS
BEGIN
	BEGIN TRAN;
    INSERT dbo.tho_accounts
    (
        uname,
        upasswd,
        acctype
    )
    VALUES
    (   @uname, -- uname - varchar(20)
        @passwd, -- upasswd - varchar(100)
        @acctype   -- acctype - tinyint
        );
	
	DECLARE @lastuid INT;
	SELECT TOP(1) @lastuid = userid
	FROM dbo.tho_accounts
	ORDER BY userid DESC;

	INSERT dbo.tho_infos
	(
	    userid,
	    fname,
	    lname,
	    hinhanh
	)
	VALUES
	(   @lastuid,   -- userid - int
	    @fname, -- fname - nvarchar(50)
	    @lname, -- lname - nvarchar(50)
	    @img -- hinhanh - image
	    );
	COMMIT TRAN;
END
GO
CREATE PROC proc_editThoImage
@uid INT, @img IMAGE
AS
BEGIN
    UPDATE dbo.tho_infos
	SET hinhanh = @img
	WHERE userid = @uid;
END
GO
CREATE PROC proc_changeThoPasswd
@uid INT, @passwd VARCHAR(100)
AS
BEGIN
    UPDATE dbo.tho_accounts
	SET upasswd = @passwd
	WHERE userid = @uid;
END
GO
CREATE PROC proc_delTho
@uid INT
AS
BEGIN
    DELETE FROM dbo.tho_infos
	WHERE userid = @uid;
	DELETE FROM dbo.tho_accounts
	WHERE userid = @uid;
END
GO
--Thêm vào loại vé xe
CREATE PROC PR_InsertLoaiVe(@bienso VARCHAR(20), @Datecheckin DATETIME, @loaivexe tinyint)
AS
BEGIN
	INSERT INTO vexe(bienso, ngaygiovaoben, loaive)
	VALUES(@bienso, @Datecheckin, @loaivexe)
END
GO

--Thêm xe vào bãi giữ xe 
CREATE PROC PR_InsertXeVaoBai(@bienso VARCHAR(20),@loaixe nvarchar(20),@hieuxe varchar(20),@hinhanh image, @Datecheckin DATETIME, @loaivexe tinyint)
AS
BEGIN TRANSACTION
	INSERT INTO xe(bienso,loaixe,hieuxe,hinhanh,cosan) VALUES(@bienso, @loaixe, @hieuxe,@hinhanh,'0')
	INSERT INTO vexe(bienso, ngaygiovaoben, loaive) VALUES(@bienso, @Datecheckin, @loaivexe)
	COMMIT
GO
--func
--Lấy danh sách xe có thể cho thuê
Create function func_DanhSachThueXe()
returns table
As return
	Select * from dbo.xe Where cosan=1
go
--Bảng chỉnh sửa danh sách cho thuê
create function func_BangChinhSuaDanhSachChoThue()
Returns table
As return
	Select xe.bienso, loaixe, hieuxe, hinhanh, ngayhd, ngayhieuluc, ngayhethan, trigiahd 
	From dbo.xe, dbo.hopdong, dbo.chitiethd 
	Where xe.bienso=hopdong.bienso AND hopdong.sohd = chitiethd.sohd
go
--Tìm kiếm trong bảng chỉnh sửa danh sách cho thuê
Create function func_TimKiemTrongBangChinhSuaDanhSachChoThue
(@bienso VARCHAR(20))
Returns table
As return 
	Select * from func_BangChinhSuaDanhSachChoThue() Where bienso like '%' + @bienso +'%'
go
--Bảng xe chưa được thuê
Alter function func_XeChuaDuocThue()
returns table
As return 
	Select xe.bienso, loaixe, hieuxe, hinhanh, ngayhethan from dbo.xe, dbo.hopdong, dbo.chitiethd  Where cosan=1 AND xe.bienso = hopdong.bienso AND hopdong.sohd = chitiethd.sohd
go
--Bảng tìm kiếm xe chưa được thuê
Create function func_TimKiemXeChuaDuocThue(@hieuxe NVARCHAR(50))
returns table
As return
	Select * from func_XeChuaDuocThue() Where hieuxe like '%' + @hieuxe + '%'
go
