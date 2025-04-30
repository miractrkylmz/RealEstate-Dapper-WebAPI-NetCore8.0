namespace RealEstate_Dapper_API.DTOs.ProductDTOs
{
    public class GetProductDetailByProductIdDto
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string CoverImage { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Adress { get; set; }
        public string SlugUrl { get; set; }
        public string Type { get; set; }
        public bool DealOfTheDay { get; set; }
        public string CategoryName { get; set; }
        public DateTime ProductDate { get; set; }
    }
}
