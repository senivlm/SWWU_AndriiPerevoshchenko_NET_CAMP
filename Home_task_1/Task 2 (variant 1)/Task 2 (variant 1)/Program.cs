namespace Task_2_variant_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Colours item = new Colours(10, 10);
            item.MakeRandomPicture();
            Console.WriteLine(item.ToString());
            item.FindPopulars();
            Console.WriteLine($"Row: {item.RowIndex}, Begin: {item.BeginIndex}, End: {item.BeginIndex + item.MaxSize - 1}, Size: {item.MaxSize}, Element: {item.Element}");
        }
    }
}