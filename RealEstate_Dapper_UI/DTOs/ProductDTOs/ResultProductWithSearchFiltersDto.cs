namespace RealEstate_Dapper_UI.DTOs.ProductDTOs
{
    public class ResultProductWithSearchFiltersDto
    {
        public int id { get; set; }
        public string title { get; set; }
        public decimal price { get; set; }
        public string CoverImage { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public string adress { get; set; }
        public string type { get; set; }
        public string description { get; set; }
        public bool dealOfTheDay { get; set; }
        public string categoryName { get; set; }
        public DateTime ProductDate { get; set; }
    }
}
