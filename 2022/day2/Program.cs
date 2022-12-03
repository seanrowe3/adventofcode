namespace AdventOfCode
{
    public class Program
    {
        static void Main(string[] args)
        {
           string[] lines = System.IO.File.ReadAllLines(@"C:\sourcecode\adventofcode\2022\day2\input\input.txt");

            int currentScore = 0;
            foreach (string line in lines)
            {
                if (line.Contains("A"))
                {
                    if (line.Contains("X")) currentScore += (0 + 3);
                    if (line.Contains("Y")) currentScore += (3 + 1);
                    if (line.Contains("Z")) currentScore += (6 + 2);
                }
                else if (line.Contains("B"))
                {
                    if (line.Contains("X")) currentScore += (0 + 1);
                    if (line.Contains("Y")) currentScore += (3 + 2);
                    if (line.Contains("Z")) currentScore += (6 + 3);
                }
                else if (line.Contains("C"))
                {
                    if (line.Contains("X")) currentScore += (0 + 2);
                    if (line.Contains("Y")) currentScore += (3 + 3);
                    if (line.Contains("Z")) currentScore += (6 + 1);
                }
            }
            Console.WriteLine($"TotalScore: {currentScore}!");
        }
    }
}

// A is Rock, X is lose (0pt), Rock is 1pt
// B is Paper, Y is draw(3pt), Paper is 2pt
// C is Scissors, Z is win(6pt), Scissor is 3pt