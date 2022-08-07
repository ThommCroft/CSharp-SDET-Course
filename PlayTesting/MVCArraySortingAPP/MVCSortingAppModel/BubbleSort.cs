namespace MVCSortingAppModel
{
    public class BubbleSort : ISortable
    {
        public int[] SortArray(int[] inputArr)
        {
            if (inputArr.Length <= 0)
            {
                throw new ArgumentException("Input must contain at least one element");
            }

            for (int i = 0; i < inputArr.Length; i++)
            {
                for (int j = 0; j < inputArr.Length - 1; j++)
                {
                    if (inputArr[j] > inputArr[j + 1])
                    {
                        int temp = inputArr[j + 1];
                        inputArr[j + 1] = inputArr[j];
                        inputArr[j] = temp;
                    }
                }
            }

            return inputArr;
        }
    }
}