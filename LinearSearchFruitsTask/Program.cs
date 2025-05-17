namespace LinearSearchFruitsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "banana", "apple", "orange", "pear", "grape", "pineapple" };

            Console.WriteLine("What word would you like to find?");
            string word = Console.ReadLine();
            if (word == fruits[0])
            {
                Console.WriteLine("The word " + fruits[0] + " has been found in the array");
            }
            if (word == fruits[1])
            {
                Console.WriteLine("The word " + fruits[1] + " has been found in the array");
            }
            if (word == fruits[2])
            {
                Console.WriteLine("The word " + fruits[2] + " has been found in the array");
            }
            if (word == fruits[3])
            {
                Console.WriteLine("The word " + fruits[3] + " has been found in the array");
            }
            if (word == fruits[4])
            {
                Console.WriteLine("The word " + fruits[4] + " has been found in the array");
            }
            if (word == fruits[5])
            {
                Console.WriteLine("The word" + fruits[5] + "has been found in the array");
            }
            else 
             { Console.WriteLine("Your word has not been found"); }




            // Your program should:
            // Ask the user what word they would like to find
            // Output the message True if the word is found
            // Output the message False if the word is not found

            // You must write your own linear search routine and not use any built-in fuctions available in C#
            // You should use meaningful variable names

            
        }
    }
}
