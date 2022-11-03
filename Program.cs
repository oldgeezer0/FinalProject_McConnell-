public class RoShamBo
{
    public int player;
    public bool gameComplete;
    public static void Main(string[] args)
    {
        RoShamBo y = new RoShamBo();
        while (true)
        {
            while (!y.gameComplete)
            {

                Console.WriteLine("\n~~~~~~~RoShamBo~~~~~~\n");
                Console.WriteLine("Press Enter to Start");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("    _______\r\n---'   ____)\r\n      (_____)\r\n      (_____)\r\n      (____)\r\n---.__(___)\n\n#1                        \r\n    _______\r\n---'    ____)____\r\n           ______)\r\n          _______)\r\n         _______)\r\n---.__________)\n\n#2                            \r\n    _______\r\n---'   ____)____\r\n          ______)\r\n       __________)\r\n      (____)\r\n---.__(___)\n\n#3");
                int pick = 0;
                int player = 0;
                bool acceptableResponse = false;
                while (acceptableResponse == false)
                {
                    Console.WriteLine("\nRock, Paper, or Scissors?");
                    string Pick = Console.ReadLine();

                    try
                    {
                        pick = Int32.Parse(Pick);
                        if (pick == 1)
                        {
                            player = 1;
                            acceptableResponse = true;
                        }
                        else if (pick == 2)
                        {
                            player = 2;
                            acceptableResponse = true;
                        }
                        else if (pick == 3)
                        {
                            player = 3;
                            acceptableResponse = true;
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Please type the number corresponding to the symbol");
                    }


                }
                switch (player)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("    _______\r\n---'   ____)\r\n      (_____)\r\n      (_____)\r\n      (____)\r\n---.__(___)\nYour Symbol");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\r\n    _______\r\n---'    ____)____\r\n           ______)\r\n          _______)\r\n         _______)\r\n---.__________)\nYour Symbol  ");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine(" \r\n    _______\r\n---'   ____)____\r\n          ______)\r\n       __________)\r\n      (____)\r\n---.__(___)\nYour Symbol");
                        break;
                }
                Random rng = new Random();
                int computer = rng.Next(1, 4);
                switch (computer)
                {
                    case 1:
                        Console.WriteLine("    _______\r\n---'   ____)\r\n      (_____)\r\n      (_____)\r\n      (____)\r\n---.__(___)\nComputer Symbol");
                        break;
                    case 2:
                        Console.WriteLine("\r\n    _______\r\n---'    ____)____\r\n           ______)\r\n          _______)\r\n         _______)\r\n---.__________)\nComputer Symbol  ");
                        break;
                    case 3:
                        Console.WriteLine(" \r\n    _______\r\n---'   ____)____\r\n          ______)\r\n       __________)\r\n      (____)\r\n---.__(___)\nComputer Symbol");
                        break;
                }



                if (computer == player)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nYou Have Tied!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(1000);
                    Console.WriteLine("\n\nPlease Wait For the Next Round");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                if (computer == 1 && player == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nYou Have Won");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(1000);
                    Console.WriteLine("\n\nPlease Wait For the Next Round");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                if (computer == 2 && player == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nYou Have Won");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(1000);
                    Console.WriteLine("\n\nPlease Wait For the Next Round");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                if (computer == 3 && player == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nYou Have Lost");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(1000);
                    Console.WriteLine("\n\nPlease Wait For the Next Round");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                if (computer == 1 && player == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nYou Have Lost");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(1000);
                    Console.WriteLine("\n\nPlease Wait For the Next Round");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                if (computer == 2 && player == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nYou Have Lost");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(1000);
                    Console.WriteLine("\n\nPlease Wait For the Next Round");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                if (computer == 3 && player == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nYou Have Won");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(1000);
                    Console.WriteLine("\n\nPlease Wait For the Next Round");
                    Thread.Sleep(3000);
                    Console.Clear();
                }

            }

        }

    }


}


