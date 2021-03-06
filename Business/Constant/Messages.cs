﻿using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constant
{
    public class Messages
    {
        public static string CarAdded = "Car Eklendi";
        public static string CarUpdated = "Araç Güncellendi";
        public static string CarDeleted = "Araç Silindi";
        public static string CarDidntAdded = "Araç açıklaması en az 3 karakter olmalı";

        public static string ColorAdded = "Color Eklendi";
        public static string ColorUpdated = "Color Güncellendi";
        public static string ColorDeleted = "Color Silindi";

        public static string BrandAdded = "Color Eklendi";
        public static string BrandUpdated = "Brand Güncellendi";
        public static string BrandDeleted = "Color Silindi";

    

        public static string CustomerAdded = "Müsteri Eklendi";
        public static string CustomerDeleted = "Müsteri Silindi";
        public static string CustomerUpdated = "Müsteri Güncellendi";

        public static string UserAdded = "Müsteri Eklendi";
        public static string UserDeleted = "Müsteri Silindi";
        public static string UserUpdated = "Müsteri Güncellendi";

        public static string RentalUnavailable = "Araba meşgul";
        public static string NoRecord = "Böle bir kayıt yok";
        public static string RentalAdded = "Araç Kiralandı (Rental tablosuna eklendi)";
        public static string RentalDeleted = "Araç Rentaldan Silindi.";
        public static string RentalUpdated = "Güncellendi";

        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Sifre hatalı";
        public static string SuccesfulLogin = "Sisteme Giriş Başarılı";
        public static string UserAlreadyExist = "Kullanıcı Mevcut";
        public static string UserRegistered = "Kullanıcı basarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token basarıyla olusturuldu";
        public static string AuthorizationDenied = "Yetkiniz yok"; 
    }
}
