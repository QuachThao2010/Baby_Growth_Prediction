use master
go
if(exists (select*from sysdatabases where name='Nhom18btl'))
	Drop database Nhom18btl
create database Nhom18btl

use Nhom18btl
go
CREATE TABLE TapLuat
(
	MaLuat int PRIMARY KEY not null,
	DoTuoi nvarchar(10)not null,
	CanNang nvarchar(20) not null,
	LuongSua nvarchar(20) not null,
	KetQua nvarchar(10)not null
)
DROP TABLE TapLuat
INSERT INTO TapLuat VALUES
(1,N'0-3',N'Nhẹ',N'LS loại A',N'Thấp'),
(2,N'0-3',N'Nhẹ',N'LS loại B',N'Thấp'),
(3,N'0-3',N'Nhẹ',N'LS loại C',N'Vừa'),
(4,N'0-3',N'Nhẹ',N'LS loại D',N'Cao'),
(5,N'0-3',N'Bình thường',N'LS loại A',N'Thấp'),
(6,N'0-3',N'Bình thường',N'LS loại B',N'Vừa'),
(7,N'0-3',N'Bình thường',N'LS loại C',N'Vừa'),
(8,N'0-3',N'Bình thường',N'LS loại D',N'Cao'),
(9,N'0-3',N'Nặng',N'LS loại A',N'Thấp'),
(10,N'0-3',N'Nặng',N'LS loại B',N'Vừa'),
(11,N'0-3',N'Nặng',N'LS loại C',N'Cao'),
(12,N'0-3',N'Nặng',N'LS loại D',N'Cao'),
(13,N'3-6',N'Nhẹ',N'LS loại A',N'Thấp'),
(14,N'3-6',N'Nhẹ',N'LS loại B',N'Thấp'),
(15,N'3-6',N'Nhẹ',N'LS loại C',N'Vừa'),
(16,N'3-6',N'Nhẹ',N'LS loại D',N'Cao'),
(17,N'3-6',N'Bình thường',N'LS loại A',N'Thấp'),
(18,N'3-6',N'Bình thường',N'LS loại B',N'Vừa'),
(19,N'3-6',N'Bình thường',N'LS loại C',N'Cao'),
(20,N'3-6',N'Bình thường',N'LS loại D',N'Cao'),
(21,N'3-6',N'Nặng',N'LS loại A',N'Thấp'),
(22,N'3-6',N'Nặng',N'LS loại B',N'Vừa'),
(23,N'3-6',N'Nặng',N'LS loại C',N'Vừa'),
(24,N'3-6',N'Nặng',N'LS loại D',N'Cao'),
(25,N'6-12',N'Nhẹ',N'LS loại A',N'Thấp'),
(26,N'6-12',N'Nhẹ',N'LS loại B',N'Vừa'),
(27,N'6-12',N'Nhẹ',N'LS loại C',N'Vừa'),
(28,N'6-12',N'Nhẹ',N'LS loại D',N'ThCaoấp'),
(29,N'6-12',N'Bình thường',N'LS loại A',N'Thấp'),
(30,N'6-12',N'Bình thường',N'LS loại B',N'Vừa'),
(31,N'6-12',N'Bình thường',N'LS loại C',N'Vừa'),
(32,N'6-12',N'Bình thường',N'LS loại D',N'Cao'),
(33,N'6-12',N'Nặng',N'LS loại A',N'Thấp'),
(34,N'6-12',N'Nặng',N'LS loại B',N'Thấp'),
(35,N'6-12',N'Nặng',N'LS loại C',N'Vừa'),
(36,N'6-12',N'Nặng',N'LS loại D',N'Cao')