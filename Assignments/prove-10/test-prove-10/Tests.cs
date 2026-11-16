using NUnit.Framework;
using prove_10;


public class Tests
{
    [Test]
    public void Test1Count()
    {
        var heap = new BinaryHeap();
        heap.Add(20);
        heap.Add(30);
        heap.Add(10);
        heap.Add(50);
        heap.Add(70);
        heap.Add(40);
        heap.Add(15);
        heap.Add(25);
        List<int> expected = [10, 25, 15, 30, 70, 40, 20, 50];
        Assert.That(heap.Data, Is.EqualTo(expected));
        Assert.That(heap.Count(), Is.EqualTo(8));
    }

    [Test]
    public void Test2Peek()
    {
        var heap = new BinaryHeap();
        Assert.Throws<InvalidOperationException>(() => heap.Peek());
        heap.Add(20);
        heap.Add(30);
        heap.Add(10);
        heap.Add(50);
        heap.Add(70);
        heap.Add(40);
        heap.Add(15);
        heap.Add(25);
        List<int> expected = [10, 25, 15, 30, 70, 40, 20, 50];
        Assert.That(heap.Data, Is.EqualTo(expected));
        Assert.That(heap.Peek(), Is.EqualTo(10));
    }
    
    [Test]
    public void Test3Remove()
    {
        var heap = new BinaryHeap();
        Assert.Throws<InvalidOperationException>(() => heap.Remove());
        heap.Add(20);
        heap.Add(30);
        heap.Add(10);
        heap.Add(50);
        heap.Add(70);
        heap.Add(40);
        heap.Add(15);
        heap.Add(25);
        List<int> expected = [10, 25, 15, 30, 70, 40, 20, 50];
        Assert.That(heap.Data, Is.EqualTo(expected));
        Assert.That(heap.Remove(), Is.EqualTo(10));
        Assert.That(heap.Remove(), Is.EqualTo(15));
        Assert.That(heap.Remove(), Is.EqualTo(20));
        Assert.That(heap.Remove(), Is.EqualTo(25));
        Assert.That(heap.Remove(), Is.EqualTo(30));
        Assert.That(heap.Remove(), Is.EqualTo(40));
        Assert.That(heap.Remove(), Is.EqualTo(50));
        Assert.That(heap.Remove(), Is.EqualTo(70));
        Assert.Throws<InvalidOperationException>(() => heap.Remove());
    }

    [Test]
    public void Test4AddMaxHeap()
    {
        var heap = new BinaryHeap(false);
        Assert.Throws<InvalidOperationException>(() => heap.Peek());
        heap.Add(20);
        heap.Add(30);
        heap.Add(10);
        heap.Add(50);
        heap.Add(70);
        heap.Add(40);
        heap.Add(15);
        heap.Add(25);
        List<int> expected = [70, 50, 40, 25, 30, 10, 15, 20];
        Assert.That(heap.Data, Is.EqualTo(expected));
        Assert.That(heap.Peek(), Is.EqualTo(70));
    }

    [Test]
    public void Test5RemoveMaxHeap()
    {
        var heap = new BinaryHeap(false);
        Assert.Throws<InvalidOperationException>(() => heap.Remove());
        heap.Add(20);
        heap.Add(30);
        heap.Add(10);
        heap.Add(50);
        heap.Add(70);
        heap.Add(40);
        heap.Add(15);
        heap.Add(25);
        List<int> expected = [70, 50, 40, 25, 30, 10, 15, 20];
        Assert.That(heap.Data, Is.EqualTo(expected));
        Assert.That(heap.Remove(), Is.EqualTo(70));
        Assert.That(heap.Remove(), Is.EqualTo(50));
        Assert.That(heap.Remove(), Is.EqualTo(40));
        Assert.That(heap.Remove(), Is.EqualTo(30));
        Assert.That(heap.Remove(), Is.EqualTo(25));
        Assert.That(heap.Remove(), Is.EqualTo(20));
        Assert.That(heap.Remove(), Is.EqualTo(15));
        Assert.That(heap.Remove(), Is.EqualTo(10));
        Assert.Throws<InvalidOperationException>(() => heap.Remove());
    }
    
}