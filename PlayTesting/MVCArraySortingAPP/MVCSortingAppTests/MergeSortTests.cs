namespace MVCSortingAppTests
{
    public class MergeSortTests
    {
        private MergeSort _sorter = new MergeSort();

        [TestCaseSource(typeof(TestData), nameof(TestData.SadCases))]
        [Category("Sad Path")]
        public void GivenInValidSortingInput_BubbleSort_Throws(int[] input)
        {
            Assert.That(() => _sorter.SortArray(input), Throws.TypeOf<ArgumentException>().With.Message.Contains("Input must contain at least one element"));
        }

        [TestCaseSource(typeof(TestData), nameof(TestData.HappyCases))]
        [Category("Happy Path")]
        public void GivenValidSortingInput_BubbleSort_ReturnsExpectedResult(int[] input, int[] expectedResult)
        {
            Assert.That(_sorter.SortArray(input), Is.EquivalentTo(expectedResult).With.Ordered.Ascending);
        }
    }
}
