using System;
using System.ComponentModel.DataAnnotations;

namespace AuctionService.DTOs;

public class CreateAuctionDto
{   
    [Required]
    public string Make { get; set; }

    [Required]
    public string Model { get; set; }

    [Required]
    public int Year { get; set; }

    [Required]
    public string Color { get; set; }

    [Required]
    public int YearsInUse { get; set; }

    [Required]
    public string ImageURL { get; set; }

    [Required]
    public int ResevePrice { get; set; }
    
    [Required]
    public DateTime AuctionEnd { get; set; }

}
