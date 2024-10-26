using Microsoft.EntityFrameworkCore;
using BiddingSystem.Models;

namespace BiddingSystem.Data
{
    public class BiddingSystemContext : DbContext
    {
        public BiddingSystemContext(DbContextOptions<BiddingSystemContext> options) : base(options)
        {
        }

       
    }
}