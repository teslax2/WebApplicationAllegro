using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Threading.Tasks;
using WebApplication1.Api;
using WebApplication1.Api.Requests;
using Xunit;

namespace WebApplication1.Tests.Api
{
    public class AllegroApiTest
    {
        [Fact]
        public async Task Login_ShouldReturnToken()
        {
            //Prepare
            var allegroApi = new AllegroApi(NullLoggerFactory.Instance);
            var requestLogin = new RequestLogin(Endpoints.URLAuth, Endpoints.Login, "fc475aa8dfe4424fb1507bebea59c924", "jWo1K9tKptPaIza31ByS3WxE678FHJxK7dsFinXFxJD1rgoypuTz8LmuBEmHoLQa");
            //Execute
            var token = await allegroApi.Login(requestLogin);
            //Assert
            Assert.NotNull(token);
            Assert.NotNull(token.access_token);
        }

        [Fact]
        public async Task Offers_ShouldReturnOffer()
        {
            //Prepare
            var allegroApi = new AllegroApi(NullLoggerFactory.Instance);
            string token = "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJzY29wZSI6WyJhbGxlZ3JvX2FwaSJdLCJleHAiOjE1Njk0NTUyNjcsImp0aSI6ImI2ZjVjZDQ2LTY3ZjYtNDM1MC04MDhiLTdlOGNmYTM5NThiMSIsImNsaWVudF9pZCI6ImZjNDc1YWE4ZGZlNDQyNGZiMTUwN2JlYmVhNTljOTI0In0.wkKM1xb4wb7YIFtll0pFYHUbAxDOGgRqHRPpMKKjZvCw-4SS1f_in6kAWPURebivN1DW6JtXQQGdGLTX7hBW1mzDDzECWJlKhVm7KW01kyap4URPZEuS1KBGVF5zvfzfBzbTUPeAPugY0mO6Brhd-FdIxBMJ3wNf24WK3bxxAbPMggQOV0tZWLFe3Gb6hSRZz4U97k8HdA2Vlnduq62zlFROPxY7p0GbGnm5PKpnAI2PZTPlMHx-5Ge5dwvcEMV6g091-QjvN9QjxKnWLdMhcbN4AXqj91GhZID164kCfr09Nk2Q3hGTYKrPn3OHWEwoBWskEl2P-MEmDz2Hztq_YA";
            var requestOffer = new RequestOffers(Endpoints.URL, token, "xiaomi");
            //Execute
            var offers = await allegroApi.Offers(requestOffer);
            //Assert
            Assert.NotNull(offers);
        }

    }
}
