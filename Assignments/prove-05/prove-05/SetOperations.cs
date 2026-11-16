namespace prove_05;

public static class SetOperations
{
        /// <summary>
    /// Performs a set intersection operation.
    /// </summary>
    /// <param name="set1">A set of integers</param>
    /// <param name="set2">A set of integers</param>
    public static HashSet<int> Intersection(HashSet<int> set1, HashSet<int> set2) {
        var result = new HashSet<int>();
        // TODO Problem 1.1 (don't forget to fill out the 05-prove-response.md)
        return result;
    }

    /// <summary>
    /// Performs a set union operation.
    /// </summary>
    /// <param name="set1">A set of integers</param>
    /// <param name="set2">A set of integers</param>
    public static HashSet<int> Union(HashSet<int> set1, HashSet<int> set2) {
        var result = new HashSet<int>();
        // TODO Problem 1.2 (don't forget to fill out the 05-prove-response.md)
        return result;
    }
    
    /// <summary>
    /// The words parameter contains a list of two character 
    /// words (lower case, no duplicates). Using sets, find an O(n) 
    /// solution for finding all symmetric pairs of words.  
    ///
    /// For example, if <c>words</c> was: <c>[am, at, ma, if, fi]</c>, we would return:
    /// <code>
    /// am &amp; ma
    /// if &amp; fi
    /// </code>
    /// The order of the items above does not matter. It could just as easily be
    /// <code>
    /// fi &amp; if
    /// am &amp; ma
    /// </code>
    /// <c>at</c> would not 
    /// be displayed because <c>ta</c> is not in the list of words.
    /// <br />
    /// As a special case, if the letters are the same (example: 'aa') then
    /// it would not match anything else (remember no the assumption above
    /// that there were no duplicates) and therefore should not be displayed.
    /// </summary>
    /// <param name="words">An array of 2-character words (lowercase, no duplicates)</param>
    /// <returns>A list of word pairs</returns>
    public static List<(string, string)> FindPairs(string[] words)
    {
        // TODO Problem 2 (don't forget to fill out the 05-prove-response.md)
        var results = new List<(string, string)>();
        // Use something like: results.Add(("am", "ma"));
        return results;
    }
}