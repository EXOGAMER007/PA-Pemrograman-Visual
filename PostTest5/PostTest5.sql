CREATE SCHEMA PeminjamanPT5;

USE PeminjamanPT5;

CREATE TABLE tbPeminjaman (
    kode CHAR(3) PRIMARY KEY,
    Nama VARCHAR(50),
    Jumlah int,
    Alamat varchar(100),
    Nomor bigInt,
    Tanggal varchar(50),
    Foto Varchar(200)
);

CREATE TABLE tbnote (
	Note text,
    id varchar(45) Primary key
);