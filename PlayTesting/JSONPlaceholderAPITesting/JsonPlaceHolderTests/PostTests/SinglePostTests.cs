namespace JsonPlaceholderTests.PostTests
{
    public class SinglePostTests
    {
        private PostService _postService;

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            _postService = new PostService();
            await _postService.GetSinglePostRequestAsync("1");
        }

        [Test]
        [Category("Happy Post")]
        public void PostStatusIs200()
        {
            Assert.That((int)_postService.CallManager.Response.StatusCode, Is.EqualTo(200));
        }

        [Test]
        [Category("Happy Post")]
        public void PostUserID_IsEqualToOne_InJsonResponse()
        {
            Assert.That(_postService.Json_Response["userId"].ToString(), Is.EqualTo("1"));
        }

        [Test]
        [Category("Happy Post")]
        public void PostID_IsEqualToOne_InJsonResponse()
        {
            Assert.That(_postService.Json_Response["id"].ToString(), Is.EqualTo("1"));
        }

        [Test]
        [Category("Happy Post")]
        public void PostTitle_IsEqualToExpectedResult_InJsonResponse()
        {
            string expectedResult = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit";

            Assert.That(_postService.Json_Response["title"].ToString(), Is.EqualTo(expectedResult));
        }

        [Test]
        [Category("Happy Post")]
        public void PostBody_IsEqualToExpectedResult_InJsonResponse()
        {
            string expectedResult = "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\n" +
                                     "nostrum rerum est autem sunt rem eveniet architecto";

            Assert.That(_postService.Json_Response["body"].ToString(), Is.EqualTo(expectedResult));
        }
    }
}