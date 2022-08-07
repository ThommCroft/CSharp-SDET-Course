namespace MVCSortingAppTests
{
    public class TestData
    {
        public static object[] SadCases =
        {
            new object[] { new int[] { } }
        };

        public static object[] HappyCases =
        {
            // single element array
            new int[][] { new int[]  { 1 }, new int[] { 1 } },

            // array of all 1s
            new int[][] { new int[]  { 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1 } },

            // array of all -1s
            new int[][] { new int[]  { -1, -1, -1, -1, -1 }, new int[] { -1, -1, -1, -1, -1 } },

            // Random order
            new int[][] { new int[]  { 5, 1, 3, 2, 4 }, new int[] { 1, 2, 3, 4, 5 } },

            // almost sorted
            new int[][] { new int[]  { 1, 3, 2, 4, 6, 5 }, new int[] { 1, 2, 3, 4, 5, 6 } },

            // inverse sorted
            new int[][] { new int[]  { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 } },

            // few unique values
            new int[][] { new int[]  { 1, 2, 3, 3, 1, 2 }, new int[] { 1, 1, 2, 2, 3, 3 } },
        };
    }
}
