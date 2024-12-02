namespace Assignment5_1_3
{
    internal class Program
    {
        // Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
        static void Main(string[] args)
        {
            int[] intArr = { 1, 2, 3, 4, 5, 6, 7, 8, 2 }; // True
            int[] intArr2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // False
            int[] intArr3 = { 1, 1, 1, 4, 3, 3, 7, 8, 7 }; // True
            PrintPrompt(intArr);
            PrintPrompt(intArr2);
            PrintPrompt(intArr3);
        }

        // If the hashset's count is equal to the array length, the array has all unique values, else false.
        static bool IsArrayNotUnique(int[] intArr)
        {
            HashSet<int> intSet = new HashSet<int>(intArr);

            return !(intSet.Count == intArr.Length);
        }

        // Prints array to console
        static void PrintArr(int[] intArr)
        {
            Console.Write("|");
            foreach (int i in intArr)
            {
                Console.Write($" {i} |");
            }
            Console.WriteLine();
        }

        // Prints a tailored prompt and response for the int array
        static void PrintPrompt(int[] intArr)
        {
            Console.WriteLine();
            Console.WriteLine("<=============NEW LINE==============>");
            Console.WriteLine("Does the array have duplicate values?");
            PrintArr(intArr);
            Console.Write("This array is: ");
            Console.WriteLine(IsArrayNotUnique(intArr));
        }
    }
}