// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
           string[] lines = System.IO.File.ReadAllLines(@"C:\sourcecode\adventofcode\2022\day1\input\input.txt");

            List<int> elfValues = new List<int>();
            int currentElf = 0;
            foreach (string line in lines)
            {
                if (line.Equals(string.Empty))
                {
                    elfValues.Add(currentElf);
                    currentElf = 0;
                }
                else 
                {
                    currentElf += (Int32.Parse(line));
                }
            }
            elfValues.Sort((x, y) => y.CompareTo(x));;
            Console.WriteLine("Top three elves by calorie: " + elfValues[0] + ", " + elfValues[1] + ", " + elfValues[2]);
            Console.WriteLine("Top three elves added: " + (elfValues[0] + elfValues[1] + elfValues[2]));
        }
    }
}
