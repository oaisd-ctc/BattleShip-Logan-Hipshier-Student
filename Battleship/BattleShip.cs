namespace MyBattleShip
{

    public class BattleShip
    {
        private string[,] squares;

        public void Board()
        {
            squares = new String[10, 10];
            for (int i = 0; i < squares.GetLength(0); i++)
            {
                for (int k = 0; k < squares.GetLength(1); k++)
                {
                    squares[i, k] = "-";

                }
            }
        }

        public string toString()
        {
            string Output = "";
            for (int i = 0; i < squares.GetLength(0); i++)
            {
                for (int k = 0; k < squares.GetLength(1); k++)
                {
                    Output += squares[i, k] + " ";

                }
                Output += "\n";
            }
            return Output;
        }

        public bool addShip(int row, int col, int len, bool horizontal)
        {
            // If ship is off grid return false
            if (row < 0 || col < 0 || row >= squares.GetLength(1) || col >= squares.GetLength(0))
            {
                return false;
            }
            //if horizonantal check if ship fits on grid
            if (horizontal)
            {
                if (col + len > squares.GetLength(0))
                {
                    return false;
                }
                // check if ship is in way
                for (int c = col; c < col + len; c++)
                {
                    if (!squares[row, c].Equals("-"))
                    {
                        return false;

                    }
                }
                for (int c = col; c < col + len; c++)
                {
                    squares[row, c] = "b";
                }


            }

            //vertical checks
            else
            {
                if (row + len > squares.GetLength(0)) { return false; }
                //check to see if another ship is in the way
                for (int r = row; r < row + len; r++)
                {
                    if (!squares[r, col].Equals("-")) { return false; }


                }
                for (int r = row; r < row + len; r++)
                {
                    squares[r, col] = "b";
                }




            }

            return true;

        }

        
        public bool foundShip(int len){
            for(int i = 0; i<squares.GetLength(0);i++){
                int counter =0;
                while(counter<squares.GetLength(1)){
                    int foundLen=0;
                    while(counter<squares.GetLength(1)&&squares[i,counter].Equals("b")){
                        foundLen++;
                        counter++;
                    }
                    if(foundLen==len)
                    { //this could be wrong, if fails check here
                        return true;
                    foundLen=0;
                    counter++;
                    }


                }

            }
            for(int k =0;k<squares.GetLength(1);k++){
                int counter = 0;
            }




        }



    
    
    
    
    
    
    
    
    
    }
}

