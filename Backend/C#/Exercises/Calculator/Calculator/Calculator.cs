namespace Calculator
{
    internal class Calculator
    {
        #region Properties
        public int FirstEntry { get; set; }
        public int SecondEntry { get; set; }

        #endregion

        #region Methods
        public int CalculateResult(int firstEntry, int secondEntry)
        {
            int result = 0;

            Console.Write("Entry first value: ");
            firstEntry = int.Parse(Console.ReadLine());



            return result;
        }
        #endregion
    }
}
