namespace WebApplication1.Service
{
    public class BNPService : IBNPService
    {
        public BNPService() {
        }
        public Task<string> FetchPrices(string isin)
        {
            Uri url = new Uri($"https://securities.dataprovider.com/securityprice/{isin}");
            HttpClient client = new HttpClient();
            try
            {
                var dataRes = client.GetAsync(url);

                return dataRes.Result.Content.ReadAsStringAsync();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
