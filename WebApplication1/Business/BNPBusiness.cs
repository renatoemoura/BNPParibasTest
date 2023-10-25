using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Service;

namespace WebApplication1.Business
{
    public class BNPBusiness : IBNPBusiness
    {
        private readonly IBNPData _BNPData;
        private readonly IBNPService _bNPService;

        public BNPBusiness(IBNPService bNPService,
                           IBNPData bNPData) {
            _bNPService = bNPService;
            _BNPData = bNPData;
        }

        public bool PrepareData(IEnumerable<string> isins)
        {
            if (isins != null || isins.Count() > 0)
            {
                foreach(var isin in isins)
                {
                    // find price ISIN
                    var data = new DataModel
                    {   
                        isin = isin,
                        price = Double.Parse(_bNPService.FetchPrices(isin))
                };


                    // Storage prices finded
                    _BNPData.SaveData(data);
                }
                return true;
            }
            else 
            {
                return false; 
            }
        }
    }
}
