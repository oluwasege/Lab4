using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] score = new int[5];
            double[] scores = new double[5];
            double cgpa, sum = 0, percentage;
            string[] position = { "1st", "2nd", "3rd", "4th", "5th" };


            for (int i = 0; i < scores.Length; i++)
            {


                Console.Write($"Enter  scores: ");
                string input = Console.ReadLine();
                if (!double.TryParse(input, out scores[i]))
                {
                    // Tell the user something went wrong:
                    Console.WriteLine($"Sorry, '{input}' is not a valid number.");

                    // Don't move to the next array element:
                    i--;
                }


            }


            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = scores[i] / 10;

            }
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }

            cgpa = sum / 5;
            percentage = cgpa * 9.5;
            Console.WriteLine(cgpa);
            foreach (var i in scores)
            {
                Console.WriteLine(i);
            }

            //var res = scores.Zip(position, (n, w) => new { Number = n, Word = w });
            //int index = 0;
            //foreach(var i in res)
            //{
            //    Console.Write($"Enter your {i.Word} score: ");
            //    var input = Console.ReadLine();

            //    while (!int.TryParse(input, out scores[i.Number]))
            //    {
            //        // Tell the user something went wrong:
            //        Console.WriteLine($"Sorry, '{input}' is not a valid number.");

            //        // Don't move to the next array element:
            //        Console.Write($"Enter your {i.Word} score: ");
            //        input = Console.ReadLine();
            //    }
            //    scores[i.Number] = Convert.ToInt32(index);
            //    index++;


            //}

            //foreach (var i in res)
            //{
            //    Console.WriteLine(i);
            //}




        }
    
    }
}
