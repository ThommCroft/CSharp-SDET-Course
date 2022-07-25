namespace MVCSortingModel
{
    public class DotNETSort : ISortable
    {
        public int[] SortArray(int[] inputArr)
        {
            Array.Sort(inputArr);

            return inputArr;
        }
    }
}
