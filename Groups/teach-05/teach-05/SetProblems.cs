namespace teach_05;

/*
 * CSE212
 * (c) BYU-Idaho
 * 05-Teach - Problem 1
 *
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class SetProblems
{
    /// <summary>Determine if there are any duplicate letters in the text provided</summary>
    /// <param name="text">Text to check for duplicate letters</param>
    /// <returns>true if all letters are unique, otherwise false</returns>
    public static bool AreUniqueLetters(string text)
    {
        // TODO Problem 1 - Replace the O(n^2) algorithm to use sets and O(n) efficiency
        for (var i = 0; i < text.Length; ++i)
        {
            for (var j = 0; j < text.Length; ++j)
            {
                // Don't want to compare to yourself ... that will always result in a match
                if (i != j && text[i] == text[j])
                    return false;
            }
        }

        return true;
    }

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
        return results;
    }
}