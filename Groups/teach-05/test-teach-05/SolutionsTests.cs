using System.Text.RegularExpressions;
using NUnit.Framework;
using teach_05;

namespace test_teach_05;

public class SolutionsTests
{
    [Test]
    public void TestUniqueLettersSolutions1()
    {
        var test1 = "abcdefghjiklmnopqrstuvwxyz";
        // Expect True because all letters unique
        Assert.That(AreUniqueLettersSolution.AreUniqueLetters(test1), Is.True);
        Assert.That(AreUniqueLettersSolution.AreUniqueLettersAlternate(test1), Is.True);
    }
    
    [Test]
    public void TestUniqueLettersSolutions2()
    {
        var test2 = "abcdefghjiklanopqrstuvwxyz";
        // Expect False because 'a' is repeated
        Assert.That(AreUniqueLettersSolution.AreUniqueLetters(test2), Is.False);
        Assert.That(AreUniqueLettersSolution.AreUniqueLettersAlternate(test2), Is.False);
    }
    
    [Test]
    public void TestUniqueLettersSolutions3()
    {
        var test3 = "";
        // Expect True because it's an empty string
        Assert.That(AreUniqueLettersSolution.AreUniqueLetters(test3), Is.True);
        Assert.That(AreUniqueLettersSolution.AreUniqueLettersAlternate(test3), Is.True);
    }

    [Test]
    public void TestDisplaySumsSolutions1()
    {
        var results = FindSumPairsSolution.FindSumPairs([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
        var expected = new[] { (4, 6), (3, 7), (2, 8), (1, 9) };
        // Is.EquivalentTo(...) ignores order & checks for all pairs
        Assert.That(results.SortPairs(), Is.EquivalentTo(expected));
    }
    
    [Test]
    public void TestDisplaySumsSolutions2()
    {
        var results = FindSumPairsSolution.FindSumPairs([-20, -15, -10, -5, 0, 5, 10, 15, 20]);
        var expected = new[] { (0, 10), (-5, 15), (-10, 20) };
        Assert.That(results.SortPairs(), Is.EquivalentTo(expected));
    }
    
    [Test]
    public void TestDisplaySumsSolutions3()
    {
        var results = FindSumPairsSolution.FindSumPairs([5, 11, 2, -4, 6, 8, -1]);
        var expected = new[] { (2, 8), (-1, 11) };
        Assert.That(results.SortPairs(), Is.EquivalentTo(expected));
    }
}