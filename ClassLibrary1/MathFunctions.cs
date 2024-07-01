namespace FunctionLib
{
    public class MathFunctions
    {
        /// <summary>
        /// Finds factors based on imput
        /// </summary>
        /// <param name="x">single integer</param>
        /// <returns>String output of numbers</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string Factorize(int x)
        {
            List<int> primeList = PrimeFinder();
            string output = string.Empty;

            if (x > 1000)
            {
                throw new ArgumentOutOfRangeException(nameof(x), $"The number {x} is too large to factorize.");
            }

            foreach (int prime in primeList)
            {
                if (prime > x)
                    break;

                // Check if prime is a factor of x
                while (x % prime == 0)
                {
                    output += $"{prime} x ";
                    x /= prime;
                }
            }
            if (output.EndsWith("x "))
            {
                output = output.Substring(0, output.Length - 3);
            }

            // If x is still greater than 1, it's a prime number itself
            if (x > 1)
                output += $"{x}";

            Console.Write($"Prime factors of {x} are {output}");
            Console.WriteLine();
            
            return output; // Return value as per your requirement
        }
        /// <summary>
        /// Finds prime numbers between 0/1000
        /// </summary>
        /// <returns>Full list of prime numbers</returns>
        public static List<int> PrimeFinder()
        {
            List<int> primeList = new List<int>();

            for (int i = 0; i < 1000; i++)
            {
                if (i < 0) break;
                else if (i == 2) primeList.Add(i);
                else if (i > 2 & i % 2 != 0)
                {
                    int square = (int)Math.Floor(Math.Sqrt(i));
                    bool isDivisible = false;
                    
                    for (int j = 3; j <= square; j++)
                    {
                        if (i % j == 0)
                        {
                            isDivisible = true;
                            break;
                        }
                    }
                    if (isDivisible == false)
                    {
                        primeList.Add(i);
                    }
                }
                
            }
            return primeList;
        }
    }
}
