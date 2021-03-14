using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Author: Nicholas Sixbury
 * File: TravelRoller.cs
 * Purpose: To automate the daily rolling I do for travelling rules in
 * GURPS
 */

namespace EasyTravelRolling
{
    enum Direction
    {
        North,
        East,
        South,
        West,
        Northeast,
        Northwest,
        Southeast,
        Southwest
    }//end enum Direction

    public partial class TravelRoller : Form
    {
        private Random r = new Random();

        /// <summary>
        /// returns a new 3d6 result. Relies on SumList() and RollDice()
        /// </summary>
        private int dSix
        {
            get { return SumList(RollDice(3)); }
        } //end dSix

        public TravelRoller()
        {
            InitializeComponent();
        }//end constructor

        /// <summary>
        /// sums a list of integers
        /// </summary>
        private int SumList(List<int> ints)
        {
            int total = 0;
            for (int i = 0; i < ints.Count; i++)
            {
                total += ints[i];
            }//end looping for each integer in list
            return total;
        }//end SumList(ints)

        /// <summary>
        /// just rolls the number of dice provided and gives result
        /// </summary>
        private List<int> RollDice(int diceNum)
        {
            List<int> dice = new List<int>();
            
            for (int i = 0; i < diceNum; i++)
            {
                dice[i] = r.Next(1, 7);
            }//end looping for each dice number
            
            return dice;
        }//end RollDice(diceNum)

        /// <summary>
        /// Rolls dice and tells you if the number rolled is less than or equal to
        /// the number you supply as your goal.
        /// </summary>
        /// <param name="diceNum">number of dice to roll</param>
        private bool RollDiceWithTarget(int requiredNum, int diceNum)
        {
            List<int> dice = RollDice(diceNum);

            return SumList(dice) < requiredNum;
        }//end RollDiceWithTarget(requiredNum, diceNum)

        /// <summary>
        /// Roll for wind direction and speed
        /// </summary>
        private string RollWind(int diceForSpeed, List<Direction> allowedDirections)
        {
            int directionIndex = r.Next(allowedDirections.Count);
            int windSpeed = SumList(RollDice(diceForSpeed));
            return $"Wind is blowing {allowedDirections[directionIndex]} at" +
                $" {windSpeed} mph.";
        }//end RollWind(diceForSpeed, allowedDirections)

        /// <summary>
        /// Rolls to check for nasty weather
        /// </summary>
        /// <param name="optionalRollWeatherType">whether or not to roll to see
        /// what type of bad weather is present</param>
        private string RollNastyWeather(bool optionalRollWeatherType)
        {
            int result = dSix;
            StringBuilder output = new StringBuilder();
            bool isWeatherNasty = false;

            switch (result)
            {
                case int n when (n >= 3 && n <= 6):
                    output.Append("Perfect. The wind is at the trabelers\' backs" +
                        " or in their sails, and the terrain\'s usual hell abates" +
                        " - say, a dry day in jungle terrain, or a warm, snowless " +
                        "in arctic. Add 10% to travel.");
                    break;
                case int n when (n >= 7 && n <= 11):
                    output.Append("Passable. As bad or as fair as usual for the terrain" +
                        ". No effects on travel speed or skills.");
                    break;
                case int n when (n >= 12 && n <= 14):
                    output.Append("Bad. In fantasy, every region has conditions harsh" +
                        " enough to qualify; any rain or snow in most terrain, extra " +
                        "rain in jungle, bonus snow in arctic, sandstorms in desert, " +
                        "etc. Subtract 50% from travel speed.\nSurvival and Tracking " +
                        "rolls that day are at -1.");
                    isWeatherNasty = true;
                    break;
                case int n when (n >= 15 && n <= 18):
                    output.Append("Dire. In fantasy, every region has conditions harsh" +
                        " enough to qualify; any rain or snow in most terrain, extra " +
                        "rain in jungle, bonus snow in arctic, snadstorms in desert, " +
                        "etc. As above, but it's extra bad. Subtract 75% from travel " +
                        "speed.\nSurvival and Tracking rolls that day are at -2.");
                    isWeatherNasty = true;
                    break;
                default:
                    throw new ArgumentOutOfRangeException($"The result of {result}" +
                        $" when rolling 3d6 is invalid");
            }//end switch case

            if(isWeatherNasty && optionalRollWeatherType)
            {
                int oneDie = RollDice(1)[0];

                output.Append("\nWeather Type Rolled: ");

                switch (oneDie)
                {
                    case int n when (n >= 1 && n <= 2):
                        output.Append("Precipitation. As suits the terrain: " +
                            "snow in the arctic, monsoon rains in jungle, and " +
                            "so on. Magic that deals with that sort of precipi" +
                            "tation can eliminate the whole penalty.");
                        break;
                    case int n when (n >= 3 && n <= 4):
                        output.Append("Wind. Spells for coping with wind can" +
                            " wipe away the whole penalty. The visible effects" +
                            " may be terrain-specific (e.g., sandstorms in desert" +
                            "), but the root cause isn't.");
                        break;
                    case int n when (n >= 5 && n <= 6):
                        output.Append("Combination. Magic for coping with either" +
                            " precipitation or wind is enough to get rid of -1 " +
                            "for bad weather or half the penalty for dire weather." +
                            "Dealing witht the full -2 for dire weather calls for" +
                            " both.");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException($"The result of {oneDie}" +
                        $" when rolling 1d6 is invalid");
                }//end switch case
            }//end if we need to roll to see what kind of bad weather

            return output.ToString();
        }//end RollWeather()

        /// <summary>
        /// rolls 3d to see if there's a river in the way. River is 
        /// found if result is less than or equal to targetNum
        /// </summary>
        /// <returns>returns normal text if river exists, otherwise returns
        /// empty string</returns>
        private string RollForRiver(int targetNum, int diceForWidth)
        {
            if(dSix <= targetNum)
            {
                int width = SumList(RollDice(diceForWidth));

                return $"A large river lies in your path. It seems to be about " +
                    $"{width} feet across. How will you cross it.";
            }//end if there's a river
            else
            {
                return String.Empty;
            }//end else no river
        }//end RollForRiver(targetNum, diceForWidth)


    }//end partial class
}//end namespace