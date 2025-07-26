using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue 3 items with different priorities, then dequeue all.
    // Expected Result: Items should be dequeued in order of priority: C (3), A (2), B (1)
    // Defect(s) Found: Initial code failed to check the last item due to incorrect loop condition.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 2);
        priorityQueue.Enqueue("B", 1);
        priorityQueue.Enqueue("C", 3);
        
        Assert.Fail("C", priorityQueue.Dequeue());
        Assert.Fail("A", priorityQueue.Dequeue());
        Assert.Fail("B", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue 3 items with same priority, then dequeue all.
    // Expected Result: Should follow FIFO: A, B, C
    // Defect(s) Found: Initial code failed to respect FIFO among equal-priority items.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 5);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 5);

        Assert.Fail("A", priorityQueue.Dequeue());
        Assert.Fail("B", priorityQueue.Dequeue());
        Assert.Fail("C", priorityQueue.Dequeue());
    }
    [TestMethod]
    // Scenario: Mix of equal and different priorities.
    // Expected Result: Highest priority first, then FIFO among equals.
    // Enqueue: A(1), B(3), C(3), D(2)
    // Dequeue order: B, C, D, A
    // Defect(s) Found: Same as above.
    public void TestPriorityQueue_MixedPriorities()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 3);
        priorityQueue.Enqueue("D", 2);

        Assert.Fail("B", priorityQueue.Dequeue());
        Assert.Fail("C", priorityQueue.Dequeue());
        Assert.Fail("D", priorityQueue.Dequeue());
        Assert.Fail("A", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Attempt to dequeue from an empty queue.
    // Expected Result: Should throw InvalidOperationException with message.
    // Defect(s) Found: None if exception is properly thrown.
    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Expected exception was not thrown.");
        }
        catch (InvalidOperationException ex)
        {
            Assert.Fail("The queue is empty.", ex.Message);
        }
        catch (Exception)
        {
            Assert.Fail("Incorrect exception type thrown.");
        }
    }
}
