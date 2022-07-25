namespace BubbleSortLibraryTests
{
    public class Tests
    {
        [Test]
        public void GivenAnArrayOfNumbers_BubbleSort_returnThemFromLowestToHighest()
        {
            int[] subject = new int[] { 10, 4, 5, 3, 9, 7, 1, 6, 2, 8 };
            int[] expectedResult = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var sorting = new BubblySorting();

            Assert.That(sorting.BubbleSort(subject), Is.EqualTo(expectedResult));
        }

        [Test]
        public void GivenAnEmptyArrays_BubbleSort_returnEmptyArray()
        {
            int[] subject = new int[] { };
            int[] expectedResult = new int[] { };

            var sorting = new BubblySorting();

            Assert.That(sorting.BubbleSort(subject), Is.EqualTo(expectedResult));
        }
    }
}