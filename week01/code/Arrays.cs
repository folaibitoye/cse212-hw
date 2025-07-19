public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // PLAN:
        // 1. Create an array of type double with size = length.
        // 2. Use a loop that runs from 1 to length (inclusive).
        // 3. On each iteration, multiply 'number' by the loop index and store in the array.
        // 4. Return the array after the loop.

        double[] result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'. For example:
    /// List<int>{1,2,3,4,5,6,7,8,9} with amount = 3 becomes List<int>{7,8,9,1,2,3,4,5,6}
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // PLAN:
        // 1. Use GetRange to slice the last 'amount' elements of the list.
        // 2. Use GetRange to get the first (data.Count - amount) elements.
        // 3. Clear the original list.
        // 4. Add the second slice (step 1) to the list.
        // 5. Add the first slice (step 2) to the list.

        // Step 1: Get the last 'amount' items from the list
        List<int> lastPart = data.GetRange(data.Count - amount, amount);

        // Step 2: Get the rest (everything except the last 'amount')
        List<int> firstPart = data.GetRange(0, data.Count - amount);

        // Step 3: Clear the original list
        data.Clear();

        // Step 4: Add rotated items back in order
        data.AddRange(lastPart);    // Add the end slice first
        data.AddRange(firstPart);   // Then add the beginning slice
    }
}
