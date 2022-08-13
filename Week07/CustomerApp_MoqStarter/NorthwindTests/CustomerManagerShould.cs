using NUnit.Framework;
using Moq;
using NorthwindBusiness;
using NorthwindData;
using NorthwindData.Services;
using System.Data;
using System.Collections.Generic;

namespace NorthwindTests
{
    public class CustomerManagerShould
    {
        private CustomerManager _sut;

        //Fakes - In memory database (not covered in lesson)

        #region Moq as Dummy
        [Test]
        [Category("Moq as Dummy")]
        [Ignore("Meant to Fail")]
        public void BeAbleToBeConstructed()
        {
            // Act
            _sut = new CustomerManager(null);

            Assert.That(_sut, Is.InstanceOf<CustomerManager>());
        }

        [Test]
        [Category("Moq as Dummy")]
        public void BeAbleToBeConstructed_WithMoq()
        {
            // Use Moq to create a dummy object which implements ICustomerService

            //Arrange
            var mockCustomerService = new Mock<ICustomerService>();

            //Act - Retrieve the ICustomerService object associated with the Mock
                    // Mock.Object - Does not do anything as it has no functionality
            _sut = new CustomerManager(mockCustomerService.Object);

            //Assert
            Assert.That(_sut, Is.InstanceOf<CustomerManager>());
        }
        #endregion

        #region Stubs
        // Need to create a test double for implmenting the ICustomerService interface and then configure it to return our desired values
        [Test]
        [Category("Stubs")]
        public void ReturnTrue_WhenUpdateIsCalled_WithValidID()
        {
            //Arrange
            var mockCustomerService = new Mock<ICustomerService>();

            var customer = new Customer { CustomerId = "Manda"};

            // Set up the service so it returns what I want
            mockCustomerService.Setup(cs => cs.GetCustomerById("Manda")).Returns(customer);

            //Act
            _sut = new CustomerManager(mockCustomerService.Object);
            var result = _sut.Update("Manda", It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());

            //Assert
            Assert.That(result);
        }

        [Test]
        [Category("Stubs")]
        public void NotChangeTheSelectedCustomer_WhenUpdateIsCalled_WithInvaidID()
        {
            //Arrange
            var mockCustomerService = new Mock<ICustomerService>();

            var customer = new Customer { CustomerId = "Manda", ContactName = "Nish Mandal", CompanyName = "Sparta Global", City = "Birmingham" };
            
            // Set up the service so it returns what I want
            mockCustomerService.Setup(cs => cs.GetCustomerById("Manda")).Returns((Customer)null);
            
            //Act
            _sut = new CustomerManager(mockCustomerService.Object);
            _sut.SelectedCustomer = customer;
            var result = _sut.Update("Manda", "Nish Mandal", "UK", "Birmingham", null);

            //Assert
            Assert.That(!result);
            Assert.That(_sut.SelectedCustomer.ContactName, Is.EqualTo("Nish Mandal"));
            Assert.That(_sut.SelectedCustomer.CompanyName, Is.EqualTo("Sparta Global"));
            Assert.That(_sut.SelectedCustomer.Country, Is.Null);
            Assert.That(_sut.SelectedCustomer.City, Is.EqualTo("Birmingham"));
        }

        [Test]
        [Category("Stubs")]
        public void ReturnTrue_WhenDeleteisCalled_WithValidID()
        {
            //Arrange
            var mockCustomerService = new Mock<ICustomerService>();

            var customer = new Customer { CustomerId = "Tom" };

            // Set up the service so it returns what I want
            mockCustomerService.Setup(cs => cs.GetCustomerById("Tom")).Returns(customer);

            //Act
            _sut = new CustomerManager(mockCustomerService.Object);
            _sut.SelectedCustomer = customer;
            var result = _sut.Delete("Tom");

            //Assert
            Assert.That(result);
        }

        [Test]
        [Category("Stubs")]
        public void SetSelectedCustomerToNull_WhenDeleteIsCalledWithValidId()
        {
            //Arrange
            var mockCustomerService = new Mock<ICustomerService>();

            var customer = new Customer { CustomerId = "Tom" };

            // Set up the service so it returns what I want
            mockCustomerService.Setup(cs => cs.GetCustomerById("Tom")).Returns(customer);

            //Act
            _sut = new CustomerManager(mockCustomerService.Object);
            _sut.SelectedCustomer = customer;

            _sut.Delete("Tom");

            //Assert
            Assert.That(_sut.SelectedCustomer, Is.Null);
        }

