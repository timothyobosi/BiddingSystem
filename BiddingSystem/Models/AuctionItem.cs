namespace BiddingSystem.Models
{
    public class AuctionItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal StartingBid {  get; set; }
        public DateTime EndDate { get; set; }
    }
}
