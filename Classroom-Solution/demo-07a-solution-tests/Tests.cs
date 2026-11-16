using NUnit.Framework;

public class Tests
{
    [Test]
    public void TestLinkedList()
    {
        // CSE 212 Lesson 7A
        // Implementation of a basic Linked List data structure.

        var numbers = new LinkedList();

        // Insert 6 numbers including a duplicated value
        numbers.AddFirst(1);
        numbers.AddFirst(2);
        numbers.AddFirst(2);
        numbers.AddFirst(3);
        numbers.AddFirst(4);
        numbers.AddFirst(5);

        // Verify the numbers are in order
        VerifyLinkedList(numbers, [5, 4, 3, 2, 2, 1]);

        // Remove the head
        numbers.RemoveFirst();

        // Verify the numbers are in order
        VerifyLinkedList(numbers, [4, 3, 2, 2, 1]);

        // Insert after the value 3 and the value 5
        numbers.AddAfter(3, 5);
        numbers.AddAfter(1, 6);

        VerifyLinkedList(numbers, [4, 3, 5, 2, 2, 1, 6]);
        
        // Use the iterator to display each value
        Console.WriteLine($"Using iterator to display all numbers:");
        foreach (var x in numbers)
        {
            Console.WriteLine(x);
        }
        Console.WriteLine();
        
        // Check that all elements are the same as an int array
        Assert.That(numbers, Is.EqualTo(new[] {4, 3, 5, 2, 2, 1, 6}));

        // Collections functions like Sum work
        Assert.That(numbers.Sum(), Is.EqualTo(23));
    }

    private static void VerifyLinkedList(LinkedList numbers, int[] expected)
    {
        var next = numbers.First;
        foreach (var number in expected)
        {
            Assert.That(next, Is.Not.Null, $"Missing number: {number}");
            Assert.That(next.Data, Is.EqualTo(number));
            next = next.Next;
        }

        // Verify there's no more numbers after the last expected one
        Assert.That(next, Is.Null, $"Extra number in linked list: {next?.Data}");
    }
}