        [Test]
        [Category("Stubs")]
        public void ReturnFalse_WhenDeleteIsCalled_WithInvalidId()
        {
            //Arrange
            var mockCustomerService = new Mock<ICustomerService>();

            //var customer = new Customer { CustomerId = "Tom" };
            //mockCustomerService.Setup(cs => cs.GetCustomerById("Tom")).Returns(customer);

            //Act
            _sut = new CustomerManager(mockCustomerService.Object);

            var result = _sut.Delete("Invalid Customer ID");

            //Assert
            Assert.That(!result);
        }

        [Test]
        [Category("Stubs")]
        public void NotChangeTheSelectedCustomer_WhenDeleteIsCalled_WithInvalidId()
        {
            //Arrange
            var mockCustomerService = new Mock<ICustomerService>();

            var customer = new Customer { CustomerId = "Manda", ContactName = "Nish Mandal", CompanyName = "Sparta Global", City = "Birmingham" };

            // Set up the service so it returns what I want
            mockCustomerService.Setup(cs => cs.GetCustomerById("Manda")).Returns((Customer)null);

            //Act
            _sut = new CustomerManager(mockCustomerService.Object);
            _sut.SelectedCustomer = customer;
            var result = _sut.Delete("Manda");

            //Assert
            Assert.That(_sut.SelectedCustomer, Is.Not.Null);
            Assert.That(!result);
            Assert.That(_sut.SelectedCustomer.ContactName, Is.EqualTo("Nish Mandal"));
            Assert.That(_sut.SelectedCustomer.CompanyName, Is.EqualTo("Sparta Global"));
            Assert.That(_sut.SelectedCustomer.Country, Is.Null);
            Assert.That(_sut.SelectedCustomer.City, Is.EqualTo("Birmingham"));
        }
        #endregion

        #region Behaviour Based (Spy)
        [Test]
        [Category("Behaviour-based")]
        public void CallSaveCustomerChanges_WhenUpdateIscalled_WithValidID()
        {
            // Arrange
            var mockCustomerService = new Mock<ICustomerService>();
            mockCustomerService.Setup(cs => cs.GetCustomerById(It.IsAny<string>())).Returns(new Customer());

            _sut = new CustomerManager(mockCustomerService.Object);

            // Act
            var result = _sut.Update("WOLST", It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());

            // Calling the update method in the CustomerManager class, called the SavesCustomer method once.

            // Assert
            mockCustomerService.Verify(cs => cs.SaveCustomerChanges(), Times.Once);
        }

        [Test]
        [Category("Behaviour-based")]
        public void Behaviours_LooseVSStrict() 
        {
            // Arrange
            var mockCustomerService = new Mock<ICustomerService>(MockBehavior.Loose);
            mockCustomerService.Setup(cs => cs.GetCustomerById(It.IsAny<string>())).Returns(new Customer());

            mockCustomerService.Setup(cs => cs.SaveCustomerChanges()); // STRICK: all methods within the method under test must have the behaviour set up

            _sut = new CustomerManager(mockCustomerService.Object);

            // Act
            var result = _sut.Update("WOLST", It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());

            // Assert
            Assert.That(result);
        }
        #endregion

        #region Testing Exceptions
        [Test]
        [Category("Exceptions")]
        public void ReturnFalse_WhenUpdateIsCalled_AndADatabaseExceptionIsThrown()
        {

            // Arrange
            var mockCustomerService = new Mock<ICustomerService>();
            mockCustomerService.Setup(cs => cs.GetCustomerById(It.IsAny<string>())).Returns(new Customer());
            mockCustomerService.Setup(cs => cs.SaveCustomerChanges()).Throws<DataException>();

            _sut = new CustomerManager(mockCustomerService.Object);

            //Act
            var result = _sut.Update("WOLST", It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());

            //Assert
            Assert.That(!result);
        }

