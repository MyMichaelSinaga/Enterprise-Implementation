DROP database kertas
CREATE DATABASE kertas

use kertas
create table t_role
(
	id_role VARCHAR(20) NOT NULL,
	deskripsi_role VARCHAR(50) NOT NULL
	PRIMARY KEY(id_role)
)
create table t_gudang(
	id_gudang VARCHAR(20) NOT NULL,
	deskripsi_gudang VARCHAR(50) NOT NULL,
	total_barang INTEGER NOT NULL,
	PRIMARY KEY(id_gudang)
)

create table t_staff(
	id_username_staff VARCHAR(20) NOT NULL,
	password VARCHAR(20) NOT NULL,
	nama VARCHAR(20) NOT NULL,
	telepon INTEGER NOT NULL,
	id_role VARCHAR(20) NOT NULL,
	PRIMARY KEY(id_username_staff),
	FOREIGN KEY(id_role) REFERENCES t_role(id_role)
)	

create table t_vendor(
	id_username_vendor VARCHAR(20) NOT NULL,
	password VARCHAR(20) NOT NULL,
	nama_pemilik VARCHAR(20) NOT NULL,
	alamat_vendor VARCHAR(100) NOT NULL
	PRIMARY KEY (id_username_vendor)
)

create table t_barang(
	id_barang INTEGER NOT NULL,
	nama_barang VARCHAR(50) NOT NULL,
	harga_per_unit INTEGER NOT NULL,
	stock_barang INTEGER NOT NULL,
	id_username_vendor VARCHAR(20) NOT NULL,
	PRIMARY KEY(id_barang),
	FOREIGN KEY(id_username_vendor) REFERENCES t_vendor(id_username_vendor)
)
create table t_sales_order(
	id_sales_order INTEGER IDENTITY(1,1),
	tanggal DATE NOT NULL,
	nama_pelanggan VARCHAR(20),
	alamat_pelanggan VARCHAR(100),
	telepon_pelanggan VARCHAR(20) NOT NULL,
	jumlah_barang INTEGER NOT NULL,
	total_harga INTEGER NOT NULL,
	status_bayar VARCHAR(50) NOT NULL,
	id_username_staff VARCHAR(20) NOT NULL,
	PRIMARY KEY(id_sales_order),
	FOREIGN KEY(id_username_staff) REFERENCES t_staff(id_username_staff)
)
create table t_produksi(
	id_produksi INTEGER IDENTITY(1,1),
	tanggal DATE NOT NULL,
	jumlah_kertas INTEGER NOT NULL,
	id_username_staff VARCHAR(20) NOT NULL,
	PRIMARY KEY(id_produksi),
	FOREIGN KEY(id_username_staff) REFERENCES t_staff(id_username_staff)
)

create table t_good_issue(
	id_good_issue INTEGER IDENTITY(1,1),
	tanggal DATE NOT NULL,
	deskripsi_good_issue VARCHAR(100) NOT NULL,
	jumlah_barang_keluar INTEGER NOT NULL,
	id_gudang VARCHAR(20),
	id_username_staff VARCHAR(20),
	id_sales_order INTEGER,
	id_produksi INTEGER,
	id_role_tujuan VARCHAR(20),
	PRIMARY KEY(id_good_issue),
	FOREIGN KEY(id_gudang) REFERENCES t_gudang(id_gudang),
	FOREIGN KEY(id_username_staff) REFERENCES t_staff(id_username_staff),
	FOREIGN KEY(id_sales_order) REFERENCES t_sales_order(id_sales_order),
	FOREIGN KEY(id_produksi) REFERENCES t_produksi(id_produksi),
	FOREIGN KEY(id_role_tujuan) REFERENCES t_role(id_role)
)

create table t_purchase_requisition(
	id_purchase_requisition INTEGER IDENTITY(1,1),
	tanggal DATE NOT NULL,
	jumlah_kayu INTEGER NOT NULL,
	id_username_staff VARCHAR(20) NOT NULL,
	PRIMARY KEY(id_purchase_requisition),
	FOREIGN KEY(id_username_staff) REFERENCES t_staff(id_username_staff)
)

create table t_good_receipt(
	id_good_receipt INTEGER IDENTITY(1,1),
	tanggal DATE,
	deskripsi_good_receipt VARCHAR(100) NOT NULL,
	jumlah_barang_masuk INTEGER NOT NULL,
	id_gudang VARCHAR(20) NOT NULL,
	id_username_staff VARCHAR(20) NOT NULL,
	id_role_tujuan VARCHAR(20),
	PRIMARY KEY(id_good_receipt),
	FOREIGN KEY(id_gudang) REFERENCES t_gudang(id_gudang),
	FOREIGN KEY(id_username_staff) REFERENCES t_staff(id_username_staff)	
)

create table t_purchase_order(
	id_purchase_order INTEGER IDENTITY(1,1),
	tanggal DATE NOT NULL,
	jumlah_kayu INTEGER NOT NULL,
	total_harga INTEGER NOT NULL,
	id_purchase_requisition INTEGER NOT NULL,
	id_username_staff VARCHAR(20) NOT NULL,
	id_vendor VARCHAR(20) NOT NULL,
	PRIMARY KEY(id_purchase_order),
	FOREIGN KEY(id_purchase_requisition) REFERENCES t_purchase_requisition(id_purchase_requisition),
	FOREIGN KEY(id_username_staff) REFERENCES t_staff(id_username_staff),
	FOREIGN KEY(id_vendor) REFERENCES t_vendor(id_username_vendor)	
)

create table t_invoice_kayu(
	id_invoice_kayu INTEGER IDENTITY(1,1),
	tanggal DATE NOT NULL,
	deskripsi_invoice_kayu VARCHAR(50) NOT NULL,
	jumlah_kayu INTEGER NOT NULL,
	id_purchase_order INTEGER NOT NULL,
	id_username_vendor VARCHAR(20) NOT NULL,
	id_role_tujuan VARCHAR(20),
	PRIMARY KEY(id_invoice_kayu),
	FOREIGN KEY(id_purchase_order) REFERENCES t_purchase_order(id_purchase_order),
	FOREIGN KEY(id_username_vendor) REFERENCES t_vendor(id_username_vendor)	 
)

create table t_invoice_kertas(
	id_invoice_kertas INTEGER IDENTITY(1,1),
	tanggal DATE NOT NULL,
	deskripsi_invoice_kertas VARCHAR(50) NOT NULL,
	jumlah_kertas INTEGER NOT NULL,
	id_good_issue INTEGER NOT NULL,
	id_username_staff VARCHAR(20) NOT NULL,
	id_role_tujuan VARCHAR(20),
	PRIMARY KEY(id_invoice_kertas),
	FOREIGN KEY(id_good_issue) REFERENCES t_good_issue(id_good_issue),
	FOREIGN KEY(id_username_staff) REFERENCES t_staff(id_username_staff)	 
)
