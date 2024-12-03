using Microsoft.AspNetCore.Identity;
using TechGate.Infrastructure.Data.Models;

namespace TechGate.Infrastructure.Data.SeedDb
{
    internal class SeedData
    {
        public Category HeadPhoneCategory { get; private set; }
        public Category EarBudCategory { get; private set; }
        public Category KeyboardCategory { get; private set; }
        public Category MouseCategory { get; private set; }
        public Category MonitorCategory { get; private set; }
        public Category SpeakerCategory { get; private set; }
        public Category PadCategory { get; private set; }
        public Category GamingChairCategory { get; private set; }



        public Product RazerMouse { get; private set; }
        public Product RazerHeadPhones { get; private set; }
        public Product RazerKeyboard { get; private set; }



        public User QuestOne { get; private set; }
        public User QuestTwo { get; private set; }



        public Order QuestOneOrder { get; private set; }
        public Order QuestTwoOrder { get; private set; }


        public OrderItem OrderItemOne { get; private set; }
        public OrderItem OrderItemTwo { get; private set; }
        public OrderItem OrderItemThree { get; private set; }   


        public Review ReviewOne { get; private set; }

        public Payment PaymentOne { get; private set; }
        public Payment PaymentTwo { get; private set; }


        public SeedData()
        {
            SeedUsers();       // Seed independent users first.
            SeedCategory();    // Seed independent categories.
            SeedProducts();    // Products depend on Categories.
            SeedOrder();       // Orders depend on Users.
            SeedOrderItem();   // OrderItems depend on Orders and Products.
            SeedReview();      // Reviews depend on Products and Users.
            SeedPayment();     // Payments depend on Orders and Users.
        }

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();

            QuestOne = new User()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "peter@gmail.com",
                NormalizedUserName = "PETER@GMAIL.COM",
                Email = "peter@gmail.com",
                NormalizedEmail = "PETER@GMAIL.COM",
                ProfilePictureUrl = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_1280.png",
                Address = "5 Vitosha Boulevard, Sofia",
                DateOfBirth = DateTime.ParseExact("15.01.2001", "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.Now,

            };
            QuestOne.PasswordHash = hasher.HashPassword(QuestOne, "peter123");

            QuestTwo = new User()
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "stoqn@gmail.com",
                NormalizedUserName = "STOQN@GMAIL.COM",
                Email = "stoqn@gmail.com",
                NormalizedEmail = "STOQN@GMAIL.COM",
                ProfilePictureUrl = "https://imgv3.fotor.com/images/blog-cover-image/10-profile-picture-ideas-to-make-you-stand-out.jpg",
                Address = "100 Tsarigradsko Shose Blvd, Sofia",
                DateOfBirth = DateTime.ParseExact("23.11.1999", "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture),
                CreatedAt = DateTime.Now,

            };
            QuestTwo.PasswordHash = hasher.HashPassword(QuestTwo, "stoqn123");

        }
        private void SeedCategory()
        {

            HeadPhoneCategory = new Category
            {
                Id = 1,
                Name = "Headphones"
            };

            EarBudCategory = new Category
            {
                Id = 2,
                Name = "Earbuds"
            };

            KeyboardCategory = new Category
            {
                Id = 3,
                Name = "Keyboards"
            };

            MouseCategory = new Category
            {
                Id = 4,
                Name = "Mice"
            };

            MonitorCategory = new Category
            {
                Id = 5,
                Name = "Monitors"
            };

            SpeakerCategory = new Category
            {
                Id = 6,
                Name = "Speakers"
            };

            PadCategory = new Category
            {
                Id = 7,
                Name = "Mouse Pads"
            };

            GamingChairCategory = new Category
            {
                Id = 8,
                Name = "Gaming Chairs"
            };

        }
        private void SeedProducts()
        {
            RazerMouse = new Product
            {
                Id = 1,
                Name = "Razer DeathAdder V2 Mouse",
                Description = "High-performance ergonomic gaming mouse with optical sensor.",
                Price = 69.99m,
                ImageUrl = "https://pcbuild.bg/assets/products/000/000/285/000000285414--geimarska-mishka-razer-basilisk-v3-pro-ergonomic-wireless-gaming-mouse-rz01-04620100-r3g1.jpg",
                CategoryId = 4,
                AmounInStock = 50
            };

            RazerHeadPhones = new Product
            {
                Id = 2,
                Name = "Razer Kraken Headphones",
                Description = "Stereo gaming headset with superior sound quality and comfort.",
                Price = 99.99m,
                ImageUrl = "https://pcbuild.bg/assets/products/000/000/305/000000305273--geimarski-slushalki-razer-kraken-v3-x-wired-usb-gaming-headset-rz04-03750300-r3m1.jpg",
                CategoryId = 1,
                AmounInStock = 30
            };

            RazerKeyboard = new Product
            {
                Id = 3,
                Name = "Razer BlackWidow V3 Keyboard",
                Description = "Mechanical gaming keyboard with RGB lighting and customizable keys.",
                Price = 129.99m,
                ImageUrl = "https://m.media-amazon.com/images/I/61Az2uOUbqL._AC_UF894,1000_QL80_.jpg",
                CategoryId = 3,
                AmounInStock = 40
            };


        }
        private void SeedOrder()
        {
            QuestOneOrder = new Order
            {
                Id = 1,
                UserId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                OrderDate = DateTime.Now,
                TotalAmount = 69.99m,
                OrderStatus = DataConstants.OrderStatus.Pending,
                ShippingAddress = "5 Vitosha Boulevard, Sofia",
               
            };
            QuestTwoOrder = new Order
            {
                Id = 2,
                UserId = "dea12856-c198-4129-b3f3-b893d8395082",
                OrderDate = DateTime.Now.AddMinutes(-30),
                TotalAmount = 329.97m,
                OrderStatus = DataConstants.OrderStatus.Completed,
                ShippingAddress = "8 Alexander Nevsky Square, Sofia",
              
            };

        }
        private void SeedOrderItem() 
        {
            OrderItemOne = new OrderItem
            {
                Id = 1,
                OrderId = 1,
                ProductId = 1,
                Quantity = 1,
                FinalPrice = 69.99m

            };
            OrderItemTwo = new OrderItem
            {
                Id = 2,
                OrderId = 2,
                ProductId = 2,
                Quantity = 2,
                FinalPrice = 199.98m
            };
            OrderItemThree = new OrderItem
            {
                Id = 3,
                OrderId = 2,
                ProductId = 3,
                Quantity = 1,
                FinalPrice = 129.99m
            };
        }
        private void SeedReview() 
        {
            ReviewOne = new Review
            {
                Id = 1,
                ProductId = 1,
                UserId = "dea12856-c198-4129-b3f3-b893d8395082",
                Rating = 4,
                Comment = "The mouse is great but razer loves installing malware",
                CreatedAt = DateTime.Now,
            };
        }
        private void SeedPayment()
        {
            PaymentOne = new Payment
            {
                Id = 1,
                OrderId= 2,
                UserId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                AmountPaid = 329.97m,
                PaymentDate = DateTime.Now,
                PaymentMethod = DataConstants.PaymentMethod.CreditCard,
                PaymentStatus = DataConstants.PaymentStatus.Completed,

            };
            PaymentTwo = new Payment
            {
                Id = 2,
                OrderId = 1,
                UserId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                AmountPaid = 69.99m,
                PaymentDate = DateTime.Now,
                PaymentMethod= DataConstants.PaymentMethod.CreditCard,
                PaymentStatus= DataConstants.PaymentStatus.Completed,   
            };
        }
      




    }
}
