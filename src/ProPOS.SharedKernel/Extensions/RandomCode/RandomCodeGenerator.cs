namespace ProPOS.SharedKernel.Extensions.RandomCode;

public class RandomCodeGenerator
{
    public static string RandomCode(string prefix)
    {
        // Create a random number generator
        Random random = new Random();

        // Generate a random numeric part (0000)
        int randomNumericPart = random.Next(10000);

        // Format the numeric part with leading zeros
        string formattedNumericPart = randomNumericPart.ToString("D4");

        // Concatenate the prefix and the formatted numeric part
        string randomCode = $"{prefix}-{formattedNumericPart}";

        return randomCode;
    }
}