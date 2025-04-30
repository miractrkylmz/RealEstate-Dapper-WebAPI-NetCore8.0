namespace RealEstate_Dapper_UI.DTOs.ProductDetailDTOs
{
    public class GetProductDetailByIdDto
    {
        public int productDetailID { get; set; }
        public int bedroomCount { get; set; }
        public int productSize { get; set; }
        public int bathCount { get; set; }
        public int roomCount { get; set; }
        public int garageSize { get; set; }
        public string buildYear { get; set; }
        public decimal price { get; set; }
        public string location { get; set; }
        public string videoUrl { get; set; }
        public DateTime ProductDate { get; set; }
    }
}
