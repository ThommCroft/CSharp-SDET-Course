using JSONPlaceholderAPITesting.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonPlaceholderTests.UserTests
{
    public class SingleUserTests
    {
        private UserService _userService;

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            _userService = new UserService();
            await _userService.GetSingleUserRequestAsync("1");
        }

        [Test]
        [Category("Happy User")]
        public void UserStatusIs200()
        {
            Assert.That((int)_userService.CallManager.Response.StatusCode, Is.EqualTo(200));
        }

        [Test]
        [Category("Happy User")]
        public void UserName_IsEqualToLeanneGraham_InJsonResponse()
        {
            Assert.That(_userService.Json_Response["name"].ToString(), Is.EqualTo("Leanne Graham"));
        }

        [Test]
        [Category("Happy User")]
        public void UsersUsername_IsEquaToBret_InJsonResponse()
        {
            Assert.That(_userService.Json_Response["username"].ToString(), Is.EqualTo("Bret"));
        }

        [Test]
        [Category("Happy User")]
        public void UsersEmailAddress_IsEqualTo_InJsonResponse()
        {
            Assert.That(_userService.Json_Response["email"].ToString(), Is.EqualTo("Sincere@april.biz"));
        }

        [Test]
        [Category("Happy User")]
        public void UsersStreetAddress_IsEqualToKulasLight_InJsonResponse()
        {
            Assert.That(_userService.Json_Response["address"]["street"].ToString(), Is.EqualTo("Kulas Light"));
        }

        [Test]
        [Category("Happy User")]
        public void UsersGeoLat_IsEqualToExpectedResult_InJsonResponse()
        {
            string expectedResult = "-37.3159";
            Assert.That(_userService.Json_Response["address"]["geo"]["lat"].ToString(), Is.EqualTo(expectedResult));
        }

        [Test]
        [Category("Happy User")]
        public void UsersGeoLong_IsEqualToExpectedResult_InJsonResponse()
        {
            string expectedResult = "81.1496";
            Assert.That(_userService.Json_Response["address"]["geo"]["lng"].ToString(), Is.EqualTo(expectedResult));
        }
    }
}
