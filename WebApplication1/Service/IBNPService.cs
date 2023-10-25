namespace WebApplication1.Service
{
    public interface IBNPService
    {
        Task<string> FetchPrices(string isin);
    }
}
