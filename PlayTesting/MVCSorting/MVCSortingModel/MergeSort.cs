namespace MVCSortingModel
{
    public class MergeSort : ISortable
    {
        public int[] SortArray(int[] inputArr)
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

            leftArray = SortArray(leftArray);
            rightArray = SortArray(rightArray);

            result = Merge(leftArray, rightArray);

            return result;
        }

        private int[] Merge(int[] leftArray, int[] rightArray)
        {
            int resultLength = rightArray.Length + leftArray.Length;
            int[] result = new int[resultLength];

            int leftIndex = 0;
            int rightIndex = 0;
            int resultIndex = 0;

            while (leftIndex < leftArray.Length || rightIndex < rightArray.Length)
            {
                if (leftIndex < leftArray.Length && rightIndex < rightArray.Length)
                {
                    if (leftArray[leftIndex] <= rightArray[rightIndex])
                    {
                        result[resultIndex] = leftArray[leftIndex];
                        leftIndex++;
                        resultIndex++;
                    }
                    else
                    {
                        result[resultIndex] = rightArray[rightIndex];
                        rightIndex++;
                        resultIndex++;
                    }
                }
                else if (leftIndex < leftArray.Length)
                {
                    result[resultIndex] = leftArray[leftIndex];
                    leftIndex++;
                    resultIndex++;
                }
                else if(rightIndex < rightArray.Length)
                {
                    result[resultIndex] = rightArray[rightIndex];
                    rightIndex++;
                    resultIndex++;
                }
            }

            return result;
        }
    }
}