        [Test]
        [Category("Exceptions")]
        public void ReturnFalse_WhenUpdateIsCalled_AndDatabaseExceptionIsThrown()
        {

            // Arrange
            var mockCustomerService = new Mock<ICustomerService>();
            mockCustomerService.Setup(cs => cs.GetCustomerById(It.IsAny<string>())).Returns(new Customer());
            mockCustomerService.Setup(cs => cs.SaveCustomerChanges()).Throws<DataException>();

            var originalCustomer = new Customer()
            {
                CustomerId = "ROCK",
                ContactName = "Rocky Raccoon",
                CompanyName = "Zoo UK",
                City = "Telford"

            };

            _sut = new CustomerManager(mockCustomerService.Object);
            _sut.SelectedCustomer = originalCustomer;

            //Act
            _sut.Update("ROCK", "Rocky raccoon", "UK", "Chester", null);

            //Assert
            Assert.That(_sut.SelectedCustomer.ContactName, Is.EqualTo("Rocky Raccoon"));
            Assert.That(_sut.SelectedCustomer.CompanyName, Is.EqualTo("Zoo UK"));
            Assert.That(_sut.SelectedCustomer.Country, Is.Null);
            Assert.That(_sut.SelectedCustomer.City, Is.EqualTo("Telford"));
        }
        #endregion

        #region Lab - Homework

        // Use Stubs to verify that RetrieveAll() and SetSelectedCustomer() works as expected.

        // Write a behaviour-based tests to verify that that the CustomerManager Create and Delete methods call the expected CustomerService methods.
        [Test]
        [Category("Homework")]
        public void ReturnACustomer_WhenSetSelectedCustomerIsCalled()
        {
            //Arrange
            var mockCustomerService = new Mock<ICustomerService>();

            var customer = new Customer { CustomerId = "Tom" };

            // Set up the service so it returns what I want
            mockCustomerService.Setup(cs => cs.GetCustomerById("Tom")).Returns(customer);

            //Act
            _sut = new CustomerManager(mockCustomerService.Object);

            _sut.SetSelectedCustomer(customer);

            //Assert
            Assert.That(_sut.SelectedCustomer.CustomerId, Is.EqualTo("Tom"));
        }

        [Test]
        [Category("Homework")]
        public void ReturnAListOfCustomers_WhenRetrieveAllIsCalled()
        {
            //Arrange
            var mockCustomerService = new Mock<ICustomerService>();

            List<Customer> customersList = new List<Customer>()
            {
                new Customer { CustomerId = "MANDA" },
                new Customer { CustomerId = "TOM" },
                new Customer { CustomerId = "DAVID" }
            };

            // Set up the service so it returns what I want
            mockCustomerService.Setup(cs => cs.GetCustomerList()).Returns(customersList);

            //Act
            _sut = new CustomerManager(mockCustomerService.Object);

            var result = _sut.RetrieveAll();

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result[0].CustomerId, Is.EqualTo("MANDA"));
            Assert.That(result[1].CustomerId, Is.EqualTo("TOM"));
            Assert.That(result[2].CustomerId, Is.EqualTo("DAVID"));
        }

        [Test]
        [Category("Homework")]
        public void ReturnTrue_WhenCreateIsCalled_AfterCreatingANewCustomer()
        {
            //Arrange
            var mockCustomerService = new Mock<ICustomerService>();

            var customer = new Customer { CustomerId = "Manda" };

            // Set up the service so it returns what I want
            mockCustomerService.Setup(cs => cs.GetCustomerById("Manda")).Returns(customer);

            //Act
            _sut = new CustomerManager(mockCustomerService.Object);
            _sut.Create(customer.CustomerId, It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());

            _sut.SetSelectedCustomer(customer);

            var result = _sut.SelectedCustomer.CustomerId;

            //Assert
            Assert.That(result, Is.EqualTo("Manda")); // Mock Verify method? 
        }

        [Test]
        [Category("Homework")]
        public void ReturnTrue_WhenDeleteIsCalled_WhenAValidIDIsDeleted()
        {
            //Arrange
            var mockCustomerService = new Mock<ICustomerService>();

            var customer = new Customer { CustomerId = "Manda" };

            // Set up the service so it returns what I want
            mockCustomerService.Setup(cs => cs.GetCustomerById("Manda")).Returns(customer);

            //Act
            _sut = new CustomerManager(mockCustomerService.Object);

            _sut.SetSelectedCustomer(customer);

            var result = _sut.Delete(_sut.SelectedCustomer.CustomerId);

            //Assert
            Assert.That(result); // Mock Verify method? 
        }

        #endregion
    }
}

