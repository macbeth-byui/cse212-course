using System.Text;

namespace demo_10a_solution;

public class MinHeap
{
    private readonly List<int> _data = new ();

    public void Add(int value)
    {
        _data.Add(value);
        BubbleUp(_data.Count - 1);
    }

    private void BubbleUp(int index)
    {
        int parentIndex = (index - 1) / 2;
        if (_data[index] < _data[parentIndex])
        {
            // swap positions and repeat
            (_data[index], _data[parentIndex]) = (_data[parentIndex], _data[index]);
            BubbleUp(parentIndex);
        }
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", _data)}]";
    }

    public void DisplayHeap()
    {
        string[] rotation = ["┌", "┴", "┐", ""];
        char[] rotationFiller = [' ', '─', '─', ' '];
        string extra = "┘";

        var levels = Log2(_data.Count + 1);
        for (int level = 0; level < levels; level++)
        {
            var rotationIndex = 0;
            var firstIndex = (1 << level) - 1;
            var lastIndex = Math.Min((1 << (level + 1)) - 2, _data.Count - 1) + 1;
            var padding = 1 << (levels - level);
            string format = $"{{0,{padding}}}";

            var treeLines = new StringBuilder();
            var builder = new StringBuilder();
            for (var i = firstIndex; i < lastIndex; i++)
            {
                var value = _data[i];
                var output = string.Format(format, value);
                builder.Append(output.PadRight(padding * 2));

                treeLines.Append(rotation[rotationIndex].PadLeft(padding, rotationFiller[rotationIndex]));
                rotationIndex++;
                rotationIndex %= 4;
                if (i == _data.Count - 1 && (i & 1) == 1)
                    rotation[rotationIndex] = extra;
                treeLines.Append(rotation[rotationIndex].PadLeft(padding, rotationFiller[rotationIndex]));
                rotationIndex++;
                rotationIndex %= 4;
            }

            if (level > 0)
                Console.WriteLine(treeLines);
            Console.WriteLine(builder);
        }
    }

    private static int Log2(int n)
    {
        if (n <= 0)
            throw new ArgumentException("Positive integers only", nameof(n));

        var result = 0;
        while (n > 0)
        {
            n >>= 1;
            ++result;
        }

        return result;
    }
}