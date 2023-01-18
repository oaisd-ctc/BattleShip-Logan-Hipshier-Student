/* NOTES & TODO:
1. !!FIX ASAP!! The board doesn't update and display the placed ships
2. !!FIX ASAP!! Game does not recognize the user input, cannot play
*/
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

        Console.Clear();
        while (addNew)
        {
            Console.WriteLine("Type \"p\" to play, or \"q\" to quit.");
            string ans = Console.ReadLine();
            if (ans.ToLower().Equals("q"))
            {
                return;
            }
           /* if (ans.ToLower().Equals("a"))
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




            }*/
            Random rand = new Random();
            int r1 = rand.Next(0,11);
            int c1 = rand.Next(0,11);
            int l1 = 3;
            int h1int= rand.Next(0,2);
            bool h1 = false;
            if(h1int == 0){h1 = true;}
            while(!b.addShip(r1, c1, l1, h1)){
                r1 = rand.Next(0,11);
                c1 = rand.Next(0,11);
                h1int= rand.Next(0,2);
                h1 = false;
                if(h1int == 0){h1 = true;}
                }
                

            int r2 = rand.Next(0,11);
            int c2 = rand.Next(0,11);
            int l2 = 4;
            int h2int= rand.Next(0,2);
            bool h2 = false;
            if(h2int == 0){h2 = true;}
            while(!b.addShip(r2, c2, l2, h2)){
                r2 = rand.Next(0,11);
                c2 = rand.Next(0,11);
                h2int= rand.Next(0,2);
                h2 = false;
                if(h2int == 0){h2 = true;}

            }
            int r3 = rand.Next(0,11);
            int c3 = rand.Next(0,11);
            int l3 = 5;
            int h3int= rand.Next(0,2);
            bool h3 = false;
            if(h3int == 0){h3 = true;}
            while(!b.addShip(r3, c3, l3, h3)){
                r3 = rand.Next(0,11);
                c3 = rand.Next(0,11);
                h3int= rand.Next(0,2);
                h3 = false;
                if(h3int == 0){h3 = true;}

            }

                Console.WriteLine("\n" + b.toString() + "\n");
                Console.WriteLine("\n" + b.playertoString() + "\n");


            /*else if (ans.ToLower().Equals("b"))
            {
                Console.WriteLine("\n" + b.toString() + "\n");
            }*/
            if (ans.ToLower().Equals("p"))
            {
                
                    addNew = false;
                    Console.WriteLine("\nOk let\'s play!\n");
                    Console.WriteLine("Destroy all 3 enemy ships to win!");
                    Console.WriteLine("Lengths of 3, 4, and 5");
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
                Console.WriteLine("Input row (0-9)");
                string r1 = Console.ReadLine();
                int r = Convert.ToInt32(r1);
                Console.WriteLine("Input column (0-9)");
                string c1 = Console.ReadLine();
                int c = Convert.ToInt32(c1);

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
            else if (ans.ToLower().Equals("b"))
            {
                Console.WriteLine("\n" + b.playertoString() + "\n");
            }
            else if (ans.ToLower().Equals("z"))
            {
                Console.WriteLine("\n" + b.toString() + "\n");
            }
        }

        Console.WriteLine("Game over!");
        Console.WriteLine("You Win!");

    }









}
