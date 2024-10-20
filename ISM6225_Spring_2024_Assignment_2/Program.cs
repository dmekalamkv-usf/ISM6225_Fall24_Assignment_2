using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 };
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);

        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                // Sort the input array in ascending order to easily identify missing numbers
                Array.Sort(nums);
                IList<int> missing_numbers = new List<int>();

                // Iterate from 1 to the largest element in the array
                for (int i = 1; i < nums[nums.Length - 1]; i++)
                {
                    // If the current number is not in the array, add it to the missing_numbers list
                    if (!nums.Contains(i))
                    {
                        missing_numbers.Add(i);
                    }
                }

                // Return the list of missing numbers
                return missing_numbers;
            }
            catch (Exception)
            {
                // Re-throw the exception if an error occurs
                throw;
            }
        }

        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
                // Create separate lists for even and odd numbers
                IList<int> even_numbers = new List<int>();
                IList<int> odd_numbers = new List<int>();

                // Iterate over the input array and categorize numbers as even or odd
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] % 2 == 0)
                    {
                        even_numbers.Add(nums[i]);
                    }
                    else
                    {
                        odd_numbers.Add(nums[i]);
                    }
                }

                // Concatenate even numbers first, followed by odd numbers
                IList<int> combined_list = even_numbers.Concat(odd_numbers).ToList();

                // Return the combined list as an array
                return combined_list.ToArray();
            }
            catch (Exception)
            {
                // Re-throw the exception if an error occurs
                throw;
            }
        }

        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                int i = 0, j = nums.Length - 1;
                int x = nums[i] + nums[j];

                // Iterate until a pair of numbers adding up to the target is found
                while (x != target)
                {
                    if (x > target)
                    {
                        // If the sum is greater than the target, move the end pointer leftward
                        j--;
                    }
                    else
                    {
                        // If the sum is less than the target, increment left pointer
                        i++; // increment `i` to move forward
                    }

                    // Update the sum to the current values at indices i and j
                    x = nums[i] + nums[j];
                }

                // Return the indices that add up to the target
                int[] output = { i, j };
                return output;
            }
            catch (Exception)
            {
                // Re-throw the exception if an error occurs
                throw;
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            {
                // Sort the input array in ascending order
                Array.Sort(nums);
                int l = nums.Length - 1;

                // Calculate the maximum product from either three largest or two smallest and the largest
                int product = Math.Max(nums[l - 2] * nums[l - 1] * nums[l], nums[0] * nums[1] * nums[l]);

                // Return the maximum product of three numbers
                return product;
            }
            catch (Exception)
            {
                // Re-throw the exception if an error occurs
                throw;
            }
        }

        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                // Convert the decimal number to its binary representation
                String binary = Convert.ToString(decimalNumber, 2);

                // Return the binary representation as a string
                return binary;
            }
            catch (Exception)
            {
                // Re-throw the exception if an error occurs
                throw;
            }
        }

        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            try
            {
                // Iterate through the array to find the pivot point where the next element is smaller
                for (int i = 0; i < nums.Length - 1; i++) // Fixed out-of-bounds issue by setting nums.Length - 1
                {
                    if (nums[i] > nums[i + 1])
                    {
                        // If the current element is greater than the next element, return the next element (which is the minimum)
                        return nums[i + 1];
                    }
                }

                // If no pivot is found, return the first element as it is the minimum
                return nums[0];
            }
            catch (Exception)
            {
                // Re-throw the exception if an error occurs
                throw;
            }
        }

        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
        {
            try
            {
                // Convert the integer to a string
                String number = Convert.ToString(x);

                // Reverse the string representation of the number
                String reverse = new String(number.Reverse().ToArray());

                // Check if the original string is equal to the reversed string
                return number == reverse;
            }
            catch (Exception)
            {
                // Re-throw the exception if an error occurs
                throw;
            }
        }

        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            {
                // Base case: return 0 if n is 0, return 1 if n is 1
                if (n == 0) { return 0; }
                else if (n == 1) { return 1; }

                // Recursively calculate the nth Fibonacci number by summing the two preceding numbers
                int result = Fibonacci(n - 1) + Fibonacci(n - 2);

                // Return the result
                return result;
            }
            catch (Exception)
            {
                // Re-throw the exception if an error occurs
                throw;
            }
        }
    }
}
