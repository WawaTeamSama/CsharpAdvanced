using System;
using System.Collections.Generic;
using System.Text;

namespace Program04
{
    public class Crouse
    {
        public string Name { get; set; }
        private int period;
        public int Period
        {
            get => period;
            set => period = value < 0 ? 0 : value;
        }
        private int credit;
        public int Credit
        {
            get => credit;
            set => credit = value < 0 ? 0 : value;
        }
        private int score;
        public int Score
        {
            get => score;
            set => score = value < 0 || value > 100 ? 0 : value;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
