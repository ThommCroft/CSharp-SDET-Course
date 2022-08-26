using Newtonsoft.Json.Linq;
using System;
using TechTalk.SpecFlow;

namespace WebAPITesting
{
    [Binding]
    public class PetStepDefinitions
    {
        private PetServices _petServices;

        [Given(@"I am a Store User")]
        public void GivenIAmAStoreUser()
        {
            _petServices = new PetServices();
        }

        [When(@"I enter a valid pet ""([^""]*)""")]
        public async Task WhenIEnterAValidPet(string iD)
        {
            await _petServices.MakeGetRequestAsync(iD);
        }

        [Then(@"I should see that pet's ""([^""]*)"", ""([^""]*)"", ""([^""]*)""")]
        public void ThenIShouldSeeThatPets(string name, string categoryName, string availabilityStatus)
        {
            Assert.That(_petServices.PetDTOResponse.Response.name, Is.EqualTo(name));
            Assert.That(_petServices.PetDTOResponse.Response.category.name, Is.EqualTo(categoryName));
            Assert.That(_petServices.PetDTOResponse.Response.status, Is.EqualTo(availabilityStatus));
        }


        [When(@"I enter an invalid pet ""([^""]*)""")]
        public async Task WhenIEnterAnInvalidPet(string iD)
        {
            await _petServices.MakeGetRequestAsync(iD);
        }

        [Then(@"I receive a ""([^""]*)""")]
        public void ThenIReceiveA(int errorStatus)
        {
            Assert.That((int)_petServices.CallManager.Response.StatusCode, Is.EqualTo(errorStatus));
        }

        [Given(@"I am a Worker")]
        public void GivenIAmAWorker()
        {
            throw new PendingStepException();
        }

        [When(@"I create a new pet for the store")]
        public void WhenICreateANewPetForTheStore()
        {
            throw new PendingStepException();
        }

        [Then(@"I can see that pet is available")]
        public void ThenICanSeeThatPetIsAvailable()
        {
            throw new PendingStepException();
        }

        [When(@"I update a pet's details")]
        public void WhenIUpdateAPetsDetails()
        {
            throw new PendingStepException();
        }

        [Then(@"I can see the pet's updated details")]
        public void ThenICanSeeThePetsUpdatedDetails()
        {
            throw new PendingStepException();
        }

        [When(@"I delete a pet from the store by ""([^""]*)""")]
        public void WhenIDeleteAPetFromTheStoreBy(string petid)
        {
            throw new PendingStepException();
        }

        [Then(@"I should not see that pets details")]
        public void ThenIShouldNotSeeThatPetsDetails()
        {
            throw new PendingStepException();
        }
    }
}
