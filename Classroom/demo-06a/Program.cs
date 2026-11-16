/*
 * CSE 212 Lesson 6a
 * Demonstrate how dictionaries (maps) work.
 */

// Create an empty dictionary
var student = new Dictionary<string, string>();
Console.WriteLine($"Empty dictionary: {{{string.Join(", ", student)}}}");

// Add name, credits, and the major to the student.

Console.WriteLine($"Populated student: {{{string.Join(", ", student)}}}");

// Display just the student credits
var credits = "";
Console.WriteLine($"Student credits: {credits}");

// Display just the keys.
Console.WriteLine($"Keys: ");

// Display just the values
Console.WriteLine($"Values: ");

// Display all Key/Value pairs


// Remove major from the student

Console.WriteLine($"After deleting the major: {{{string.Join(", ", student)}}}");
