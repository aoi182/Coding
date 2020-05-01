using System.Collections.Generic;

//Find the missing element in a given permutation

//Task description
//An array A consisting of N different integers is given.The array contains integers in the range[1..(N + 1)], which means that exactly one element is missing.
//Your goal is to find that missing element.
//Write a function:
//    class Solution { public int solution(int[] A); }
//that, given an array A, returns the value of the missing element.
//For example, given array A such that:
//  A[0] = 2
//  A[1] = 3
//  A[2] = 1
//  A[3] = 5
//the function should return 4, as it is the missing element.
//Write an efficient algorithm for the following assumptions:
//        N is an integer within the range[0..100, 000];
//the elements of A are all distinct;
//        each element of array A is an integer within the range[1..(N + 1)].

namespace Algorithmics.Codility
{
    public static class PermMissingElem
    {
        public static int Solution(int[] a)
        {
            SortedSet<int> numbers = new SortedSet<int>();

            for (int i = 0; i < a.Length; i++)
            {
                numbers.Add(a[i]);
            }

            for (int i = 1; i <= a.Length + 1; i++)
            {
                if (!numbers.Contains(i))
                    return i;
            }

            return 0;
        }
    }
}