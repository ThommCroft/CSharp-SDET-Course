using JSONPlaceholderAPITesting.DataHandling;

namespace JsonPlaceholderTests.PostTests
{
    public class CreateAPostTests
    {
        private PostService _postService;

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            _postService = new PostService();

            Post newPost = new Post()
            {
                id = 100,
                userId = 1,
                title = "New Book",
                body = "A Book about Books"
            };

            string[] post = new string[4] { newPost.id.ToString(), newPost.userId.ToString(), newPost.title, newPost.body };

            string postToSend = String.Join(',', post);

            await _postService.CreateSinglePostRequestAsync(postToSend);
        }

        [Test]
        public void CreatePostStatus_Is201()
        {
            Assert.That((int)_postService.CallManager.Response.StatusCode, Is.EqualTo(201));
        }

        [Test]
        public void CheckTheNewPostHasBeenCreated()
        {
            Assert.That(_postService.Json_Response["id"].ToString(), Is.EqualTo("100")); // Defect?
        }
    }
}
