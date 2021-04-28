using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            cgpaCalc();

        }

        private static void cgpaCalc()
        {
            double[] scores = new double[5];
            double cgpa, sum = 0d, percentage;
            string percentageStr=null;
            for (int i = 0; i < scores.Length; i++)
            {


                Console.Write($"Enter your score: ");
                string input = Console.ReadLine();
                if (!double.TryParse(input, out scores[i]))
                {
                    // Tell the user something went wrong:
                    Console.WriteLine($"Sorry, '{input}' is not a valid number.");

                    // Don't move to the next array element:
                    i--;
                }


            }
            Console.Write($"Your Scores are: ");
            foreach (var i in scores)
            {
                Console.Write($"{i}, ");
            }

            Console.WriteLine("Please check if scores are correct");
            Console.Write("If correct, Enter 'Yes' to continue or 'No' to start again:  ");
            string ans = Console.ReadLine();
            if (ans.ToLower() == "yes")
            {
                for (int i = 0; i < scores.Length; i++)
                {
                    scores[i] = scores[i] / 10;

                }
                for (int i = 0; i < scores.Length; i++)
                {
                    sum += scores[i];
                }

                cgpa = sum / 5;
                percentage = Math.Round(cgpa * 9.5, 2);
                Console.WriteLine($"Your CGPA is: {cgpa}");
                Console.WriteLine($"Your CGPA Percentage is: {percentage}");
                Console.ReadKey();
            }
            while (ans.ToLower() != "yes" && ans.ToLower() != "no")
            {
                Console.WriteLine("Invalid option");
                Console.WriteLine("Please check if scores are correct");
                Console.Write("If correct, Enter 'Yes' to continue or 'No' to start again");
                ans = Console.ReadLine();
            }
            if (ans.ToLower() == "no")
            {

                cgpaCalc();


            }
        }
    
    }
}
