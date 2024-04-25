// using System;

// namespace EnthusiasticMoose
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//         }
//     }
// }

using System;

namespace EnthusiasticMoose
{
  class Program
  {
    static void Main(string[] args)
    {
      // Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
      // Console.WriteLine("--------------------------------------------");
      //       static void MooseSays(string message)
      //       {
      //         Console.WriteLine("what does the moose say? ");
      //         // string message = Console.ReadLine();
      //         Console.WriteLine($@"
      //                                        _.--^^^--,
      //                                     .'          `\
      //   .-^^^^^^-.                      .'              |
      //  /          '.                   /            .-._/
      // |             `.                |             |
      //  \              \          .-._ |          _   \
      //   `^^'-.         \_.-.     \   `          ( \__/
      //         |             )     '=.       .,   \
      //        /             (         \     /  \  /
      //      /`               `\        |   /    `'
      //      '..-`\        _.-. `\ _.__/   .=.
      //           |  _    / \  '.-`    `-.'  /
      //           \_/ |  |   './ _     _  \.'
      //                '-'    | /       \ |
      //                       |  .-. .-.  |
      //                       \ / o| |o \ /
      //                        |   / \   |    {message}
      //                       / `^`   `^` \
      //                      /             \
      //                     | '._.'         \
      //                     |  /             |
      //                      \ |             |
      //                       ||    _    _   /
      //                       /|\  (_\  /_) /
      //                       \ \'._  ` '_.'
      //                        `^^` `^^^`
      //     ");
      //       }
      // string input = Console.ReadLine();
      // MooseSays();
      // bool MooseAsks(string question)
      // {
      //   Console.Write($"{question} (Y/N): ");
      //   string answer = Console.ReadLine().ToLower();

      //   while (answer != "y" && answer != "n")
      //   {
      //     Console.Write($"{question} (Y/N): ");
      //     answer = Console.ReadLine().ToLower();
      //   }

      //   if (answer == "y")
      //   {
      //     return true;
      //   }
      //   else
      //   {
      //     return false;
      //   }
      // }
      // void CanadaQuestion()
      // {
      //   bool isTrue = MooseAsks("Is Canada Real?");
      //   // Console.WriteLine(isTrue);
      //   if (isTrue)
      //   {
      //     MooseSays("Really? It seems very unlikely");
      //   }
      //   else
      //   {
      //     MooseSays("I KNEW IT!!!");
      //   }
      // }
      // void EnthusiasticQuestion()
      // {
      //   bool isEnthusiastic = MooseAsks("Are you enthusiastic? ");
      //   if (isEnthusiastic)
      //   {
      //     MooseSays("That's great!");
      //   }
      //   else
      //   {
      //     MooseSays("Oh no! Terrible!");
      //   }
      // }
      // void LovesCSharpQuestion()
      // {
      //   bool doesLoveCSharp = MooseAsks("Do you love C# yet? ");
      //   if (doesLoveCSharp)
      //   {
      //     MooseSays("Good job!");
      //   }
      //   else
      //   {
      //     MooseSays("At least you're honest!");
      //   }
      // }
      // void SecretQuestion()
      // {
      //   bool wantsSecret = MooseAsks("Do you want to hear a secret? ");
      //   if (wantsSecret)
      //   {
      //     MooseSays("Me Too! I love secrets! Tell me one");
      //   }
      //   else
      //   {
      //     MooseSays("Oh, no way! Secrets are the best!");
      //   }
      // }
      // CanadaQuestion();
      // EnthusiasticQuestion();
      // LovesCSharpQuestion();
      // SecretQuestion();
      // void AskAnotherQuestion()
      // {
      //   Console.WriteLine("What is your next question for the great and powerful Moose? ");
      // }
      //   void MooseMagicEightball()
      //   {
      //     Console.WriteLine("what is your question for the moose? ");
      //     // Console.ReadLine();
      //     string[] answers = {
      //       "As I see it, yes.",
      //       "Ask again later.",
      //       "Better not tell you now.",
      //       "Cannot predict now.",
      //       "Concentrate and ask again.",
      //       "Don’t count on it.",
      //       "It is certain.",
      //       "It is decidedly so.",
      //       "Most likely.",
      //       "My reply is no.",
      //       "My sources say no.",
      //       "Outlook not so good.",
      //       "Outlook good.",
      //       "Reply hazy, try again.",
      //       "Signs point to yes.",
      //       "Very doubtful.",
      //       "Without a doubt.",
      //       "Yes.",
      //       "Yes – definitely.",
      //       "You may rely on it."
      //     };
      //     Random r = new Random();
      //     int genRand = r.Next(0, 19);
      //     // string chosenAnswer = answers[genRand];
      //     // Console.WriteLine(chosenAnswer);
      //     string question = Console.ReadLine();
      //     if (question != "")
      //     {
      //       MooseSays(answers[genRand]);
      //       MooseMagicEightball();
      //     }
      //     else 
      //     {
      //       Environment.Exit(0);
      //     }
      //   }
      //   MooseMagicEightball();
      // }
      string PrintRock()
      {
        return @"
            _______
        ---'   ____)
              (_____)
              (_____)
              (____)
        ---.__(___)
        ";
      }
      string PrintPaper()
      {
        return @"
            _______
        ---'    ____)____
                   ______)
                  _______)
                 _______)
        ---.__________)
        ";
      }
      string PrintScissors()
      {
        return @"
            _______
        ---'   ____)____
                  ______)
              __________)
              (____)
        ---.__(___)
        ";
      }
      int playerCount = 0;
      int compCount = 0;
      void AddToWinnerCount(int p, int c)
      {
        int[] outcomeArr = { p, c };
        int[,] playerWins = {
          {1, 3},
          {2, 1},
          {3, 2}
        };
        int[,] playerLoses = {
          {3, 1},
          {1, 2},
          {2, 3}
        };
        int[,] drawOutcome = {
          {3, 3},
          {2, 2},
          {1, 1}
        };
        for (int i = 0; i < playerWins.GetLength(0); i++)
        {
          if (playerWins[i, 0] == outcomeArr[0] && playerWins[i, 1] == outcomeArr[1])
          {
            playerCount++;
            Console.WriteLine("VICTORY!!");
            break;
          }
          else if (playerLoses[i, 0] == outcomeArr[0] && playerLoses[i, 1] == outcomeArr[1])
          {
            compCount++;
            Console.WriteLine("darn. no luck");
            break;
          }
          else if (drawOutcome[i, 0] == outcomeArr[0] && drawOutcome[i, 1] == outcomeArr[1])
          {
            Console.WriteLine("ITS A DRAW!");
            break;
          }
        }
      }
      void RockPaperScissors()
      {
        if (playerCount == 0 && compCount == 0)
        {
          Console.WriteLine($"-----------------------------\n| Player: {playerCount} | Computer: {compCount} |\n----------------------------- What would you like to throw? \n 1) Rock\n 2) Paper\n 3) Scissors\n 4) Exit");
        }
        else
        {
          Console.WriteLine(@"Again?
            1) Rock
            2) Paper
            3) Scissors
            4) Exit");
        }
        string selection = Console.ReadLine();

        int numberSelection;
        bool success = int.TryParse(selection, out numberSelection);
        int[] potentials = { 1, 2, 3, 4 };
        bool exists = Array.Exists(potentials, x => x == numberSelection);

        Func<string>[] printingOptions = { PrintRock, PrintPaper, PrintScissors };
        int computerSelection = new Random().Next(1, 3);
        if (success && exists)
        {
          Func<string> userAnswer;
          Func<string> computerAnswer;
          if (numberSelection == 4)
          {
            Environment.Exit(0);
          }
          else
          {
            userAnswer = printingOptions[numberSelection - 1];
            computerAnswer = printingOptions[computerSelection - 1];
            AddToWinnerCount(numberSelection, computerSelection);
            Console.WriteLine($"\n\n{userAnswer()}\n\n{computerAnswer()}");
            RockPaperScissors();
          }
        }
        else
        {
          Console.WriteLine("try again");
        }
      }
      RockPaperScissors();
    }
  }
}
