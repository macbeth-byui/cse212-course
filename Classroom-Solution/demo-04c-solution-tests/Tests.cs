using NUnit.Framework;

public class Tests
{
    [Test]
    public void Test4CPhoneSwitch1()
    {
        // Test 1
        // Scenario: Can I add one phone call and then process the phone call
        // Expected Result: The phone call that was added should be connected
        var phoneSwitch = new PhoneSwitch(5);
        phoneSwitch.RequestCall("555-1234");
        phoneSwitch.ProcessNextCall();
        Assert.That(phoneSwitch.LogEntries, Has.Count.EqualTo(1));
        string[] expected = ["Call connected for 555-1234"];
        Assert.That(phoneSwitch.LogEntries, Is.EqualTo(expected));
        // Defect(s) Found: 
    }

    [Test]
    public void Test4CPhoneSwitch2()
    {
        // Test 2
        // Scenario: Can I add three phone calls and then process them in the proper order
        // Expected Result: The three phone calls should be connected in order from first to last
        var phoneSwitch = new PhoneSwitch(5);
        phoneSwitch.RequestCall("555-1234");
        phoneSwitch.RequestCall("555-2468");
        phoneSwitch.RequestCall("555-1379");
        phoneSwitch.ProcessNextCall();
        phoneSwitch.ProcessNextCall();
        phoneSwitch.ProcessNextCall();
        Assert.That(phoneSwitch.LogEntries, Has.Count.EqualTo(3));
        string[] expected = ["Call connected for 555-1234",
            "Call connected for 555-2468",
            "Call connected for 555-1379"];
        Assert.That(phoneSwitch.LogEntries, Is.EqualTo(expected));
        // Defect(s) Found: 
    }

    [Test]
    public void Test4CPhoneSwitch3()
    {
        // Test 3
        // Scenario: If the queue has 2 phone calls in it already, will a 911 call be put in the
        //           front of the list
        // Expected Result: The 911 call should be connected first then followed by the other 2
        //                  from first to last
        var phoneSwitch = new PhoneSwitch(5);
        phoneSwitch.RequestCall("555-1234");
        phoneSwitch.RequestCall("555-2468");
        phoneSwitch.RequestCall("911");
        phoneSwitch.ProcessNextCall();
        phoneSwitch.ProcessNextCall();
        phoneSwitch.ProcessNextCall();
        Assert.That(phoneSwitch.LogEntries, Has.Count.EqualTo(3));
        string[] expected = ["Call connected for 911",
            "Call connected for 555-1234",
            "Call connected for 555-2468"];
        Assert.That(phoneSwitch.LogEntries, Is.EqualTo(expected));
        // Defect(s) Found: 
    }

    [Test]
    public void Test4CPhoneSwitch4()
    {
        // Test 4
        // Scenario: Can I process a phone call if there are no phone calls in the queue
        // Expected Result: This should display some error message
        var phoneSwitch = new PhoneSwitch(5);
        phoneSwitch.ProcessNextCall();
        Assert.That(phoneSwitch.LogEntries, Has.Count.EqualTo(1));
        string[] expected = ["The phone queue is empty."];
        Assert.That(phoneSwitch.LogEntries, Is.EqualTo(expected));
        // Defect(s) Found: 
    }

    [Test]
    public void Test4CPhoneSwitch5()
    {
        // Test 5
        // Scenario: Can I exceed the maximum size of the phone queue
        // Expected Result: This should display a 'Line Busy' error message
        var phoneSwitch = new PhoneSwitch(5);
        phoneSwitch.RequestCall("555-1234");
        phoneSwitch.RequestCall("555-2468");
        phoneSwitch.RequestCall("555-1379");
        phoneSwitch.RequestCall("555-1515");
        phoneSwitch.RequestCall("555-9999");
        phoneSwitch.RequestCall("555-0000");
        Assert.That(phoneSwitch.LogEntries, Has.Count.EqualTo(1));
        string[] expected = ["Line is busy. Unable to make call to 555-0000"];
        Assert.That(phoneSwitch.LogEntries, Is.EqualTo(expected));
        // Assert.Fail("Find the untested requirement, and replace this with the additional test.");
        // Defect(s) Found: The last one is getting added because the check for a full queue is using <= instead of <
    }
}