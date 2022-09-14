// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

bool rockPaperScissor = true;
int userScore = 0;
int computerScore = 0;

while (rockPaperScissor)
{
  Console.WriteLine("Time to play... ROCK, PAPER, SCISSORS!!!!");
  Console.WriteLine("1.Rock");
  Console.WriteLine("2.Paper");
  Console.WriteLine("3.Scissors");

  string? Choice = Console.ReadLine();

  Random randomChoice = new Random();
  List<string> possibleChoices = new List<string> {
    "rock",
    "paper",
    "scissor",
  };
  int computerChoice = randomChoice.Next(1, 4);

  switch (computerChoice)
  {
    case 1:
      break;
    case 2:
      break;
    case 3:
      break;
  }

case 1:
    if (Choice == "1")
  {
    Console.WriteLine("User chose Rock");
    Console.WriteLine("Computer chose Rock");
    Console.WriteLine("It is a tie.");
  }

  else if (Choice == "2")
  {
    Console.WriteLine("User chose Paper");
    Console.WriteLine("Computer chose Rock");
    Console.WriteLine("User wins");
    userScore++;
  }
  else if (Choice == "3")
  {
    Console.WriteLine("User chose Scissors");
    Console.WriteLine("Computer chose Rock");
    Console.WriteLine("Computer wins");
    computerScore++;
  }
  break;
case 2:
    if (Choice == "1")
  {

    //this is a tie
    Console.WriteLine("User chose Rock");
    Console.WriteLine("Computer chose Rock");
    Console.WriteLine("It is a tie");
  }

  else if (Choice == "2")
  {
    Console.WriteLine("User chose Paper");
    Console.WriteLine("Computer chose Rock");
    Console.WriteLine("User wins");
    userScore++;
  }
  else if (Choice == "3")
  {
    Console.WriteLine("User chose Scissors");
    Console.WriteLine("Computer chose Rock");
    Console.WriteLine("Computer wins");
    computerScore++;
  }
  break;
case 3:
    if (Choice == "1")
  {
    Console.WriteLine("User chose Rock");
    Console.WriteLine("Computer chose Scissors");
    Console.WriteLine("User wins.");
    userScore++;
  }

  else if (Choice == "2")
  {
    Console.WriteLine("User chose Paper");
    Console.WriteLine("Computer chose Scissors");
    Console.WriteLine("Computer wins");
    computerScore++;
  }
  else if (Choice == "3")
  {
    Console.WriteLine("User chose Scissors");
    Console.WriteLine("Computer chose Scissors");
    Console.WriteLine("It is a tie");
  }
  break;

  Console.WriteLine("Do you wish to play again?");
  Console.WriteLine("Enter Y or N");

}

