namespace MVCSortingAppModel
{
    public class DotNETSort : ISortable
    {
        public int[] SortArray(int[] inputArr)
        {
            if (inputArr.Length <= 0)
            {
                throw new ArgumentException("Input must contain at least one element");
            }

            Array.Sort(inputArr);

            return inputArr;
        }
    }
}
