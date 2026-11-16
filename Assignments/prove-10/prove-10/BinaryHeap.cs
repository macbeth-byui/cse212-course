namespace prove_10;

public class BinaryHeap
{
    public List<int> Data { get; }
    private bool _isMin; // True = MinHeap, False = MaxHeap

    public BinaryHeap(bool isMin = true)
    {
        Data = new List<int>();
        _isMin = isMin;
    }

    public int Count()
    {
        // Problem 1: Implement the Count function to 
        // indicate the number of values stored in the Heap
        return 0;
    }

    public void Add(int value)
    {
        Data.Add(value);
        BubbleUp(Data.Count - 1);
    }
    
    private void BubbleUp(int index)
    {
        var parentIndex = Parent(index);
        if (Data[index] < Data[parentIndex])
        {
            (Data[index], Data[parentIndex]) = (Data[parentIndex], Data[index]);
            BubbleUp(parentIndex);
        }
        // Problem 4 - Modify BubbleUp to support adding from either a MinHeap
        // or a MaxHeap using the _isMin attribute. 
    }
    
    public int Peek()
    {
        // Problem 2 - Implement the Peek function to obtain, but not remove, the 
        // value at the top of the heap.  Throw an InvalidOperationException if empty.
        return 0;
    }

    public int Remove()
    {
        // Problem 3 - Implement Remove and BubbleDown functions
        // for a Min Heap.  Throw an InvalidOperationException if empty.
        return 0;
    }

    private void BubbleDown(int index)
    {
        // Problem 3 - Implement Remove and BubbleDown functions
        // for a Min Heap.  Throw an InvalidOperationException if empty.

        return;

        // Problem 5 - Modify BubbleDown to support Removing from either a MinHeap
        // or a MaxHeap using the _isMin attribute.
    }

    private static int Parent(int index)
    {
        return (index - 1) / 2;
    }

    private static int Left(int index)
    {
        return 2 * index + 1;
    }

    private static int Right(int index)
    {
        return 2 * index + 2;
    }

}