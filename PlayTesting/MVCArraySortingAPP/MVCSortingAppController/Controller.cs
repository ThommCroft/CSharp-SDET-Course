using MVCSortingAppModel;

namespace MVCSortingAppController
{
    public enum SortType { BubbleSort, MergeSort, DotNETSort }

    public class Controller
    {
        public ISortable SortSelection(SortType sortType)
        {
            ISortable? sortable = null;

            switch (sortType)
            {
                case SortType.BubbleSort:
                    sortable = new BubbleSort();
                    break;
                case SortType.MergeSort:
                    sortable = new MergeSort();
                    break;
                case SortType.DotNETSort:
                    sortable = new DotNETSort();
                    break;
            }

            return sortable;
        }

        public int[] CreatedNumbersArray(int minimumArrayRange, int maximumArrayRange, int arrayLength)
        {
            int[] createdArray = new int[arrayLength];

            Random randomNumber = new Random();

            for (int i = 0; i < createdArray.Length; i++)
            {
                createdArray[i] = randomNumber.Next(minimumArrayRange, maximumArrayRange);
            }

            return createdArray;
        }

        public int[] GenerateRandomArray()
        {
            int[] randomNumbers = new int[14];
            Random randomNumber = new Random();

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = randomNumber.Next(-200, 200);
            }

            return randomNumbers;
        }
    }
}