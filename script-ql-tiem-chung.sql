create database if not exists ql_tiem_chung;
use ql_tiem_chung;

create table khach_hang
(
	makh int auto_increment,
    tenkh nvarchar(30),
    ngaysinh date,
    diachi nvarchar(50),
    gioitinh nvarchar(5),
    sdt varchar(10) not null,
    khuser varchar(30) not null,
    
    constraint pk_khach_hang primary key(makh)
);

create table tai_khoan
(
	username varchar(30) not null,
    password varchar(30) not null,
    quyen int default 0,
    
    constraint pk_tai_khoan primary key(username)
);

create table nhan_vien
(
	manv int auto_increment,
    tennv nvarchar(30),
    diachi nvarchar(50),
    ngaysinh date,
    email varchar(20) not null,
    sdt varchar(10) not null,
    trungtamlamviec nvarchar(30),
    bangcap nvarchar(20),
    luong bigint,
    nvuser varchar(30),
    
    constraint pk_nhan_vien primary key(manv)
);

create table y_bac_si
(
	mabs int,
    
    constraint pk_y_bac_si primary key(mabs)
);

create table nv_yte
(
	manvyt int,
    
    constraint pk_nvyte primary key(manvyt)
);

create table nv_ketoan
(
	manvkt int,
    
    constraint pk_nvketoan primary key(manvkt)
);

create table ca_lam_viec
(
	ca int,
    ngay date,
    loaica varchar(10),
    
    constraint pk_ca_lam_viec primary key(ca, ngay)
);

create table nv_ca
(
	canv int,
    ngaynv date,
    nvca int,
    
    constraint pk_nv_ca primary key(canv, ngaynv, nvca)
);

create table tien_trinh_tiem
(
	matt int auto_increment,
    madktiem int,
    
    constraint pk_tien_trinh_tiem primary key(matt)
);

create table kham
(
	mattkham int,
    trangthai nvarchar(20) not null,
    bskham int,
    
    constraint pk_kham primary key(mattkham)
);

create table tiem
(
	matttiem int,
    trangthai nvarchar(20) not null,
    ysitiem int,
    
    constraint pk_tiem primary key(matttiem)
);

create table  theo_doi
(
	matttd int,
    trangthai nvarchar(20) not null,
    nvtheodoi int,
    
    constraint pk_theo_doi primary key(matttd)
);

create table dich_vu
(
	madv int auto_increment,
    diachi_ndk nvarchar(20),
    gioitinh_ndk nvarchar(5),
    sdt_ndk varchar(10) not null,
    ngaysinh_ndk date,
    ngaydk date not null,
    hddv int,
    khdv int,
    
    constraint pk_dich_vu primary key(madv)
);

create table don_dk_tiem
(
	madktiem int auto_increment,
    tennguoitiem nvarchar(30),
    ngaymuontiem date,
    magoidk int,
    gia bigint,
    
    constraint pk_don_dk_tiem primary key(madktiem)
);

create table hoa_don
(
	mahd int auto_increment,
    tongtien bigint not null,
    trangthaithanhtoan varchar(20) not null,
    nvlap int,
    
    constraint pk_hoa_don primary key(mahd)
);

create table benh_nen
(
	mabenh int auto_increment,
    tenbenh nvarchar(30) not null,
    
    constraint pk_benh_nen primary key(mabenh)
);

create table benh_nen_dv
(
	mabenh_dv int,
    ma_dvdk int,
    
    constraint pk_benh_nen_dv primary key(mabenh_dv, ma_dvdk)
);

create table don_dat_mua
(
	madatmua int,
    tennguoidat nvarchar(30),
    
    constraint pk_don_dat_mau primary key(madatmua)
);

create table ct_dat_mua
(
	datmua int,
    vaccine varchar(10),
    soluong int not null,
    dongia bigint not null,
    
    constraint pk_ct_dat_mua primary key(datmua)
);

create table goi_tiem
(
	magoi int auto_increment,
    doituong nvarchar(30),
    gia bigint not null,
    vaccine varchar(10),
    
    constraint pk_goi_tiem primary key(magoi)
);

create table vaccine
(
	mavaccine varchar(10),
    tenvaccine nvarchar(30),
    hsd date not null,
    ncc_vaccine int,
    gia bigint,
    
    constraint pk_vaccine primary key(mavaccine)
);

create table nha_cung_cap
(
	mancc int auto_increment,
    tenncc nvarchar(30),
    email varchar(20) not null,
    sdt varchar(10) not null,
    quocgia nvarchar(20),
    
    constraint pk_nha_cung_cap primary key(mancc)
);

alter table khach_hang
add constraint fk_khach_hang foreign key(khuser) references tai_khoan(username);

alter table nhan_vien
add constraint fk_nhan_vien foreign key(nvuser) references tai_khoan(username);

alter table y_bac_si
add constraint fk_y_bac_si foreign key(mabs) references nhan_vien(manv);

alter table nv_yte
add constraint fk_nvyte foreign key(manvyt) references nhan_vien(manv);

alter table nv_ca
add constraint fk_nv_ca_ca foreign key(canv, ngaynv) references ca_lam_viec(ca, ngay),
add constraint fk_nv_ca_nv foreign key(nvca) references nhan_vien(manv);

