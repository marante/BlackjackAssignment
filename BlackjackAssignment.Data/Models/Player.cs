using System;

namespace BlackjackAssignment.Data.Models
{
    public class Player
    {
        private bool _isFinished;
        public int PlayerId { get; set; }
        public Hand Hand { get; set; }
        public bool IsFinished { get; set; }
        public bool IsThick { get; set; }
        public string Name { get; set; }
        public double Money { get; set; }

        public Player(string name, double money)
        {
            Name = name;
            Money = money;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
