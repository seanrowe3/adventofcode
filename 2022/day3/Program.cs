namespace AdventOfCode
{
    public class Program
    {
        static void Main(string[] args)
        {
           string[] lines = System.IO.File.ReadAllLines(@"C:\sourcecode\adventofcode\2022\day3\input\input.txt");

            int prioritySum = 0;
            for (int i = 0; i < lines.Count(); i += 3)
            {
                char common = FindCommonChar(lines[i], lines[i+1], lines[i+2]);
                int priority = (int)common % 32;
                if (Char.IsUpper(common)){
                    priority = priority + 26;
                }
                prioritySum += priority;
            }
            Console.WriteLine($"PrioritySum: {prioritySum}!");
        }

        static char FindCommonChar(string s1, string s2, string s3)
        {
            foreach(char c in s1){
                foreach(char d in s2){
                    foreach(char e in s3){
                        if (c == d && d == e){
                            return c;
                        }
                    }
                }
            }
            return '\n';
        }
    }
}