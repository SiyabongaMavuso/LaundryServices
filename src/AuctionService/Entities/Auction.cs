using System;
using Microsoft.AspNetCore.Http.Features;

namespace AuctionService.Entities;

public class Auction
{
    public Guid id { get; set; }
    public int ResevePrice { get; set; }
    public string Seller { get; set; }
    public string Winner { get; set; }
    public int? SoldAmount { get; set; }
    public int? CurrentHighBid { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public DateTime AuctionEnd { get; set; }
    public Status Status { get; set; }
    public Item Item { get; set; }
}
