﻿using CodingChallenges.Extensions;

namespace CodingChallenges.Problems.ArrayProblems.Unsorted.SubArray;

internal class _11_SubArrayWithLengthKHavingMaxAverage
{
    // Given an integer array nums and an integer k,
    // find the sum of the subarray with the largest sum whose length is k.
    private readonly Dictionary<List<int>, int> _testCases = new()
    {
        { [1,12,-5,-6,50,3], 4 },
        { [5], 1 }
    };

    public void Run()
    {
        foreach (var testCase in _testCases)
        {
            var result = testCase.Key.FindSubArrayWithLengthKHavingMaxAverage(testCase.Value);
            Console.WriteLine($"The max average of the sub-array with length {testCase.Value} is {result}");
        }
    }
}
