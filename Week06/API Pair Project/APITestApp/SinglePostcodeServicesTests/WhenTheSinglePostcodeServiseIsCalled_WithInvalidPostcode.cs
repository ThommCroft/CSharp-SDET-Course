using APIClientApp.PostcodesIOService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestApp.SinglePostcodeServicesTests
{
    public class WhenTheSinglePostcodeServiseIsCalled_WithInvalidPostcode
    {
        SinglePostcodeService _singlePostcodeService;

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            _singlePostcodeService = new SinglePostcodeService();
            await _singlePostcodeService.MakesRequestAsync("EC2Y");
        }

        [Test]
        public void StatusIs404_InJsonResponse()
        {
            Assert.That(_singlePostcodeService.JsonResponse["status"].ToString(), Is.EqualTo("404"));
        }

        [Test]
        public void StatusIs404()
        {
            Assert.That(_singlePostcodeService.GetStatus(), Is.EqualTo(404));
        }

        [Test]
        public void ObjectStatusIs404()
        {
            Assert.That(_singlePostcodeService.GetSinglePostcodeDTOStatus(), Is.EqualTo(404));
        }

        [Test]
        public void StatusInResponseHeader_SameAsResponseBody()
        {
            Assert.That(_singlePostcodeService.GetSinglePostcodeDTOStatus(), Is.EqualTo(_singlePostcodeService.SinglePostcodeDTO.Response.status));
        }
    }
}
