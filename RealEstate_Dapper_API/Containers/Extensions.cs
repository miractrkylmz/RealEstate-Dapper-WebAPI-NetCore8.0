using RealEstate_Dapper_API.Models.DapperContext;
using RealEstate_Dapper_API.Repositories.AppUserRepositories;
using RealEstate_Dapper_API.Repositories.BottomGridRepositories;
using RealEstate_Dapper_API.Repositories.CategoryRepository;
using RealEstate_Dapper_API.Repositories.ContactRepositories;
using RealEstate_Dapper_API.Repositories.EmployeeRepositories;
using RealEstate_Dapper_API.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories;
using RealEstate_Dapper_API.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories;
using RealEstate_Dapper_API.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticRepositories;
using RealEstate_Dapper_API.Repositories.MessageRepositories;
using RealEstate_Dapper_API.Repositories.PopularLocationRepositories;
using RealEstate_Dapper_API.Repositories.ProductImageRepositories;
using RealEstate_Dapper_API.Repositories.ProductRepository;
using RealEstate_Dapper_API.Repositories.PropertyAmenityRepositories;
using RealEstate_Dapper_API.Repositories.ServiceRepository;
using RealEstate_Dapper_API.Repositories.StatisticsRepositories;
using RealEstate_Dapper_API.Repositories.SubFeatureRepositories;
using RealEstate_Dapper_API.Repositories.TestimonialRepository;
using RealEstate_Dapper_API.Repositories.ToDoListRepositories;
using RealEstate_Dapper_API.Repositories.WhoWeAreRepository;

namespace RealEstate_Dapper_API.Containers
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddTransient<Context>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IWhoWeAreRepository, WhoWeAreRepository>();
            services.AddTransient<IServiceRepository, ServiceRepository>();
            services.AddTransient<IBottomGridRepository, BottomGridRepository>();
            services.AddTransient<IPopularLocationRepostiory, PopularLocationRepository>();
            services.AddTransient<ITestimonialRepository, TestimonialRepository>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IStatisticsRepository, StatisticsRepository>();
            services.AddTransient<IContactRepository, ContactRepository>();
            services.AddTransient<IToDoListRepository, ToDoListRepository>();
            services.AddTransient<IStatisticRepository, StatisticRepository>();
            services.AddTransient<IChartRepository, ChartRepository>();
            services.AddTransient<ILast5ProductRepository, Last5ProductRepository>();
            services.AddTransient<IMessageRepository, MessageRepository>();
            services.AddTransient<IProductImageRepository, ProductImageRepository>();
            services.AddTransient<IAppUserRepository, AppUserRepository>();
            services.AddTransient<IPropertyAmenityRepository, PropertyAmenityRepository>();
            services.AddTransient<ISubFeatureRepository, SubFeatureRepository>();
        }
    }
}
