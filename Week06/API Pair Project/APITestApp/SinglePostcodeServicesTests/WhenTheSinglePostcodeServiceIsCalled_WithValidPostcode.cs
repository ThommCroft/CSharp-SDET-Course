using APIClientApp.PostcodesIOService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestApp.SinglePostcodeServicesTests
{
    public  class WhenTheSinglePostcodeServiceIsCalled_WithValidPostcode
    {
        SinglePostcodeService _singlePostcodeService;

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            _singlePostcodeService = new SinglePostcodeService();
            await _singlePostcodeService.MakesRequestAsync("EC2Y 5AS");
        }

        [Test]
        public void StatusIs200_InJsonResponseBody()
        {
            Assert.That(_singlePostcodeService.JsonResponse["status"].ToString(), Is.EqualTo("200"));
        }

        [Test]
        public void StatusIs200()
        {
            Assert.That(_singlePostcodeService.GetStatus(), Is.EqualTo(200));
        }

        [Test]
        public void ObjectStatusIs200()
        {
            // SinglePostcodeDTO.Response.status
            Assert.That(_singlePostcodeService.GetSinglePostcodeDTOStatus(), Is.EqualTo(200));
        }

        [Test]
        public void StatusInResponseHeader_SameAsStatusInResponseBody()
        {
            // SinglePostcodeDTO.Response.status
            Assert.That(_singlePostcodeService.GetSinglePostcodeDTOStatus(), Is.EqualTo((int)_singlePostcodeService.CallManager.Response.StatusCode));
        }

        [Test]
        public void AdminDistrict_IsCityOfLondon()
        {
            // SinglePostcodeDTO.Response.result.admin_district
            Assert.That(_singlePostcodeService.GetAdminDistrict(), Is.EqualTo("City of London"));
        }

        [Test]
        public void CorrectPostcodeIsReturned()
        {
            var result = _singlePostcodeService.JsonResponse["result"]["postcode"].ToString();
            Assert.That(result, Is.EqualTo("EC2Y 5AS"));
        }


        [Test]
        public void ContentType_IsJson()
        {
            // CallManager.Response.ContentType
            Assert.That(_singlePostcodeService.GetContentType(), Is.EqualTo("application/json"));
        }

        [Test]
        public void ConnectionIsKeepAlive()
        {
            //var result = _singlePostcodeService.CallManager.Response.Headers.Where(x => x.Name == "Connection").Select(x => x.Value.ToString()).FirstOrDefault();
            //Assert.That(result, Is.EqualTo("keep-alive"));
            Assert.That(_singlePostcodeService.GetHeaders()["Connection"], Is.EqualTo("keep-alive"));
        }

        //[Test]
        //public void AcceptIsThatSymbol()
        //{
        //    Assert.That(_singlePostcodeService.GetHeaders()["Date"], Is.EqualTo(DateTime.Now.ToString($"ddd, dd MMM yyyy hh:mm:ss GMT"))); // Doesn't work properly.
        //}

        [Test]
        public void XGNUIs_MichaelJBlanchard()
        {
            Assert.That(_singlePostcodeService.GetHeaders()["x-gnu"], Is.EqualTo("Michael J Blanchard"));
        }

        [Test]
        public void Server_IsCloudflare()
        {
            Assert.That(_singlePostcodeService.GetHeaders()["Server"], Is.EqualTo("cloudflare"));
        }

        [Test]
        public void NumberOfCodes_IsCorrect()
        {
            // CallManager.Response.ContentType
            Assert.That(_singlePostcodeService.CodeCount(), Is.EqualTo(12));
        }
    }
}
