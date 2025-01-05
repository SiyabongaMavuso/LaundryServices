using System;
using AuctionService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Data;

public class DbInitializer
{
    public static void InitDb(WebApplication app)
    {
        using var scope = app.Services.CreateScope();

        SeedData(scope.ServiceProvider.GetService<AuctionDbContext>());
        
    }

    private static void SeedData(AuctionDbContext context)
    {
        context.Database.Migrate();

        if (context.Auctions.Any())
        {
            Console.WriteLine("Already have data - no need to seed");
            return;
        }

        var auctions = new List<Auction>()
        {
             // 1 Commercial Washing Machine
        new Auction
        {
            id = Guid.NewGuid(),
            ResevePrice = 1500,
            Seller = "LaundryWorld",
            AuctionEnd = DateTime.UtcNow.AddDays(15),
            Status = Status.Live,
            Item = new Item
            {
                Id = Guid.NewGuid(),
                Make = "Speed Queen",
                Model = "SWNMN2SP115TW01",
                Year = 2020,
                Color = "White",
                YearsInUse = 3,
                ImageURL = "https://cdn.pixabay.com/photo/2020/05/17/13/05/washing-machine-5183136_960_720.jpg"
            }
        },
        // 2 Industrial Dryer
        new Auction
        {
            id = Guid.NewGuid(),
            ResevePrice = 2000,
            Seller = "DryPro Services",
            AuctionEnd = DateTime.UtcNow.AddDays(30),
            Status = Status.Live,
            Item = new Item
            {
                Id = Guid.NewGuid(),
                Make = "Huebsch",
                Model = "HT050",
                Year = 2019,
                Color = "Gray",
                YearsInUse = 4,
                ImageURL = "https://cdn.pixabay.com/photo/2016/11/21/16/24/laundry-1849253_960_720.jpg"
            }
        },
        // 3 Laundry Folding Table
        new Auction
        {
            id = Guid.NewGuid(),
            ResevePrice = 500,
            Seller = "ProClean Supplies",
            AuctionEnd = DateTime.UtcNow.AddDays(20),
            Status = Status.Live,
            Item = new Item
            {
                Id = Guid.NewGuid(),
                Make = "Laundry Solutions",
                Model = "FT100",
                Year = 2021,
                Color = "Silver",
                YearsInUse = 2,
                ImageURL = "https://cdn.pixabay.com/photo/2020/02/09/12/59/laundry-4832947_960_720.jpg"
            }
        },
        // 4 Rolling Laundry Cart
        new Auction
        {
            id = Guid.NewGuid(),
            ResevePrice = 250,
            Seller = "LaundryMart",
            AuctionEnd = DateTime.UtcNow.AddDays(10),
            Status = Status.Live,
            Item = new Item
            {
                Id = Guid.NewGuid(),
                Make = "R&B Wire Products",
                Model = "200F",
                Year = 2018,
                Color = "Blue",
                YearsInUse = 5,
                ImageURL = "https://cdn.pixabay.com/photo/2017/07/12/11/54/laundry-2492462_960_720.jpg"
            }
        },
        // 5 Laundry Ironing Press
        new Auction
        {
            id = Guid.NewGuid(),
            ResevePrice = 800,
            Seller = "IronMaster Inc.",
            AuctionEnd = DateTime.UtcNow.AddDays(25),
            Status = Status.Live,
            Item = new Item
            {
                Id = Guid.NewGuid(),
                Make = "Miele",
                Model = "B990",
                Year = 2022,
                Color = "White",
                YearsInUse = 1,
                ImageURL = "https://cdn.pixabay.com/photo/2015/06/24/15/45/ironing-820649_960_720.jpg"
            }
        },
        // 6 Commercial Steam Iron
        new Auction
        {
            id = Guid.NewGuid(),
            ResevePrice = 300,
            Seller = "SteamPress Solutions",
            AuctionEnd = DateTime.UtcNow.AddDays(12),
            Status = Status.Live,
            Item = new Item
            {
                Id = Guid.NewGuid(),
                Make = "Rowenta",
                Model = "DG8520",
                Year = 2021,
                Color = "Black",
                YearsInUse = 2,
                ImageURL = "https://cdn.pixabay.com/photo/2015/06/24/16/00/iron-820653_960_720.jpg"
            }
        },
        // 7 Coin-Operated Washer
        new Auction
        {
            id = Guid.NewGuid(),
            ResevePrice = 2500,
            Seller = "CoinWash Experts",
            AuctionEnd = DateTime.UtcNow.AddDays(18),
            Status = Status.Live,
            Item = new Item
            {
                Id = Guid.NewGuid(),
                Make = "Maytag",
                Model = "MHW5630HC",
                Year = 2020,
                Color = "Silver",
                YearsInUse = 3,
                ImageURL = "https://cdn.pixabay.com/photo/2016/11/21/17/45/laundry-1850072_960_720.jpg"
            }
        },
        // 8 Commercial Laundry Detergent Dispenser
        new Auction
        {
            id = Guid.NewGuid(),
            ResevePrice = 100,
            Seller = "DetergentPro",
            AuctionEnd = DateTime.UtcNow.AddDays(5),
            Status = Status.Live,
            Item = new Item
            {
                Id = Guid.NewGuid(),
                Make = "Procter & Gamble",
                Model = "TidePro500",
                Year = 2023,
                Color = "White",
                YearsInUse = 0,
                ImageURL = "https://cdn.pixabay.com/photo/2020/04/20/20/28/detergent-5071725_960_720.jpg"
            }
        },
        // 9 Laundry Sanitizing Machine
        new Auction
        {
            id = Guid.NewGuid(),
            ResevePrice = 1200,
            Seller = "SanitizationTech",
            AuctionEnd = DateTime.UtcNow.AddDays(22),
            Status = Status.Live,
            Item = new Item
            {
                Id = Guid.NewGuid(),
                Make = "Sanitech",
                Model = "ST500",
                Year = 2021,
                Color = "Gray",
                YearsInUse = 2,
                ImageURL = "https://cdn.pixabay.com/photo/2017/08/07/07/30/washing-machine-2593857_960_720.jpg"
            }
        },
        // 10 Commercial Laundry Basket
        new Auction
        {
            id = Guid.NewGuid(),
            ResevePrice = 80,
            Seller = "LaundryWorld",
            AuctionEnd = DateTime.UtcNow.AddDays(7),
            Status = Status.Live,
            Item = new Item
            {
                Id = Guid.NewGuid(),
                Make = "Rubbermaid",
                Model = "LaundryPro XL",
                Year = 2019,
                Color = "Blue",
                YearsInUse = 4,
                ImageURL = "https://cdn.pixabay.com/photo/2015/10/12/14/56/laundry-984234_960_720.jpg"
            }
        }
        };

        context.AddRange(auctions);

        context.SaveChanges();        
    }
}
