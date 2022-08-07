using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestApp.SinglePostcodeServicesTests
{
    public class WhenTheSinglePostcodeServiceIsCalled_WithValidPostcode
    {
        SinglePostcodeService _singlePostcodeService;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            _singlePostcodeService = new SinglePostcodeService();
            await _singlePostcodeService.MakeRequestAsync("EC2Y 5AS");
        }

        [Test]
        public void StatusIs200_InJsonResponse()
        {
            Assert.That(_singlePostcodeService.ResponseContent["status"].ToString(), Is.EqualTo("200"));
        }

        [Test]
        public void StatusIs200()
        {
            Assert.That(_singlePostcodeService.GetStatusCode(), Is.EqualTo(200));
        }

        [Test]
        public void ObjectStatusIs200()
        {
            Assert.That(_singlePostcodeService.ResponseObject.Status, Is.EqualTo(200));
        }

        [Test]
        public void StatusInResponseHeader_SameAsResponseBody()
        {
            var bodyResponseCode = _singlePostcodeService.ResponseContent["status"].ToString();
            var bodyResponseInt = Int32.Parse(bodyResponseCode.ToString());

            Assert.That(_singlePostcodeService.GetStatusCode(), Is.EqualTo(bodyResponseInt));
        }
    }
}
