using NUnit.Framework;

public class Tests
{
    [Test]
    public void Test4BWebServer1()
    {
        // Test 1
        // Scenario: Can I add one web request and then process the web request
        // Expected Result: The web request that was added should be processed
        var server = new WebServer();
        server.AddRequest("10.2.53.123", "https://byui.edu");
        server.ProcessRequest();
        var serverLog = server.LogEntries;
        Assert.That(serverLog.Count, Is.EqualTo(1));
        Assert.That(serverLog[0], Is.EqualTo("Processing https://byui.edu from 10.2.53.123"));

        // Defect(s) Found: None :)
    }

    [Test]
    public void Test4BWebServer2()
    {
        // Test 2
        // Scenario: Can I add three web requests and then process them in the proper order
        // Expected Result: The three web requests should be processed in order from first to last
        Console.WriteLine("Test 2");
        var server = new WebServer();
        server.AddRequest("10.2.53.123", "https://byui.edu");
        server.AddRequest("29.25.122.33", "https://churchofjesuschrist.org");
        server.AddRequest("17.3.32.110", "https://weather.gov");
        server.ProcessRequest();
        server.ProcessRequest();
        server.ProcessRequest();
        var serverLog = server.LogEntries;
        Assert.That(serverLog.Count, Is.EqualTo(3));
        string[] expectedLog = ["Processing https://byui.edu from 10.2.53.123",
            "Processing https://churchofjesuschrist.org from 29.25.122.33",
            "Processing https://weather.gov from 17.3.32.110"];
        Assert.That(serverLog, Is.EqualTo(expectedLog));

        // Defect(s) Found: The dequeue operation did not remove the item from the queue. 
        // Need to add a `_queue.RemoveAt(0);`
    }

    [Test]
    public void Test4BWebServer3()
    {
        // Test 3
        // Scenario: Can I process a web request if there are no web requests
        // Expected Result: This should display some error message
        var server = new WebServer();
        server.ProcessRequest();
        var serverLog = server.LogEntries;
        Assert.That(serverLog.Count, Is.EqualTo(1));
        Assert.That(serverLog[0], Is.EqualTo("The web queue is empty."));

        // Defect(s) Found: None :)
    }
}