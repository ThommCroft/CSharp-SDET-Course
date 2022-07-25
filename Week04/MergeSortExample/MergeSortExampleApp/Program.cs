namespace MergeSortExampleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sortedArray = MergeSort(new int[] { 50, 30, 2, 89, 5, 1, 22 });

            foreach (int num in sortedArray)
            {
                Console.WriteLine(num);
            }
        }

        public static int[] MergeSort(int[] inputArr)
        {
            int[] leftArray;
            int[] rightArray;
            int[] result = new int[inputArr.Length];

            if (inputArr.Length <= 1)
            {
                return inputArr;
            }

            int midPoint = inputArr.Length / 2;

            leftArray = new int[midPoint];

            if (inputArr.Length % 2 == 0)
            {
                rightArray = new int[midPoint];
            }
            else
            {
                rightArray = new int[midPoint + 1];
            }

            for (int i = 0; i < midPoint; i++)
            {
                leftArray[i] = inputArr[i];
            }

            int x = 0;

            for (int i = midPoint; i < inputArr.Length; i++)
            {
                rightArray[x] = inputArr[i];
                x++;
            }

            leftArray = MergeSort(leftArray);
            rightArray = MergeSort(rightArray);

            result = Merge(leftArray, rightArray);

            return result;
        }

        public static int[] Merge(int[] leftArr, int[] rightArr)
        {

            int resultLength = rightArr.Length + leftArr.Length;
            int[] result = new int[resultLength];

            int indexLeft = 0, indexRight = 0, indexResult = 0;

            while (indexLeft < leftArr.Length || indexRight < rightArr.Length)
            {
                if (indexLeft < leftArr.Length && indexRight < rightArr.Length)
                {
                    if (leftArr[indexLeft] <= rightArr[indexRight])
                    {
                        result[indexResult] = leftArr[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    else
                    {
                        result[indexResult] = rightArr[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                else if (indexLeft < leftArr.Length)
                {
                    result[indexResult] = leftArr[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                else if (indexRight < rightArr.Length)
                {
                    result[indexResult] = rightArr[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }
    }
}