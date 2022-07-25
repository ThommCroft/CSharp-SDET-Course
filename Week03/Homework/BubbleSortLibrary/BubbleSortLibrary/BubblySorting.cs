namespace BubbleSortLibrary
{
    public class BubblySorting
    {
        public int[] BubbleSort(int[] numbers)
        {
            int[] resultArr = new int[numbers.Length];
            int temp = 0;

            resultArr = numbers;

            for (int i = 0; i < resultArr.Length; i++)
            {
                for (int j = 0; j < resultArr.Length - 1; j++)
                {
                    if (resultArr[j] > resultArr[j + 1]) // If the number is greater than its neighbour
                    {
                        temp = resultArr[j + 1];
                        resultArr[j + 1] = resultArr[j];
                        resultArr[j] = temp;
                    }
                }
            }

            

            return resultArr;
        }
    }
}