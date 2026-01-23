using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following items and priority number: Burger (2), Fries (3), Chicken (1) and
    // run if the items enqueue with their correspondent priority number which is higher number
    // Expected Result: Fries, Burger, Chicken
    // Defect(s) Found: This is not dequeueing in the right order. There is a mistake in if statement determining the priority index
    public void TestPriorityQueue_ProperlyOrdered()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Burger", 2);
        priorityQueue.Enqueue("Fries", 3);
        priorityQueue.Enqueue("Chicken", 1);

        var priorities = new[]
        {
            priorityQueue.Dequeue(),
            priorityQueue.Dequeue(),
            priorityQueue.Dequeue()
        };

        string[] expectedResult = ["Fries", "Burger", "Chicken"];
        
        for (int i = 0; i < expectedResult.Length; i++)
        {
            Assert.AreEqual(expectedResult[i], priorities[i]);
        }
    }

    [TestMethod]
    // Scenario: Test dequeuing if the queue is empty
    // Expected Result: InvalidOperationException
    // Defect(s) Found: Exception is successfully thrown when the priority queque is empty
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();
        
        try
        {
            var priority1 = priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }

    // Add more test cases as needed below.
}