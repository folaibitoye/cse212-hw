public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}. 
    /// Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Create a new array to store the result.
        // The size of the array should be equal to 'length'.
        double[] result = new double[length];

        // Step 2: Use a loop to fill the array with multiples of 'number'.
        // Start from 1 and go up to 'length', multiplying 'number' by the index.
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        // Step 3: Return the filled array.
        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  
    /// For example, List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and amount = 3 
    /// becomes List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Get the count of elements in the list.
        int count = data.Count;

        // Step 2: Normalize the rotation amount if it’s larger than the list size.
        amount = amount % count;

        // Step 3: Get the last 'amount' items (these will rotate to the front).
        List<int> tail = data.GetRange(count - amount, amount);

        // Step 4: Remove those items from the end of the original list.
        data.RemoveRange(count - amount, amount);

        // Step 5: Insert those items at the beginning of the list.
        data.InsertRange(0, tail);
    }
}
