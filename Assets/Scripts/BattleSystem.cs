using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our battle system, so being able to calculate the percentage chance of us winning.
/// As well as determine which of the two characters has won a fight, or if it's a draw
/// </summary>
public class BattleSystem : MonoBehaviour
{
    private void Start()
    {
        // let's start by setting our player dancing stats to random numbers
        // style should be random between 1-10
        public Random.int playerOneStyle = 1-11;
        // luck should be random between 0-4
        public Random.int playerOneLuck = 0-5;
        // ryhtm should be random between 1-6
        public Random.int playerOneRyhtm = 1-7;
        // style should be random between 1-10
        public Random.int playerTwoStyle = 1-11;
        // luck should be random between 0-4
        public Random.int playerTwoLuck = 0-5;
        // ryhtm should be random between 1-6
        public Random.int playerTwoRyhtm = 1-6;

        // let's set our player power levels, using an algorithm, the simpliest would be luck + style + rhythm
        // this algorthim should be the same for each character to keep it fair.
        public int playerOnePowerLevel = playerOneLuck + playerOneStyle + playerOneRyhtm;
        public int playerTwoPowerLevel = playerTwoLuck + playerTwoStyle + playerTwoRyhtm;

        // Debug out the two players, power levels.
<<<<<<< Updated upstream
=======
        Debug.Log("playerOne power level is" + playerOnePowerLevel);
        Debug.Log("playerTwo power level is" + playerTwoPowerLevel);
>>>>>>> Stashed changes

        // calculate the percentage chance of winning the fight for each character.
        // todo this you'll need to add the two powers together, then divide you characters power against this and multiply the result by 100.
        int totalPower = 0;
        int playerOneChanceToWin = 0;
        int playerTwoChanceToWin = 0;

        // Debug out the chance of each character to win.
<<<<<<< Updated upstream

        // We probably want to compare the powers of our characters and decide who has a higher power level; I just hope they aren't over 9000.  
=======
        Debug.Log("playerOne has =" + playerOneChanceToWin);
        Debug.Log("playerTwo has =" + playerTwoChanceToWin);
>>>>>>> Stashed changes

        // We probably want to compare the powers of our characters and decide who has a higher power level; I just hope they aren't over 9000.  
        // Debug out which character has won, which has lost, or if it's a draw. 
        if (playerOnePowerLevel > playerTwoPowerLevel)
        {
            Debug.Log ("player One WINS");
        }
        else if (playerTwoPowerLevel > playerOnePowerLevel)
        {
            Debug.Log("player Two WINS");
        }
        else if (playerOnePowerLevel==playerTwoPowerLevel)
        {
            Debug.Log("This battle is a draw,");
        }
            
        
        // Debug out how much experience they should gain based on the difference of their chances to win, or if it's a draw award a default amount.
    }
}
