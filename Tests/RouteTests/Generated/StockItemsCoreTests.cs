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
    public class StockItemsCoreTests : WebApiTestBaseClass
    {
        [TestMethod]
        public async Task StockItemsGetShouldReturnHTTPOk()
        {
            using (var response = await HttpClient.GetAsync("http://testserver/api/StockItems?%24top=10"))
            {
                var result = await response.Content.ReadAsStringAsync();
                Assert.IsTrue(response.StatusCode == HttpStatusCode.OK, "Return Get 10 or less for StockItems");
            }


            using (var response = await HttpClient.GetAsync("http://testserver/api/StockItems?%24expand=Supplier&%24top=10"))
            {
                var result = await response.Content.ReadAsStringAsync();
                Assert.IsTrue(response.StatusCode == HttpStatusCode.OK, "Return Get 10 or less StockItems with Expand of Supplier");
            }

            using (var response = await HttpClient.GetAsync("http://testserver/api/StockItems?%24expand=Color&%24top=10"))
            {
                var result = await response.Content.ReadAsStringAsync();
                Assert.IsTrue(response.StatusCode == HttpStatusCode.OK, "Return Get 10 or less StockItems with Expand of Color");
            }

            using (var response = await HttpClient.GetAsync("http://testserver/api/StockItems?%24expand=Person&%24top=10"))
            {
                var result = await response.Content.ReadAsStringAsync();
                Assert.IsTrue(response.StatusCode == HttpStatusCode.OK, "Return Get 10 or less StockItems with Expand of Person");
            }

            using (var response = await HttpClient.GetAsync("http://testserver/api/StockItems?%24expand=OuterPackageID&%24top=10"))
            {
                var result = await response.Content.ReadAsStringAsync();
                Assert.IsTrue(response.StatusCode == HttpStatusCode.OK, "Return Get 10 or less StockItems with Expand of OuterPackageID");
            }

            using (var response = await HttpClient.GetAsync("http://testserver/api/StockItems?%24expand=UnitPackageID&%24top=10"))
            {
                var result = await response.Content.ReadAsStringAsync();
                Assert.IsTrue(response.StatusCode == HttpStatusCode.OK, "Return Get 10 or less StockItems with Expand of UnitPackageID");
            }
 
        }
    }
}