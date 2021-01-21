CREATE TABLE yogrenci(
  OgrId number, 
  OgrAd varchar(25), 
  OgrSoyad varchar(25), 
  OgrTC char(11), 
  OgrTelefon char(10), 
  OgrDogum date, 
  OgrBolumId number, 
  OgrOdaId number, 
  OgrPass varchar(40), 
  OgrVeliAdSoyad varchar(50), 
  OgrVeliTelefon char (10), 
  OgrVeliAdres varchar(100)
);
CREATE TABLE yoklama(
  YokOgrId number, 
  YokId number, 
  YokTarih date
);
CREATE TABLE admin(
  AdminId number, 
  AdminKullanici varchar(25), 
  AdminSifre varchar(40)
);
CREATE TABLE yoda(
  OdaId number, 
  OdaNo char (3), 
  OdaKapasite char (1), 
  OdaDolu char(1)
);
CREATE TABLE ybolumler(
  BolumId number, 
  BolumAd varchar(25)
);
CREATE TABLE yyemek(
  YemekId NVARCHAR2(40), 
  Tarih NVARCHAR2(40), 
  Corba NVARCHAR2(40), 
  AnaYemek NVARCHAR2(40), 
  Tatli NVARCHAR2(40)
);

