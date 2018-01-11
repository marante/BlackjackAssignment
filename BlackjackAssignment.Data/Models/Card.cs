using BlackjackAssignment.Data.Enums;

namespace BlackjackAssignment.Data.Models
{
    public class Card
    {
        private CardSuite _suite;
        private int _value;

        public CardSuite CardSuite { get; set; }
        public int CardValue { get; set; }

        public Card(CardSuite suite, int value)
        {
            CardSuite = suite;
            CardValue = value;
        }
    }
}
