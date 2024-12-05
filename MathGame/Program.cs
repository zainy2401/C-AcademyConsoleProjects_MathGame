using System.Threading.Tasks.Sources;

namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> history = new Dictionary<string, int>();
            bool exit = false;
            int score = 0;
            while (!exit)
            {
                Console.WriteLine("\nHello! Welcome to the Math Game. Please choose from an option below");
                Console.Write("1. View Previous Games \n");
                Console.Write("2. Addition Game \n");
                Console.Write("3. Subtraction Game \n");
                Console.Write("4. Multiplication Game \n");
                Console.Write("5. Division Game \n");
                Console.Write("6. Leave Applicaiton \n");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Here are the latest games: ");
                        foreach(var i in history)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                    case 2:
                        score = additionGame();
                        history.Add("Addition Game", score);
                        break;
                    case 3:
                        score = subtractionGame();
                        history.Add("Subtraction Game", score);
                        break;
                    case 4:
                        score = multiplicationGame();
                        history.Add("Multiplication Game", score);
                        break;
                    case 5:
                        score = divisionGame();
                        history.Add("Division Game", score);
                        break;
                    case 6:
                        exit = true;
                        break;
                }
            }
        }
        //Addition Method
        static int additionGame()
        {
            int score = 0;
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int fNum = rnd.Next(0, 101);
                int sNum = rnd.Next(0, 101);
                int answer = fNum + sNum;
                Console.WriteLine("\n{0})What is {1} + {2}?", (i+1), fNum, sNum);
                int userAnswer = Convert.ToInt32(Console.ReadLine());
                if (userAnswer == fNum + sNum) {
                    score++;
                    Console.WriteLine("Correct! Your score is now {0}", score);
                }
                else
                {
                    Console.WriteLine("Incorrect! The answer was {0}, your score is still {1}", answer, score);
                }
            }
            Console.WriteLine("\nYour total highscore for this game was {0}", score);
            return score;
        }
        //Subtraction Method
        static int subtractionGame()
        {
            int score = 0;
            Random rnd = new Random();
            for (int i = 0;i < 10; i++)
            {
                int fNum = rnd.Next(0, 101);
                int sNum = rnd.Next(0, 101);
                int answer = fNum - sNum;
                Console.WriteLine("\n{0})What is {1} - {2}", (i+1), fNum, sNum);
                int userAnswer = Convert.ToInt32(Console.ReadLine());
                if(userAnswer == fNum - sNum)
                {
                    score++;
                    Console.WriteLine("Correct! Your score is now {0}", score);
                }
                else
                {
                    Console.WriteLine("Incorrect! The answer was {0}, your score is still {1}", answer, score);
                }
            }
            Console.WriteLine("\nYour total highscore for this game was {0}", score);
            return score;
        }
        //Mulitiplication Method
        static int multiplicationGame()
        {
            int score = 0;
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int fNum = rnd.Next(0, 101);
                int sNum = rnd.Next(0, 101);
                int answer = fNum * sNum;
                Console.WriteLine("\n{0})What is {1} x {2}", (i + 1), fNum, sNum);
                int userAnswer = Convert.ToInt32(Console.ReadLine());
                if (userAnswer == fNum * sNum)
                {
                    score++;
                    Console.WriteLine("Correct! Your score is now {0}", score);
                }
                else
                {
                    Console.WriteLine("Incorrect! The answer was {0}, your score is still {1}", answer, score);
                }
            }
            Console.WriteLine("\nYour total highscore for this game was {0}", score);
            return score;
        }
        //Division Method
        static int divisionGame()
        {
            int score = 0;
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int fNum = rnd.Next(0, 101);
                int sNum = rnd.Next(0, 101);
                while ((double)fNum%(double)sNum > 0 || sNum == 0)
                {
                    fNum = rnd.Next(0, 101);
                    sNum = rnd.Next(0, 101);
                }
                int answer = fNum / sNum;
                Console.WriteLine("\n{0})What is {1} / {2}", (i + 1), fNum, sNum);
                int userAnswer = Convert.ToInt32(Console.ReadLine());
                if (userAnswer == fNum / sNum)
                {
                    score++;
                    Console.WriteLine("Correct! Your score is now {0}", score);
                }
                else
                {
                    Console.WriteLine("Incorrect! The answer was {0}, your score is still {1}", answer, score);
                }
            }
            Console.WriteLine("\nYour total highscore for this game was {0}", score);
            return score;
        }
    }
}
