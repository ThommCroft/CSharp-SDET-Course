using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPITesting.Tests
{
    public class PetTests
    {
        PetServices _petServices;

        [OneTimeSetUp]
        public async Task OneTimeSetupAsync()
        {
            _petServices = new PetServices();
            await _petServices.MakeGetRequestAsync("9");
        }

        [Test]
        public void GivenAValidPetID_Return200Status()
        {
            Assert.That((int)_petServices.CallManager.Response.StatusCode, Is.EqualTo(200));
        }

        [Test]
        public void GivenAValidPetID_ReturnAvailabilityStatus()
        {
            Assert.That(_petServices.PetDTOResponse.Response.status, Is.EqualTo("sold"));
        }
    }
}
