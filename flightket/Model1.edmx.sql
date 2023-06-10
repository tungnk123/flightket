
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/02/2023 00:27:02
-- Generated from EDMX file: D:\flightket\flightket\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [FlightKetDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__BAOCAOTHA__MaBCN__7D439ABD]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BAOCAOTHANGs] DROP CONSTRAINT [FK__BAOCAOTHA__MaBCN__7D439ABD];
GO
IF OBJECT_ID(N'[dbo].[FK__CT_BCTHAN__MaBCT__08B54D69]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CT_BCTHANG] DROP CONSTRAINT [FK__CT_BCTHAN__MaBCT__08B54D69];
GO
IF OBJECT_ID(N'[dbo].[FK__CHUYENBAY__MaSan__5EBF139D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CHUYENBAYs] DROP CONSTRAINT [FK__CHUYENBAY__MaSan__5EBF139D];
GO
IF OBJECT_ID(N'[dbo].[FK__CHUYENBAY__MaSan__5FB337D6]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CHUYENBAYs] DROP CONSTRAINT [FK__CHUYENBAY__MaSan__5FB337D6];
GO
IF OBJECT_ID(N'[dbo].[FK__CT_BCTHAN__MaChu__09A971A2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CT_BCTHANG] DROP CONSTRAINT [FK__CT_BCTHAN__MaChu__09A971A2];
GO
IF OBJECT_ID(N'[dbo].[FK__CT_CHUYEN__MaChu__628FA481]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CT_CHUYENBAY] DROP CONSTRAINT [FK__CT_CHUYEN__MaChu__628FA481];
GO
IF OBJECT_ID(N'[dbo].[FK__CT_HANGVE__MaChu__70DDC3D8]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CT_HANGVE] DROP CONSTRAINT [FK__CT_HANGVE__MaChu__70DDC3D8];
GO
IF OBJECT_ID(N'[dbo].[FK__PHIEUDATC__MaChu__74AE54BC]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PHIEUDATCHOes] DROP CONSTRAINT [FK__PHIEUDATC__MaChu__74AE54BC];
GO
IF OBJECT_ID(N'[dbo].[FK__VECHUYENB__MaChu__6C190EBB]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VECHUYENBAYs] DROP CONSTRAINT [FK__VECHUYENB__MaChu__6C190EBB];
GO
IF OBJECT_ID(N'[dbo].[FK__CT_CHUYEN__MaSan__6383C8BA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CT_CHUYENBAY] DROP CONSTRAINT [FK__CT_CHUYEN__MaSan__6383C8BA];
GO
IF OBJECT_ID(N'[dbo].[FK__CT_HANGVE__MaHan__71D1E811]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CT_HANGVE] DROP CONSTRAINT [FK__CT_HANGVE__MaHan__71D1E811];
GO
IF OBJECT_ID(N'[dbo].[FK__PHIEUDATC__MaHan__76969D2E]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PHIEUDATCHOes] DROP CONSTRAINT [FK__PHIEUDATC__MaHan__76969D2E];
GO
IF OBJECT_ID(N'[dbo].[FK__VECHUYENB__MaHan__6E01572D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VECHUYENBAYs] DROP CONSTRAINT [FK__VECHUYENB__MaHan__6E01572D];
GO
IF OBJECT_ID(N'[dbo].[FK__PHIEUDATC__MaHan__75A278F5]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PHIEUDATCHOes] DROP CONSTRAINT [FK__PHIEUDATC__MaHan__75A278F5];
GO
IF OBJECT_ID(N'[dbo].[FK__VECHUYENB__MaHan__6D0D32F4]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VECHUYENBAYs] DROP CONSTRAINT [FK__VECHUYENB__MaHan__6D0D32F4];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[BAOCAONAMs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BAOCAONAMs];
GO
IF OBJECT_ID(N'[dbo].[BAOCAOTHANGs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BAOCAOTHANGs];
GO
IF OBJECT_ID(N'[dbo].[CHUYENBAYs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CHUYENBAYs];
GO
IF OBJECT_ID(N'[dbo].[CT_BCTHANG]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CT_BCTHANG];
GO
IF OBJECT_ID(N'[dbo].[CT_CHUYENBAY]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CT_CHUYENBAY];
GO
IF OBJECT_ID(N'[dbo].[CT_HANGVE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CT_HANGVE];
GO
IF OBJECT_ID(N'[dbo].[HANGVEs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HANGVEs];
GO
IF OBJECT_ID(N'[dbo].[HANHKHACHes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HANHKHACHes];
GO
IF OBJECT_ID(N'[dbo].[NHANVIENs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NHANVIENs];
GO
IF OBJECT_ID(N'[dbo].[PHIEUDATCHOes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PHIEUDATCHOes];
GO
IF OBJECT_ID(N'[dbo].[SANBAYs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SANBAYs];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[THAMSOes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[THAMSOes];
GO
IF OBJECT_ID(N'[dbo].[VECHUYENBAYs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VECHUYENBAYs];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'BAOCAONAMs'
CREATE TABLE [dbo].[BAOCAONAMs] (
    [MaBCNam] char(5)  NOT NULL,
    [Nam] smallint  NULL,
    [TongDoanhThu] float  NULL
);
GO

-- Creating table 'BAOCAOTHANGs'
CREATE TABLE [dbo].[BAOCAOTHANGs] (
    [MaBCThang] char(5)  NOT NULL,
    [MaBCNam] char(5)  NULL,
    [Thang] smallint  NULL,
    [Nam] smallint  NULL,
    [TongDoanhThuThang] float  NULL,
    [TongChuyenBay] smallint  NULL,
    [TiLe] float  NULL
);
GO

-- Creating table 'CHUYENBAYs'
CREATE TABLE [dbo].[CHUYENBAYs] (
    [MaChuyenBay] char(5)  NOT NULL,
    [MaSanBayDi] char(5)  NULL,
    [MaSanBayDen] char(5)  NULL,
    [NgayGioKhoiHanh] datetime  NULL,
    [ThoiGianBay] smallint  NULL,
    [GiaVe] float  NULL
);
GO

-- Creating table 'CT_BCTHANG'
CREATE TABLE [dbo].[CT_BCTHANG] (
    [MaBCThang] char(5)  NOT NULL,
    [MaChuyenBay] char(5)  NOT NULL,
    [SoVe] smallint  NULL,
    [DoanhThu] float  NULL,
    [TiLe] float  NULL
);
GO

-- Creating table 'CT_CHUYENBAY'
CREATE TABLE [dbo].[CT_CHUYENBAY] (
    [MaCTCB] int IDENTITY(1,1) NOT NULL,
    [MaChuyenBay] char(5)  NULL,
    [MaSanBayTrungGian] char(5)  NULL,
    [ThoiGianDung] smallint  NULL,
    [GhiChu] nvarchar(1)  NULL
);
GO

-- Creating table 'CT_HANGVE'
CREATE TABLE [dbo].[CT_HANGVE] (
    [MaChuyenBay] char(5)  NOT NULL,
    [MaHangVe] char(5)  NOT NULL,
    [SoLuongGhe] smallint  NULL
);
GO

-- Creating table 'HANGVEs'
CREATE TABLE [dbo].[HANGVEs] (
    [MaHangVe] char(5)  NOT NULL,
    [TenHangVe] nvarchar(1)  NULL,
    [TiLeDonGia] tinyint  NULL
);
GO

-- Creating table 'HANHKHACHes'
CREATE TABLE [dbo].[HANHKHACHes] (
    [MaHanhKhach] char(5)  NOT NULL,
    [TenHanhKhach] nvarchar(max)  NULL,
    [GioiTinh] nchar(1)  NULL,
    [NgaySinh] datetime  NULL,
    [CMND] char(12)  NULL,
    [SDT] char(10)  NULL
);
GO

-- Creating table 'NHANVIENs'
CREATE TABLE [dbo].[NHANVIENs] (
    [MaNhanVien] char(5)  NOT NULL,
    [HoTen] nvarchar(1)  NULL,
    [NamSinh] datetime  NULL,
    [DiaChi] nvarchar(1)  NULL,
    [SDT] char(10)  NULL,
    [UserName] nvarchar(1)  NULL,
    [PassWord] nvarchar(1)  NULL,
    [Role] nvarchar(1)  NULL
);
GO

-- Creating table 'PHIEUDATCHOes'
CREATE TABLE [dbo].[PHIEUDATCHOes] (
    [MaPhieuDatCho] int IDENTITY(1,1) NOT NULL,
    [MaChuyenBay] char(5)  NULL,
    [MaHanhKhach] char(5)  NULL,
    [MaHangVe] char(5)  NULL,
    [GiaTien] float  NULL
);
GO

-- Creating table 'SANBAYs'
CREATE TABLE [dbo].[SANBAYs] (
    [MaSanBay] char(5)  NOT NULL,
    [TenSanBay] nvarchar(1)  NULL,
    [QuocGia] nvarchar(1)  NULL,
    [DiaChi] nvarchar(1)  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'THAMSOes'
CREATE TABLE [dbo].[THAMSOes] (
    [ID] int  NOT NULL,
    [ThoiGianBayToiThieu] smallint  NULL,
    [SoSanBayTrungGianToiDa] smallint  NULL,
    [ThoiGianDungToiThieu] smallint  NULL,
    [ThoiGianDungToiDa] smallint  NULL,
    [SoThoiGianDatVeTruocKhoiHanh] smallint  NULL,
    [SoGioHuyPhieuTruocKhoiHanh] smallint  NULL
);
GO

-- Creating table 'VECHUYENBAYs'
CREATE TABLE [dbo].[VECHUYENBAYs] (
    [MaVe] int IDENTITY(1,1) NOT NULL,
    [MaChuyenBay] char(5)  NULL,
    [MaHanhKhach] char(5)  NULL,
    [MaHangVe] char(5)  NULL,
    [GiaTien] float  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [MaBCNam] in table 'BAOCAONAMs'
ALTER TABLE [dbo].[BAOCAONAMs]
ADD CONSTRAINT [PK_BAOCAONAMs]
    PRIMARY KEY CLUSTERED ([MaBCNam] ASC);
GO

-- Creating primary key on [MaBCThang] in table 'BAOCAOTHANGs'
ALTER TABLE [dbo].[BAOCAOTHANGs]
ADD CONSTRAINT [PK_BAOCAOTHANGs]
    PRIMARY KEY CLUSTERED ([MaBCThang] ASC);
GO

-- Creating primary key on [MaChuyenBay] in table 'CHUYENBAYs'
ALTER TABLE [dbo].[CHUYENBAYs]
ADD CONSTRAINT [PK_CHUYENBAYs]
    PRIMARY KEY CLUSTERED ([MaChuyenBay] ASC);
GO

-- Creating primary key on [MaBCThang], [MaChuyenBay] in table 'CT_BCTHANG'
ALTER TABLE [dbo].[CT_BCTHANG]
ADD CONSTRAINT [PK_CT_BCTHANG]
    PRIMARY KEY CLUSTERED ([MaBCThang], [MaChuyenBay] ASC);
GO

-- Creating primary key on [MaCTCB] in table 'CT_CHUYENBAY'
ALTER TABLE [dbo].[CT_CHUYENBAY]
ADD CONSTRAINT [PK_CT_CHUYENBAY]
    PRIMARY KEY CLUSTERED ([MaCTCB] ASC);
GO

-- Creating primary key on [MaChuyenBay], [MaHangVe] in table 'CT_HANGVE'
ALTER TABLE [dbo].[CT_HANGVE]
ADD CONSTRAINT [PK_CT_HANGVE]
    PRIMARY KEY CLUSTERED ([MaChuyenBay], [MaHangVe] ASC);
GO

-- Creating primary key on [MaHangVe] in table 'HANGVEs'
ALTER TABLE [dbo].[HANGVEs]
ADD CONSTRAINT [PK_HANGVEs]
    PRIMARY KEY CLUSTERED ([MaHangVe] ASC);
GO

-- Creating primary key on [MaHanhKhach] in table 'HANHKHACHes'
ALTER TABLE [dbo].[HANHKHACHes]
ADD CONSTRAINT [PK_HANHKHACHes]
    PRIMARY KEY CLUSTERED ([MaHanhKhach] ASC);
GO

-- Creating primary key on [MaNhanVien] in table 'NHANVIENs'
ALTER TABLE [dbo].[NHANVIENs]
ADD CONSTRAINT [PK_NHANVIENs]
    PRIMARY KEY CLUSTERED ([MaNhanVien] ASC);
GO

-- Creating primary key on [MaPhieuDatCho] in table 'PHIEUDATCHOes'
ALTER TABLE [dbo].[PHIEUDATCHOes]
ADD CONSTRAINT [PK_PHIEUDATCHOes]
    PRIMARY KEY CLUSTERED ([MaPhieuDatCho] ASC);
GO

-- Creating primary key on [MaSanBay] in table 'SANBAYs'
ALTER TABLE [dbo].[SANBAYs]
ADD CONSTRAINT [PK_SANBAYs]
    PRIMARY KEY CLUSTERED ([MaSanBay] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [ID] in table 'THAMSOes'
ALTER TABLE [dbo].[THAMSOes]
ADD CONSTRAINT [PK_THAMSOes]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [MaVe] in table 'VECHUYENBAYs'
ALTER TABLE [dbo].[VECHUYENBAYs]
ADD CONSTRAINT [PK_VECHUYENBAYs]
    PRIMARY KEY CLUSTERED ([MaVe] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MaBCNam] in table 'BAOCAOTHANGs'
ALTER TABLE [dbo].[BAOCAOTHANGs]
ADD CONSTRAINT [FK__BAOCAOTHA__MaBCN__7D439ABD]
    FOREIGN KEY ([MaBCNam])
    REFERENCES [dbo].[BAOCAONAMs]
        ([MaBCNam])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__BAOCAOTHA__MaBCN__7D439ABD'
CREATE INDEX [IX_FK__BAOCAOTHA__MaBCN__7D439ABD]
ON [dbo].[BAOCAOTHANGs]
    ([MaBCNam]);
GO

-- Creating foreign key on [MaBCThang] in table 'CT_BCTHANG'
ALTER TABLE [dbo].[CT_BCTHANG]
ADD CONSTRAINT [FK__CT_BCTHAN__MaBCT__08B54D69]
    FOREIGN KEY ([MaBCThang])
    REFERENCES [dbo].[BAOCAOTHANGs]
        ([MaBCThang])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [MaSanBayDi] in table 'CHUYENBAYs'
ALTER TABLE [dbo].[CHUYENBAYs]
ADD CONSTRAINT [FK__CHUYENBAY__MaSan__5EBF139D]
    FOREIGN KEY ([MaSanBayDi])
    REFERENCES [dbo].[SANBAYs]
        ([MaSanBay])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CHUYENBAY__MaSan__5EBF139D'
CREATE INDEX [IX_FK__CHUYENBAY__MaSan__5EBF139D]
ON [dbo].[CHUYENBAYs]
    ([MaSanBayDi]);
GO

-- Creating foreign key on [MaSanBayDen] in table 'CHUYENBAYs'
ALTER TABLE [dbo].[CHUYENBAYs]
ADD CONSTRAINT [FK__CHUYENBAY__MaSan__5FB337D6]
    FOREIGN KEY ([MaSanBayDen])
    REFERENCES [dbo].[SANBAYs]
        ([MaSanBay])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CHUYENBAY__MaSan__5FB337D6'
CREATE INDEX [IX_FK__CHUYENBAY__MaSan__5FB337D6]
ON [dbo].[CHUYENBAYs]
    ([MaSanBayDen]);
GO

-- Creating foreign key on [MaChuyenBay] in table 'CT_BCTHANG'
ALTER TABLE [dbo].[CT_BCTHANG]
ADD CONSTRAINT [FK__CT_BCTHAN__MaChu__09A971A2]
    FOREIGN KEY ([MaChuyenBay])
    REFERENCES [dbo].[CHUYENBAYs]
        ([MaChuyenBay])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CT_BCTHAN__MaChu__09A971A2'
CREATE INDEX [IX_FK__CT_BCTHAN__MaChu__09A971A2]
ON [dbo].[CT_BCTHANG]
    ([MaChuyenBay]);
GO

-- Creating foreign key on [MaChuyenBay] in table 'CT_CHUYENBAY'
ALTER TABLE [dbo].[CT_CHUYENBAY]
ADD CONSTRAINT [FK__CT_CHUYEN__MaChu__628FA481]
    FOREIGN KEY ([MaChuyenBay])
    REFERENCES [dbo].[CHUYENBAYs]
        ([MaChuyenBay])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CT_CHUYEN__MaChu__628FA481'
CREATE INDEX [IX_FK__CT_CHUYEN__MaChu__628FA481]
ON [dbo].[CT_CHUYENBAY]
    ([MaChuyenBay]);
GO

-- Creating foreign key on [MaChuyenBay] in table 'CT_HANGVE'
ALTER TABLE [dbo].[CT_HANGVE]
ADD CONSTRAINT [FK__CT_HANGVE__MaChu__70DDC3D8]
    FOREIGN KEY ([MaChuyenBay])
    REFERENCES [dbo].[CHUYENBAYs]
        ([MaChuyenBay])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [MaChuyenBay] in table 'PHIEUDATCHOes'
ALTER TABLE [dbo].[PHIEUDATCHOes]
ADD CONSTRAINT [FK__PHIEUDATC__MaChu__74AE54BC]
    FOREIGN KEY ([MaChuyenBay])
    REFERENCES [dbo].[CHUYENBAYs]
        ([MaChuyenBay])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__PHIEUDATC__MaChu__74AE54BC'
CREATE INDEX [IX_FK__PHIEUDATC__MaChu__74AE54BC]
ON [dbo].[PHIEUDATCHOes]
    ([MaChuyenBay]);
GO

-- Creating foreign key on [MaChuyenBay] in table 'VECHUYENBAYs'
ALTER TABLE [dbo].[VECHUYENBAYs]
ADD CONSTRAINT [FK__VECHUYENB__MaChu__6C190EBB]
    FOREIGN KEY ([MaChuyenBay])
    REFERENCES [dbo].[CHUYENBAYs]
        ([MaChuyenBay])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__VECHUYENB__MaChu__6C190EBB'
CREATE INDEX [IX_FK__VECHUYENB__MaChu__6C190EBB]
ON [dbo].[VECHUYENBAYs]
    ([MaChuyenBay]);
GO

-- Creating foreign key on [MaSanBayTrungGian] in table 'CT_CHUYENBAY'
ALTER TABLE [dbo].[CT_CHUYENBAY]
ADD CONSTRAINT [FK__CT_CHUYEN__MaSan__6383C8BA]
    FOREIGN KEY ([MaSanBayTrungGian])
    REFERENCES [dbo].[SANBAYs]
        ([MaSanBay])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CT_CHUYEN__MaSan__6383C8BA'
CREATE INDEX [IX_FK__CT_CHUYEN__MaSan__6383C8BA]
ON [dbo].[CT_CHUYENBAY]
    ([MaSanBayTrungGian]);
GO

-- Creating foreign key on [MaHangVe] in table 'CT_HANGVE'
ALTER TABLE [dbo].[CT_HANGVE]
ADD CONSTRAINT [FK__CT_HANGVE__MaHan__71D1E811]
    FOREIGN KEY ([MaHangVe])
    REFERENCES [dbo].[HANGVEs]
        ([MaHangVe])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CT_HANGVE__MaHan__71D1E811'
CREATE INDEX [IX_FK__CT_HANGVE__MaHan__71D1E811]
ON [dbo].[CT_HANGVE]
    ([MaHangVe]);
GO

-- Creating foreign key on [MaHangVe] in table 'PHIEUDATCHOes'
ALTER TABLE [dbo].[PHIEUDATCHOes]
ADD CONSTRAINT [FK__PHIEUDATC__MaHan__76969D2E]
    FOREIGN KEY ([MaHangVe])
    REFERENCES [dbo].[HANGVEs]
        ([MaHangVe])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__PHIEUDATC__MaHan__76969D2E'
CREATE INDEX [IX_FK__PHIEUDATC__MaHan__76969D2E]
ON [dbo].[PHIEUDATCHOes]
    ([MaHangVe]);
GO

-- Creating foreign key on [MaHangVe] in table 'VECHUYENBAYs'
ALTER TABLE [dbo].[VECHUYENBAYs]
ADD CONSTRAINT [FK__VECHUYENB__MaHan__6E01572D]
    FOREIGN KEY ([MaHangVe])
    REFERENCES [dbo].[HANGVEs]
        ([MaHangVe])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__VECHUYENB__MaHan__6E01572D'
CREATE INDEX [IX_FK__VECHUYENB__MaHan__6E01572D]
ON [dbo].[VECHUYENBAYs]
    ([MaHangVe]);
GO

-- Creating foreign key on [MaHanhKhach] in table 'PHIEUDATCHOes'
ALTER TABLE [dbo].[PHIEUDATCHOes]
ADD CONSTRAINT [FK__PHIEUDATC__MaHan__75A278F5]
    FOREIGN KEY ([MaHanhKhach])
    REFERENCES [dbo].[HANHKHACHes]
        ([MaHanhKhach])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__PHIEUDATC__MaHan__75A278F5'
CREATE INDEX [IX_FK__PHIEUDATC__MaHan__75A278F5]
ON [dbo].[PHIEUDATCHOes]
    ([MaHanhKhach]);
GO

-- Creating foreign key on [MaHanhKhach] in table 'VECHUYENBAYs'
ALTER TABLE [dbo].[VECHUYENBAYs]
ADD CONSTRAINT [FK__VECHUYENB__MaHan__6D0D32F4]
    FOREIGN KEY ([MaHanhKhach])
    REFERENCES [dbo].[HANHKHACHes]
        ([MaHanhKhach])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__VECHUYENB__MaHan__6D0D32F4'
CREATE INDEX [IX_FK__VECHUYENB__MaHan__6D0D32F4]
ON [dbo].[VECHUYENBAYs]
    ([MaHanhKhach]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------