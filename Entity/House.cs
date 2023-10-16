
namespace Entity
{
    internal class House
    {
        public int Id { get;}

        public HouseType HouseType { get; set; }
        public string? Description { get; set; }  
        public decimal Price { get; set; }
        public int RoomsCount { get; set; }
        public int BathroomsCount { get; set; }
        public double SquareFeet { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime LastUpdated { get; set; }
        public int OwnerId { get; set; }
        
        public List<string>? Images;
        public virtual ClientOwner? Owner { get; set; }

      //  public int ClientId { get; set; }
      //  public virtual IEnumerable<ClientOwner> Clients { get; set; }

        public int HouseLocationId { get; set; }
        public virtual Location? HouseLocation { get; set; }


        public virtual ICollection<Scoring> Scoring { get; set; }

        public int TranslationId { get; set; }
        public virtual Translation? HouseTranslation { get; set; }

        public House(
            HouseType houseType,
            string? description,
            decimal price,
            int roomsCount, 
            int bathroomsCount, 
            double squareFeet,
            bool isAvailable, 
            DateTime lastUpdated, 
            int ownerId,
            int translationId,
            int houseLocationId

            )
        {
            this.Price = price;
            this.RoomsCount = roomsCount;
            this.BathroomsCount = bathroomsCount;
            this.SquareFeet = squareFeet;
            this.IsAvailable = isAvailable;
            this.LastUpdated = lastUpdated;
            this.TranslationId = translationId;
            this.OwnerId = ownerId;
            this.HouseType = houseType;
            this.HouseLocationId = houseLocationId;
            this.Description = description;

            this.Scoring = new List<Scoring>();

        }
    }
}
