using System;
using TechTalk.SpecFlow;

namespace WebAPITesting
{
    [Binding]
    public class PetStepDefinitions
    {
        private PetServices _petServices;
        private string _petId;

        [Given(@"I am a Store User")]
        public void GivenIAmAStoreUser()
        {
            _petServices = new PetServices();
        }

        [When(@"I enter a valid pet ""([^""]*)""")]
        public async Task WhenIEnterAValidPet(string iD)
        {
            _petId = iD;
            await _petServices.MakeGetRequestAsync(iD);
        }

        [Then(@"I should see that pet's information")]
        public void ThenIShouldSeeThatPetsInformation()
        {
            //Assert.That(_petServices.Json_Response["responses"].ToString(), Is.EqualTo("200"));
            Assert.That(_petServices.PetDTOResponse.Response.status, Is.EqualTo("available"));
            //Assert.That(_petServices.Json_Response["status"].ToString(), Is.EqualTo("available"));
        }

        [When(@"I enter an invalid pet ""([^""]*)""")]
        public async Task WhenIEnterAnInvalidPet(string iD)
        {
            await _petServices.MakeGetRequestAsync(iD);
        }

        [Then(@"I receive a (.*) error message")]
        public void ThenIReceiveAErrorMessage(int errorNumber)
        {
            Assert.That(_petServices.Json_Response["responses"].ToString(), Is.EqualTo("errorNumber"));
        }

        [When(@"I want to see a pet's valid availability status")]
        public void WhenIWantToSeeAPetsValidAvailabilityStatus()
        {
            throw new PendingStepException();
        }

        [Then(@"I am shown that pet's status")]
        public void ThenIAmShownThatPetsStatus()
        {
            throw new PendingStepException();
        }

        [When(@"I enter an invalid pet's availability status")]
        public void WhenIEnterAnInvalidPetsAvailabilityStatus()
        {
            throw new PendingStepException();
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
