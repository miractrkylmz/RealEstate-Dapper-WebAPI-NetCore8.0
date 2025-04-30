namespace RealEstate_Dapper_API.Repositories.StatisticsRepositories
{
    public interface IStatisticsRepository
    {
        int CategoryCount();
        int ActiveCategoryCount();
        int PassiveCategoryCount();
        int ProductCount();
        int ApartmantCount();
        string EmployeeNameByMaxProductCount();
        string CategoryNameByMaxProductCount();
        decimal AvgProductPriceByRent();
        decimal AvgProductPriceBySale();
        string CityNameByMaxProductCount();
        int DifferentCities();
        decimal LastProductPrice();
        string NewestBuildingYear();
        string OldestBuildingYear();
        int AvgRoomCount();
        int ActiveEmployeeCount();
    }
}
