namespace BiddingSystem.Models
{
    public class Bid
    {
        public int Id { get; set; }
        public int AutionItemId {  get; set; }
        public AuctionItem AuctionItem { get; set; }
        public int UserId {  get; set; }
        public User User { get; set; }

        public decimal Amount {  get; set; }
        public DateTime BidDate { get; set; }
    }
}