alter table nv_ketoan
add constraint fk_nv_ketoan foreign key(manvkt) references nhan_vien(manv);

alter table tien_trinh_tiem
add constraint fk_tien_trinh_tiem foreign key(madktiem) references don_dk_tiem(madktiem);

alter table kham
add constraint fk_kham_tien_trinh foreign key(mattkham) references tien_trinh_tiem(matt),
add constraint fk_kham_y_bac_si foreign key(bskham) references y_bac_si(mabs);

alter table tiem
add constraint fk_tiem_tien_trinh foreign key(matttiem) references tien_trinh_tiem(matt),
add constraint fk_tiem_y_bac_si foreign key(ysitiem) references y_bac_si(mabs);

alter table theo_doi
add constraint fk_theo_doi_tien_trinh foreign key(matttd) references tien_trinh_tiem(matt),
add constraint fk_theo_doi_nvyte foreign key(nvtheodoi) references nv_yte(manvyt);

alter table dich_vu
add constraint fk_dich_vu_hoa_don foreign key(hddv) references hoa_don(mahd),
add constraint fk_dich_vu_khach_hang foreign key(khdv) references khach_hang(makh);

alter table don_dk_tiem
add constraint fk_don_dk_tiem_goi_dk foreign key(magoidk) references goi_tiem(magoi),
add constraint fk_don_dk_tiem_dich_vu foreign key(madktiem) references dich_vu(madv);

alter table hoa_don
add constraint fk_hoa_don foreign key(nvlap) references nv_ketoan(manvkt);

alter table benh_nen_dv
add constraint fk_benh_nen_dv_benh_nen foreign key(mabenh_dv) references benh_nen(mabenh),
add constraint fk_benh_nen_dv_dv foreign key(ma_dvdk) references don_dk_tiem(madktiem);

alter table don_dat_mua
add constraint fk_don_dat_mua foreign key(madatmua) references dich_vu(madv);

alter table goi_tiem
add constraint fk_goi_tiem foreign key(vaccine) references vaccine(mavaccine);

alter table vaccine
add constraint fk_vaccine foreign key(ncc_vaccine) references nha_cung_cap(mancc);

alter table ct_dat_mua
add constraint fk_ct_dat_mua_don_dat_mua foreign key(datmua) references don_dat_mua(madatmua),
add constraint fk_ct_dat_mua_vaccine foreign key(vaccine) references vaccine(mavaccine);

insert into tai_khoan(username, password) value
('khachhang1', '123456'),
('khachhang2', '123456');
insert into tai_khoan(username, password, quyen) value
('ybacsi1', '123456', 3),
('ybacsi2', '123456', 3),
('yte1', '123456', 2),
('yte2', '123456', 2),
('ketoan1', '123456', 1),
('ketoan2', '123456', 1);

insert into khach_hang(tenkh, ngaysinh, diachi, gioitinh, sdt, khuser) value
('Khách Hàng 1', '20010110', 'Quận 1, HCM', 'Nam', '0123456789', 'khachhang1'),
('Khách Hàng 2', '20031110', 'Quận 1, HCM', 'Nử', '0111222333', 'khachhang2');

insert into nhan_vien(tennv, diachi, ngaysinh, email, sdt, trungtamlamviec, bangcap, luong, nvuser) value
('Y Bác Sĩ 1', 'Quận 1, HCM', '20010101', 'ybacsi1@gmail.com', '012346789', null, null, 5000000, 'ybacsi1'),
('Y Bác Sĩ 2', 'Quận 1, HCM', '20010101', 'ybacsi2@gmail.com', '012346789', null, null, 5000000, 'ybacsi2'),
('Y Tế 1', 'Quận 1, HCM', '20010101', 'yte1@gmail.com', '012346789', null, null, 5000000, 'yte1'),
('Y Tế 2', 'Quận 1, HCM', '20010101', 'yte2@gmail.com', '012346789', null, null, 5000000, 'yte2'),
('Kế Toán 1', 'Quận 1, HCM', '20010101', 'ketoan1@gmail.com', '012346789', null, null, 5000000, 'ketoan1'),
('Kế Toán 2', 'Quận 1, HCM', '20010101', 'ketoan2@gmail.com', '012346789', null, null, 5000000, 'ketoan2');

insert into y_bac_si(mabs) value
(1),
(2);

insert into nv_yte(manvyt) value
(3),
(4);

insert into nv_ketoan value
(5),
(6);

insert into nha_cung_cap(tenncc, email, sdt, quocgia) value
('Pfizer company', 'pfizer@gmail.com', '012456789', 'USA'),
('Astra company', 'astra@gmail.com', '0111222333', 'England');

insert into vaccine(mavaccine, tenvaccine, hsd, ncc_vaccine, gia) value
('PFI', 'Pfizer', '20250101', 1, 250000),
('AST', 'Astra Zeneca', '20250101', 2, 200000);

insert into goi_tiem(doituong, gia, vaccine) value
('Trẻ em', 100000, 'AST'),
('Trẻ em', 150000, 'PFI'),
('Người lớn', 200000, 'AST'),
('Người lớn', 250000, 'PFI'),
('Người già', 500000, 'AST'),
('Người già', 550000, 'PFI');

	


