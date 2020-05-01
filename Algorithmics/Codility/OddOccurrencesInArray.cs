using System;
using System.Collections.Generic;
using System.Text;

// Find value that occurs in odd number of elements. 

// A non-empty array A consisting of N integers is given.
// The array contains an odd number of elements, and each element of the array can be paired with another element that has the same value, except for one element that is left unpaired.
// For example, in array A such that:
//   A[0] = 9  A[1] = 3  A[2] = 9
//   A[3] = 3  A[4] = 9  A[5] = 7
//   A[6] = 9

//   the elements at indexes 0 and 2 have value 9,
//   the elements at indexes 1 and 3 have value 3,
//   the elements at indexes 4 and 6 have value 9,
//   the element at index 5 has value 7 and is unpaired.

//Write a function:
//    class Solution { public int solution(int[] A); }
//that, given an array A consisting of N integers fulfilling the above conditions, returns the value of the unpaired element.
//For example, given array A such that:
//  A[0] = 9  A[1] = 3  A[2] = 9
//  A[3] = 3  A[4] = 9  A[5] = 7
//  A[6] = 9
// the function should return 7, as explained in the example above.
// Write an efficient algorithm for the following assumptions:
//         N is an odd integer within the range [1..1,000,000];
// each element of array A is an integer within the range[1..1, 000, 000, 000];
//         all but one of the values in A occur an even number of times.



namespace Algorithmics.Codility
{
    public static class OddOccurrencesInArray
    {
        // Performance Penalty
        public static int Solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == -1) continue;

                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] == -1) continue;

                    if (A[i] == A[j])
                    {
                        A[i] = A[j] = -1;
                        break;
                    }
                }

                if (A[i] != -1) return A[i];
            }

            return -1;
        }

        // Very fast
        public static int Solution2(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            Dictionary<int, int> valuePairs = new Dictionary<int, int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (!valuePairs.ContainsKey(A[i]))
                    valuePairs.Add(A[i], 1);
                else
                    valuePairs[A[i]] = (valuePairs[A[i]]) + 1;
            }

            foreach (var key in valuePairs.Keys)
            {
                if (valuePairs[key] % 2 == 1) return key;
            }

            return -1;
        }
    }
}
