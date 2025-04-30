namespace RealEstate_Dapper_API.DTOs.ProductDTOs
{
    public class CreateProductDto
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string coverImage { get; set; }
        public string adress { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public bool dealoftheday { get; set; }
        public DateTime productdate { get; set; }
        public bool productstatus { get; set; }
        public int employeeID { get; set; }
        public int productCategory { get; set; }

    }
}
