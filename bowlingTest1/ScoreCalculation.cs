using Xunit;
using BowlingScore;
    

namespace bowlingTest1

{
    
    public class BowlingGame
    {
        [Theory]
        [InlineData("X|X|X|X|X|X|X|X|X|X||XX", 300)]
        //[InlineData("0-|X|X|X|X|X|X|X|X|X||XX", 280)]
        void CalculateScore(string input, int score)
        {
            int result;

            result = Program.CalculateScore(input);

            Assert.Equal(score, result);
        }
    }
}
