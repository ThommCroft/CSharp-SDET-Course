namespace MergeSortExampleTests
{
    public class Tests
    {
        [TestCase(new int[] {  }, new int[] {  })]
        [TestCase(new int[] { -4, -70, -20, -50 }, new int[] { -70, -50, -20, -4 })]
        [TestCase(new int[] { -5, 50, -30, 10, 12 }, new int[] { -30, -5, 10, 12, 50 })]
        [TestCase(new int[] { 50, 30, 2, 89, 5, 1, 22 }, new int[] { 1, 2, 5, 22, 30, 50, 89 })]
        [Category("Happy Path")]
        public void GivenAnArray_MergeSort_ReturnSortedArrayFromLowestToHighest(int[] subject, int[] expectedResult)
        {
            Assert.That(() => Program.MergeSort(subject), Is.EqualTo(expectedResult));
        }
    }
}