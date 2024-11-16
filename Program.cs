using System;

class Program
{
    static void Main()
    {
        try
        {
            // Get minNumber and maxNumber from the user
            Console.Write("Enter minNumber: ");
            int minNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter maxNumber: ");
            int maxNumber = int.Parse(Console.ReadLine());

            // Validate input
            if (minNumber > maxNumber)
            {
                Console.WriteLine("minNumber cannot be greater than maxNumber.");
                return;
            }

            // Generate 1000 random numbers
            int[] randomNumbers = new int[1000];
            Random random = new Random();
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = random.Next(minNumber, maxNumber + 1);
            }

            // Count frequency of numbers
            int range = maxNumber - minNumber + 1;
            int[,] frequencyArray = new int[range, 2];

            for (int i = 0; i < range; i++)
            {
                frequencyArray[i, 0] = minNumber + i; // Store the number
                frequencyArray[i, 1] = 0;            // Initialize frequency to 0
            }

            foreach (int number in randomNumbers)
            {
                int index = number - minNumber;
                frequencyArray[index, 1]++;
            }

            // Display the results
            Console.WriteLine("\nNumber | Frequency");
            Console.WriteLine("------------------");
            for (int i = 0; i < range; i++)
            {
                Console.WriteLine($"{frequencyArray[i, 0],6} | {frequencyArray[i, 1],9}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}