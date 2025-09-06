using System;
using AuctionService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Data;

public class AuctionDbContext : DbContext
{
  public AuctionDbContext(DbContextOptions options) : base(options)
  {
  }
  public DbSet<Auction> Auctions { get; set; }
  // EF will create a Items DbSet, as Item is related to Auction

}

