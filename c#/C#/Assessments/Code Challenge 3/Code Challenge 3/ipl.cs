using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_3
{
    class CricketTeam
    {
        public (int count, int sum, double average) Pointscalculation(int no_of_matches)
        {
            int[] scores = new int[no_of_matches];
            int sum = 0;
            for (int i = 0; i < no_of_matches; i++)
            {
                Console.Write($"Enter score for match {i + 1}: ");
                scores[i] = Convert.ToInt32(Console.ReadLine());
                sum += scores[i];
            }
            double average = (double)sum / no_of_matches;
            return (no_of_matches, sum, average);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter number of matches: ");
            int matches = Convert.ToInt32(Console.ReadLine());
            CricketTeam team = new CricketTeam();
            var result = team.Pointscalculation(matches);
            Console.WriteLine("\n--- Result ---");
            Console.WriteLine("Total Matches: " + result.count);
            Console.WriteLine("Sum of Scores: " + result.sum);
            Console.WriteLine("Average Score: " + result.average);
        }
    }
}
