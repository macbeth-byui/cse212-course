// CSE 212 Lesson 5A
// Demonstrate how sets work.

HashSet<string> names = new HashSet<string>(); // Create an empty set of names
Console.WriteLine($"Empty set: {{{string.Join(", ", names)}}}");

// Create a set of two names: Bob and Tim

Console.WriteLine($"Set with Bob and Tim: {{{string.Join(", ", names)}}}");

// Add a Sue to the set

Console.WriteLine($"After adding Sue (notice not in order): {{{string.Join(", ", names)}}}");

// Add Bob again (duplicate)

Console.WriteLine($"After trying to add Bob again: {{{string.Join(", ", names)}}}");

// Check for membership
Console.WriteLine("Enter a name: ");
// string findName = Console.ReadLine()!;

if (true) {
    Console.WriteLine("In the Set.");
}
else {
    Console.WriteLine("Not in the Set.");
}

// Remove Bob from the set

Console.WriteLine($"After removing Bob: {{{string.Join(", ", names)}}}");