using HT_23._03._23;

namespace Task_2__variant_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ColourfulMatrix test = new ColourfulMatrix(20, 20);
            test.MakeRandomPicture();
            Console.WriteLine(test);
            test.FindTheLargestSubsequence();
            Console.WriteLine($"Row: {test.RowIndex}, Begin: {test.BeginIndex}, End: {test.BeginIndex + test.MaxSize - 1}, Size: {test.MaxSize}, Element: {test.PopularElement}");
        }
    }
}