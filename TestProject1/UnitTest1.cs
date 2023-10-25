
using WebApplication1.Business;
using WebApplication1.Data;
using WebApplication1.Service;

namespace TestProject1
{
    public class UnitTest1
    {

        [Fact]
        public void PrepareDataTestSucess()
        {
            var a = new BNPService();
            var b = new BNPData();
            var testBusiness = new BNPBusiness(a, b);
            var input = new List<string>();
            input.Add("12");
            input.Add("131");
            input.Add("1441");

            Assert.True(testBusiness.PrepareData(input));
        }

        [Fact]
        public void PrepareDataTestFail()
        {
            var a = new BNPService();
            var b = new BNPData();
            var testBusiness = new BNPBusiness(a, b);
            var input = new List<string>();

            Assert.False(testBusiness.PrepareData(input));
        }

        [Fact]
        public void PrepareDataTestValidation()
        {
            var a = new BNPService();
            var b = new BNPData();
            var testBusiness = new BNPBusiness(a, b);
            var inputA = new List<string>();
            inputA.Add("12");
            inputA.Add("131");
            inputA.Add("1441");
            var inputB = new List<string>();
            inputB.Add("15");
            inputB.Add("161");
            inputB.Add("1771");

            Assert.Equal(testBusiness.PrepareData(inputA), testBusiness.PrepareData(inputB));
        }

    }
}