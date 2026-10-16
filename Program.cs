using System;

namespace QuizGame
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayWelcome();
            int score = PlayQuiz();
            DisplayResult(score, 3);
        }

        static void DisplayWelcome()
        {
            Console.WriteLine("=== Computer Science Quiz ===");
            Console.WriteLine("Answer each question and press Enter.");
            Console.WriteLine();
        }

        static bool AskQuestion(string question, string correctAnswer)
        {
            Console.WriteLine(question);
            Console.Write("Your answer: ");
            string answer = Console.ReadLine();

            if (answer != null && answer.Trim().ToLower() == correctAnswer.ToLower())
            {
                Console.WriteLine("Correct!");
                Console.WriteLine();
                return true;
            }

            Console.WriteLine($"Wrong. The answer was {correctAnswer}.");
            Console.WriteLine();
            return false;
        }

        static int PlayQuiz()
        {
            int score = 0;

            if (AskQuestion("What does CPU stand for?", "central processing unit"))
            {
                score++;
            }
            if (AskQuestion("How many bits are in a byte?", "8"))
            {
                score++;
            }
            if (AskQuestion("What is the base of the binary number system?", "2"))
            {
                score++;
            }
            if (AskQuestion("What does RAM stand for?", "random access memory"))
            {
                score++;
            }
            if (AskQuestion("What does USB stand for?", "universal serial bus"))
            {
                score++;
            }

            return score;
        }

        static void DisplayResult(int score, int total)
        {
            double percent = (double)score / total * 100;
            Console.WriteLine($"You scored {score} out of {total} ({percent:F0}%).");
        }

        static void GetGrade(double percent)
        {
            if (percent >= 90)
            {
                Console.WriteLine("Distinction");
            }
            else if (percent >= 70)
            {
                Console.WriteLine("Merit");
            }
            else if (percent >= 60)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}