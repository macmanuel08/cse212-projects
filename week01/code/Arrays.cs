public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Create a variable that will store the new array, this time array of doubles (multiples)
        // Create a variable to store the number of how the number will multiply, it starts with 1 (factor)
        // Create a loop that starts with the given starting number (number)
        // Loop through it until the given number of times reached (length)
        // Each iteration, multiply the (number) with the current (factor)
        // Add the product to the (multiples) array
        // Add 1 to the (factor) for next iteration

        var multiples = new double[length];
        var factor = 1;

        for (int i = 0; i < length; i++ )
        {
            multiples[i] = number * factor;
            factor++;
        }

        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Use the GetRange method to get the (amount) of numbers to shift to the start, store this to (shiftAmounts) list variable
        // Use RemoveRange method to remove the (amount) of the numbers from the (data) that will be shifted
        // Use InserRange method to add (amounts) list to the start of (data) list

        var amounts = data.GetRange(data.Count - amount, amount);
        data.RemoveRange(data.Count - amount, amount);
        data.InsertRange(0, amounts);

    }
}
