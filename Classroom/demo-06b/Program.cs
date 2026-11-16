/*
 * CSE 212 Lesson 6B 
 * 
 * This function will read JSON (Javascript Object Notation) data that contains 
 * a list of people who are in space.  The website to understand the JSON data is:
 * 
 * http://open-notify.org/Open-Notify-API/People-In-Space/
 */

using demo_06b;
using System.Text.Json;

const string url = "http://api.open-notify.org/astros.json";
var json = new HttpClient().GetStringAsync(url).Result;

Console.WriteLine(json);
Console.WriteLine();

var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
var data = JsonSerializer.Deserialize<SpacePeople>(json, options)!;

Console.WriteLine($"Number of people in space: {null}");