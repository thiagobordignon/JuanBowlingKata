using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingScore
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static int CalculateScore(string input)
        {
            int result = 0;
            bool isLastRoundAStrike =  false;
            foreach (char round in input)
            {

                if (round == 'X')
                {
                    if (isLastRoundAStrike)
                    {
                        result = result + 10;
                    }
                    
                    result = result + 10;
                    isLastRoundAStrike = true;
                }
                else
                {
                    int singleRound;
                    if (Int32.TryParse(round.ToString(), out singleRound))
                    {
                        isLastRoundAStrike = false;
                        result = result + singleRound;
                    }
                }
            }
            return result;
        }
    }
}
