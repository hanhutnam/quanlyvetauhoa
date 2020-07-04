use Quanlyvetauhoa
--thu tuc load ve tau hoa
create proc loadvetauhoa
as
	select *
	from Datve
go

--thủ tục đăng nhập 
create proc dangnhap @user nchar(10), @pass nchar(10)
as
	select *
	from Nguoidung
	where Nguoidung.taikhoan= @user and Nguoidung.pass=@pass
go
--thủ tục thêm 
create proc themdulieu @mave nchar(10) ,@ten nvarchar(50) ,@ngaydi  nvarchar(50) , @giodi nchar(10),@gioitinh nchar(10),@dantoc nchar(10),@cmnd int ,@diemden nvarchar(50) ,@gia int 
as
	 insert into Datve
	 values ( @mave ,@ten ,@ngaydi , @giodi ,@gioitinh ,@dantoc ,@cmnd ,@diemden  ,@gia )
go
 --thủ tục sửa 
 create proc suadulieu @mave nchar(10) ,@ten nvarchar(50) ,@ngaydi  nvarchar(50) , @giodi nchar(10),@gioitinh nchar(10),@dantoc nchar(10),@cmnd int ,@diemden nvarchar(50) ,@gia int 
as
	update Datve
	set Hoten=@ten,Ngaydi=@ngaydi,Giodi=@giodi,Gioitinh=@gioitinh,Dantoc=@dantoc,Cmnd=@cmnd,Diemden=@diemden,Gia=@gia
	where mave=@mave
go
--thủ tục xóa
create proc xoadulieu @mave nchar(10)
as
	delete Datve
	where mave=@mave
go 
--thủ tục tìm kiếm
create proc timkiem @mave nchar(10) 
as 
	select *
	from Datve
	where mave=@mave	
go 
--thủ tục tính tổng
create view tong
as
	select tong=sum(gia)
	from Datve
go 

select *
from tong






