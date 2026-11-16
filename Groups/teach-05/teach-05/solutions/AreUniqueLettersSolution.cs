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
public static class AreUniqueLettersSolution
{
    /// <summary>Determine if there are any duplicate letters in the text provided</summary>
    /// <param name="text">Text to check for duplicate letters</param>
    /// <returns>true if all letters are unique, otherwise false</returns>
    public static bool AreUniqueLetters(string text)
    {
        // TODO Problem 1 - Replace the O(n^2) algorithm to use sets and O(n) efficiency
        var foundBefore = new HashSet<char>();
        foreach (var letter in text)
        {
            // Look in set to see if letter was seen before
            if (foundBefore.Contains(letter))
                return false;

            // Otherwise we will add it to the set and move on
            foundBefore.Add(letter);
        }
        
        return true;
    }

    /// <summary>Determine if there are any duplicate letters in the text provided</summary>
    /// <param name="text">Text to check for duplicate letters</param>
    /// <returns>true if all letters are unique, otherwise false</returns>
    public static bool AreUniqueLettersAlternate(string text)
    {
        var unique = new HashSet<char>(text);
        return unique.Count == text.Length;
    }
}