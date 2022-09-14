while (playing)
{

  Console.WriteLine("Choose Rock, Paper, or Scissor!");
  string userChoice = Console.ReadLine();

  string keepPlaying = Console.ReadKey();
  if (keepPlaying == 'n')
  {
    playing = false;
  }
}