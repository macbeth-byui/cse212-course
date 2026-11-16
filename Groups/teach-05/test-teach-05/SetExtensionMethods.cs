namespace test_teach_05;

public static class SetExtensionMethods {
    public static List<(int, int)> SortPairs(this List<(int, int)> pairs)
    {
        var reordered = new List<(int, int)>(pairs.Count);
        foreach (var (first, second) in pairs)
        {
            reordered.Add(first < second ? (first, second) : (second, first));
        }

        return reordered;
    }
}