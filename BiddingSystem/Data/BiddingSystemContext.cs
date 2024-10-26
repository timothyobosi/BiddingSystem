using Microsoft.EntityFrameworkCore;
using BiddingSystem.Models;

namespace BiddingSystem.Data
{
    public class BiddingSystemContext : DbContext
    {
        public BiddingSystemContext(DbContextOptions<BiddingSystemContext> options) : base(options)
        {
        }

        public DbSet<AuctionItem> AuctionItems { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<User> Users { get; set; }

       
    }
}