using System;
using System.Collections.Generic;

namespace BlackjackAssignment.Data.Models
{
    public class Hand
    {
        private List<Card> _cards;
        public Card LastCard { get; set; }
        public int NumberOfCards => _cards.Count;
        public int Score { get; set; }

        public Hand()
        {
            // TODO Implement Hand functionality
        }

        public void AddCard()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }


    }
}
