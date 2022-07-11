using System;
using System.Collections.Generic;

namespace MoreTypes_Lib
{
    public class ArraysExercises
    {
        // returns a 1D array containing the contents of a given List
        public static string[] Make1DArray(List<string> contents)
        {
            string[] array = new string[contents.Count];

            for (int i = 0; i < contents.Count; i++)
            {
                array[i] = contents[i];
            }

            return array;
        }

        // returns a 3D array containing the contents of a given List
        public static string[,,] Make3DArray(int length1, int length2, int length3, List<string> contents) // One Array with many containers like a Table or Cube.
        {
            string[,,] array = new string[length1, length2, length3];

            for (int i = 0; i < length1; i++)
            {
                for (int j = 0; j < length2; j++)
                {
                    for (int k = 0; k < length3; k++)
                    {
                        array[i, j, k] = contents[i * length2 * length3 + j * length3 + k];

                        //if (array[i, j, k] != contents[i * length2 * length3 + j * length3 + k])
                        //{
                        //    throw new ArgumentException("Number of elements in list must match array size");
                        //}
                    }
                }
            }

            //throw new ArgumentException("Number of elements in list must match array size");

            return array;
        }

        // returns a jagged array containing the contents of a given List
        public static string[][] MakeJagged2DArray(int countRow1, int countRow2, List<string> contents) // An Array of Arrays
        {
            string[][] jaggedArray = new string[2][];

            jaggedArray[0] = new string[countRow1];
            jaggedArray[1] = new string[countRow2];

            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {

                }
            }

            //throw new ArgumentException("Number of elements in list must match array size");

            return jaggedArray;
        }
    }
}
