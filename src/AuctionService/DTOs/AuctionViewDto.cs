﻿namespace AuctionService.DTOs;

public class AuctionViewDto
{
    public Guid Id { get; set; }
    public string Seller { get; set; } = null!;
    public string? Winner { get; set; }
    public decimal ReservePrice { get; set; }
    public int? SoldAmount { get; set; }
    public int? CurrentHigBid { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Updated { get; set; }
    public DateTime? AuctionEnded { get; set; }
    public string Status { get; set; } = null!;
    
    public string Model { get; set; } = null!;
    public string Manufacturer { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Type { get; set; } = null!;
    public string? SerialNumber { get; set; }
    public int Year { get; set; }
    public string Color { get; set; } = null!;
    public string? ImageUrl { get; set; }
}