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
    public class StockGroupsCoreTests : WebApiTestBaseClass
    {
        [TestMethod]
        public async Task StockGroupsGetShouldReturnHTTPOk()
        {
            using (var response = await HttpClient.GetAsync("http://testserver/api/StockGroups?%24top=10"))
            {
                var result = await response.Content.ReadAsStringAsync();
                Assert.IsTrue(response.StatusCode == HttpStatusCode.OK, "Return Get 10 or less for StockGroups");
            }


            using (var response = await HttpClient.GetAsync("http://testserver/api/StockGroups?%24expand=Person&%24top=10"))
            {
                var result = await response.Content.ReadAsStringAsync();
                Assert.IsTrue(response.StatusCode == HttpStatusCode.OK, "Return Get 10 or less StockGroups with Expand of Person");
            }
 
        }
    }
}
