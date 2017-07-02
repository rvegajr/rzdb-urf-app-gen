//------------------------------------------------------------------------------
// <auto-generated>
    //     This code was generated from a template.
    //
    //     Manual changes to this file may cause unexpected behavior in your application.
    //     Manual changes to this file will be overwritten if the code is regenerated.
    //
//  </auto-generated>
//------------------------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;

namespace Tests.RouteTests
{
    [TestClass]
    public class SpecialDealsCoreTests : WebApiTestBaseClass
    {
        [TestMethod]
        public async Task SpecialDealsGetShouldReturnHTTPOk()
        {
            using (var response = await HttpClient.GetAsync("http://testserver/api/SpecialDeals?%24top=10"))
            {
                var result = await response.Content.ReadAsStringAsync();
                Assert.IsTrue(response.StatusCode == HttpStatusCode.OK, "Return Get 10 or less for SpecialDeals");
            }


            using (var response = await HttpClient.GetAsync("http://testserver/api/SpecialDeals?%24expand=BuyingGroup&%24top=10"))
            {
                var result = await response.Content.ReadAsStringAsync();
                Assert.IsTrue(response.StatusCode == HttpStatusCode.OK, "Return Get 10 or less SpecialDeals with Expand of BuyingGroup");
            }

            using (var response = await HttpClient.GetAsync("http://testserver/api/SpecialDeals?%24expand=CustomerCategory&%24top=10"))
            {
                var result = await response.Content.ReadAsStringAsync();
                Assert.IsTrue(response.StatusCode == HttpStatusCode.OK, "Return Get 10 or less SpecialDeals with Expand of CustomerCategory");
            }

            using (var response = await HttpClient.GetAsync("http://testserver/api/SpecialDeals?%24expand=Customer&%24top=10"))
            {
                var result = await response.Content.ReadAsStringAsync();
                Assert.IsTrue(response.StatusCode == HttpStatusCode.OK, "Return Get 10 or less SpecialDeals with Expand of Customer");
            }

            using (var response = await HttpClient.GetAsync("http://testserver/api/SpecialDeals?%24expand=StockGroup&%24top=10"))
            {
                var result = await response.Content.ReadAsStringAsync();
                Assert.IsTrue(response.StatusCode == HttpStatusCode.OK, "Return Get 10 or less SpecialDeals with Expand of StockGroup");
            }

            using (var response = await HttpClient.GetAsync("http://testserver/api/SpecialDeals?%24expand=StockItem&%24top=10"))
            {
                var result = await response.Content.ReadAsStringAsync();
                Assert.IsTrue(response.StatusCode == HttpStatusCode.OK, "Return Get 10 or less SpecialDeals with Expand of StockItem");
            }

            using (var response = await HttpClient.GetAsync("http://testserver/api/SpecialDeals?%24expand=Person&%24top=10"))
            {
                var result = await response.Content.ReadAsStringAsync();
                Assert.IsTrue(response.StatusCode == HttpStatusCode.OK, "Return Get 10 or less SpecialDeals with Expand of Person");
            }
 
        }
    }
}
