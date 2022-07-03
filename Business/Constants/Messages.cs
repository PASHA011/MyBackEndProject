using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{

    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductsListed = "Ürğnler listelendi";
        internal static string MaintenanceTime = "sistem bakımda";

        public static string ProductCountOfCategryError = "Bu kategory için ürün sayısını aştınız";

        public static string CategoriseCountOfCategryError = "Kategory Sayısı 15'i aştığı için ürün eklenemez";

        public static string KategoriseListed = "Ürünler listelendi";

        public static string AuthorizationDenied = "Yetkiniz YOOK";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string UserRegistered = "kayıt oldu";
    }
}
