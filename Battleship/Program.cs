using MyBattleShip;
public class game
{

    public static void Main(string[] args)
    {
        //Set up board and print welcome
        BattleShip battle = new BattleShip();
        BattleShip b = new BattleShip();
        Console.WriteLine("Welcome to Battleship!\n");
        bool addNew = true;

        while (addNew)
        {
            Console.WriteLine("Type \"a\" to add new ship, \"b\" to see the board, \"p\" to play, or \"q\" to quit.");
            string ans = Console.ReadLine();
            if (ans.ToLower().Equals("q"))
            {
                return;
            }
            if (ans.ToLower().Equals("a"))
            {
                //Get parameters for new ship
                Console.WriteLine("Starting in which row?");
                int r = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Starting in which column?");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How Long?");
                int l = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Horizontal (h) or Vertical (v)?");
                string d = Console.ReadLine();
                bool h = (d.ToLower().Equals("h"));

                //call addship and retrun message based on t/f
                if (battle.addShip(r, c, l, h))
                {
                    Console.WriteLine("\nNew ship added!\n");
                }
                else { Console.WriteLine("\n Can\'t put a ship there.\n"); }




            }

            else if (ans.ToLower().Equals("b"))
            {
                Console.WriteLine("\n" + b.toString() + "\n");
            }
            if (ans.ToLower().Equals("p"))
            {
                if (b.foundShip(3) && b.foundShip(4))
                {
                    addNew = false;
                    Console.WriteLine("\nOk let\'s play!\n");
                }
                else
                {
                    Console.WriteLine("\nYou need ships of length 3 and 4 to play!\n");
                }


            }




        }
        while (!b.gameOver())
        {

            Console.WriteLine("Press \"s\" to shoot at a square, \"b\" to see the board, \"q\" to quit.");
            string ans = Console.ReadLine();
            if (ans.ToLower().Equals("q")) { return; }

            else if (ans.ToLower().Equals("s"))
            {
                //get r and c to shoot
                Console.WriteLine("Input row");
                int r = Convert.ToInt32(Console.ReadLine);
                Console.WriteLine("Input column");
                int c = Convert.ToInt32(Console.ReadLine);

                int result = b.shoot(r, c);

                if (result == 1)
                {
                    Console.WriteLine("\nHit!\n");
                }
                else if (result == 0)
                {
                    Console.WriteLine("\nMiss!\n");
                }
                else if (result == 2)
                {
                    Console.WriteLine("\nAlready guessed\n");
                }
                else if (result == -1)
                {
                    Console.WriteLine("\nInvalid coordinates. \n");
                }





            }
            else if (ans.ToLower().Equals("B"))
            {
                Console.WriteLine("\n" + b.toString() + "\n");
            }
        }

        Console.WriteLine("Game over!");

    }









}
