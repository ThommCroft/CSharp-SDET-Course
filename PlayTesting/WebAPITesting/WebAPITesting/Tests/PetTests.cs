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
            await _petServices.MakeGetRequestAsync("456");
        }

        [Test]
        public void GivenAnInvalidPetID_ReturnErrorStatus()
        {
            //Assert.That(_petServices.PetDTOResponse.Response.status, Is.EqualTo("400"));
            Assert.That(_petServices.Json_Response["responses"].ToString(), Is.EqualTo("400"));
        }
    }
}
