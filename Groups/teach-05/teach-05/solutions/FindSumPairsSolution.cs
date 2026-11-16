namespace teach_05;

public static class FindSumPairsSolution
{
    /// <summary>
    /// Display pairs of numbers (no duplicates should be displayed) that sum to
    /// 10 using a set in O(n) time.  We are assuming that there are no duplicates
    /// in the list.
    /// </summary>
    /// <param name="numbers">array of integers</param>
    public static List<(int, int)> FindSumPairs(int[] numbers)
    {
        // TODO Problem 2 - This should print pairs of numbers in the given array
        var results = new List<(int, int)>();
        // Use something like: results.Add(("6", "4"));

        var valuesSeenAlready = new HashSet<int>();
        foreach (var n in numbers)
        {
            // If 10-n is in the valuesSeenAlready set then I know that
            // I have previously seen a number that will sum with n 
            // to equal 10. Add the pair to the results
            if (valuesSeenAlready.Contains(10 - n))
                results.Add((n, 10 - n));
            // Add this number to the valuesSeenAlready set
            valuesSeenAlready.Add(n);
        }
        
        return results;
    }
}