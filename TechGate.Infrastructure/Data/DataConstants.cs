using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGate.Infrastructure.Data.Models;

namespace TechGate.Infrastructure.Data
{
    public static class DataConstants
    {
        public static class Product
        {

            public const int NameMaxLength = 30;
            public const int NameMinLength = 3;

            public const int DescriptionMaxLength = 500;
            public const int DescriptionMinLength = 10; 

            public const string PriceMaxValue= "3000.00";
            public const string PriceMinValue = "0.00";

            public const int ImageUrlMaxLength = 255;  
            public const int ImageUrlMinLength = 7;

            public const int InStocMaxAmount = 100;


        }

        public static class Category
        {
            public const int NameMaxLength = 30;
            public const int NameMinLength = 3;
        }
        public static class Order
        {
            public const string TotalAmountMaxValue = "100000";
            public const string TotalAmountMinValue = "0";

            public const int ShippingAddressMaxLength = 50;
            public const int ShippingAddressMinLength = 10;
         
        }

        public static class Review
        {
            public const int RatingMaxValue = 5;
            public const int RatingMinValue = 1;

            public const int CommentMaxLength = 100;
            public const int CommentMinLength = 3;
        }

        public static class User
        {

            public const int ProfilePictureMaxLength = 255;
            public const int ProfilePictureMinLength = 7;

            public const int AddressMaxLength = 50;
            public const int AddressMinLength = 10;

          
        }
        public enum OrderStatus
        {
            Pending = 0,
            Processed = 1,
            Shipped = 2,
            Delivered = 3,
            Canceled = 4
        }
        public enum PaymentStatus
        {
            Pending = 0,    
            Completed = 1,  
            Failed = 2,     
            Canceled = 3    
        }
        public enum PaymentMethod
        {
            CreditCard = 1,
            PayPal = 2,
            BankTransfer = 3,
            CashOnDelivery = 4
        }
    }
}
