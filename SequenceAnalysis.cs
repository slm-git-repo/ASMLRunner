using System.Linq;

namespace Runner
{
    public class SequenceAnalysis
    {
        private string _input;
        public SequenceAnalysis(string input)
        {
            _input = input;
        }

        public string OrderUpperLetters()
        {
            //Get the upper letters
            var upperString = string.Concat(_input.Where(c => c >= 'A' && c <= 'Z'));
            var orderedString = string.Concat(upperString.OrderBy(c => c));
            return orderedString;
        }
    }
}
