namespace Arrays
{
    internal class Playground
    {
        // string CollectionOfChars { get; set; }

        #region Methods
        internal void RetrunCollection(string word)
        {
            var CollectionOfChar = word.Split(",");

            //CollectionOfChar = word.Split();
            foreach (string letter in CollectionOfChar)
            {
                Console.WriteLine(letter);
            }
        }

        internal void PracticeArrays()
        {
            int[] numbers = new int[4];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;

            // Access last element
            Console.WriteLine(numbers[^1]);
            // Access the 2nd last element
            Console.WriteLine(numbers[^2]);

            // Calculate the sum of all elements in numbers
            int sum = 0;

            // iterate over every element in numbers, and add them one by one to sum
            foreach (int num in numbers)
            {
                sum += num;
            }
            Console.WriteLine($"Sum of numbers = {sum}");


            // Array Initializing
            string[] friendsList = { "Amjad", "Yanal", "Tamer" };



        }
        #endregion
    }
}
