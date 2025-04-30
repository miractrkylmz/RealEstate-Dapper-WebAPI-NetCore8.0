namespace RealEstate_Dapper_API.Tools
{
    public class JwtTokenDefaults
    {
        public const string ValidAudience = "https://localhost";
        public const string ValidIssuer = "https://localhost";
        public const string Key = "realestateaspnetcore8.0dapper+-something";
        public const int Expire = 5;
    }
}
