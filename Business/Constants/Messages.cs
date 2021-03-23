using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba Eklendi";
        public static string CarDeleted = "Araba Bilgileri Silindi";
        public static string CarUpdated = "Araba Bilgileri Güncellendi";
        public static string CarNameInvalid = "Araba ismi için en az 2 karakter girilmeli ve Günlük fiyat 0 TL üzeri olmalı.";

        public static string ColorAdded = "Araba Rengi Eklendi";
        public static string ColorDeleted = "Araba Rengi Silindi";
        public static string ColorUpdated = "Araba Rengi Güncellendi";

        public static string BrandAdded = "Araba Markası Eklendi";
        public static string BrandDeleted = "Araba Markası Silindi";
        public static string BrandUpdated = "Araba Markası Güncellendi";

        public static string MaintenanceTime = "Sistem Bakımda";
        public static string CarsListed = "Arabalar Listelendi";
        public static string BrandsListed = "Araba Markaları Listelendi";
        public static string ColorsListed = "Araba Renkleri Listelendi";

        public static string CustomerAdded = "Müşteri Bilgileri Eklendi.";
        public static string CustomerDeleted = "Müşteri Bilgileri Silindi";
        public static string CustomerUpdated = "Müşteri Bilgileri Güncellendi";

        public static string UserAdded = "Kullanıcı Bilgileri Eklendi";
        public static string UserDeleted = "Kullanıcı Bilgileri Silindi";
        public static string UserUpdated = "Kullanıcı Bilgileri Güncellendi";

        public static string RentalAdded = "Kiralama Bilgileri Eklendi";
        public static string RentalDeleted = "Kiralama Bilgileri Silindi";
        public static string RentalUpdated = "Kiralama Bilgileri Güncellendi";
        public static string RentalInvalid = "Kiralamak İstediğiniz Araç Teslim Edilmediği İçin Kiralayamazsınız!";
        public static string RentalReturned = "Kiraladığınız Araç Teslim Edildi";
        public static string RentalListed = "Kiralık Araçlar Listelendi";

        public static string FailedCarImageAdd="Bir araba 5 ten fazla resme sahip olamaz!";
        public static string AddedCarImage="Araba resmi eklendi";
        public static string DeletedCarImage = "Arabanın resmi silindi.";
        public static string UpdatedCarImage = "Araba resmi  güncellendi.";

        public static string CarCountOfBrandError = "Araç Modeli Olarak en fazla on araba olabilir";
        public static string CarNameAlreadyExists = "Bu isimde araba mevcut";

        public static string AuthorizationDenied="Yetkiniz Yok";
        public static string UserRegistered="Kayıt oldu";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin = "Başarılı Giriş";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Token Oluşturuldu";
    }
}
