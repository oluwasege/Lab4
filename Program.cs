using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many scores do you want to calculate: ");
            int n = Convert.ToInt32(Console.ReadLine());
            cgpaCalc(n);

        }

        private static void cgpaCalc(int n)
        {
            double[] scores = new double[n];
            double cgpa, sum = 0d, percentage;
           // string percentageStr=null;
            for (int i = 0; i < n; i++)
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
            while (ans.ToLower() != "yes" && ans.ToLower() != "no")
            {
                Console.Clear();
                Console.WriteLine("Invalid option");
                Console.WriteLine();
                Console.Write($"Your Scores are:  ");
                foreach (var i in scores)
                {
                    Console.Write($"{i}, ");
                }
                Console.WriteLine("Please check if scores are correct");
                Console.Write("If correct, Enter 'Yes' to continue or 'No' to start again :");
                ans = Console.ReadLine();
            }
            if (ans.ToLower() == "yes")
            {
                for (int i = 0; i < n; i++)
                {
                    scores[i] = scores[i] / 10;

                }
                for (int i = 0; i < n; i++)
                {
                    sum += scores[i];
                }

                cgpa = sum / n;
                percentage = Math.Round(cgpa * 9.5, 2);
                Console.WriteLine($"Your CGPA is: {cgpa}");
                Console.WriteLine($"Your CGPA Percentage is: {percentage}");
                Console.ReadKey();
            }
            
            else if (ans.ToLower() == "no")
            {
                Console.Clear();
                Console.Write("How many scores do you want to calculate: ");
                n = Convert.ToInt32(Console.ReadLine());
                cgpaCalc(n);


            }
            
        }
    
    }
}
