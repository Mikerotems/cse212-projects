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
        // Step 1: Create an array to hold the multiples
        double[] multiples = new double[length];

        // Step 2: Loop from 1 to the specified length
        for (int i = 0; i < length; i++)
        {
            // Step 3: For each iteration, multiply the starting number by the loop index (i+1)
            // Step 4: Store the result in the array
            multiples[i] = number * (i + 1);
        }

        // Step 5: Return the array
        return multiples;
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
        // Step 1: Calculate the split index (where to cut the list)
        int splitIndex = data.Count - amount;

        // Step 2: Use GetRange to slice the list into two parts
        List<int> rightPart = data.GetRange(splitIndex, amount);
        List<int> leftPart = data.GetRange(0, splitIndex);

        // Step 3: Clear the original list
        data.Clear();

        // Step 4: Add the right part, then the left part, back to the list
        data.AddRange(rightPart);
        data.AddRange(leftPart);
    }
}
